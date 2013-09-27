
Imports Oracle.DataAccess.Client
Imports DevComponents.DotNetBar

Public Class DBMSOutput
    '
    ' our instance variables. It is always best to
    ' use callable or prepared statements and prepare (parse)
    ' them once per program execution, rather then one per
    ' execution in the program. The cost of reparsing is
    ' very high. Also -- make sure to use BIND VARIABLES!
    '
    ' we use three statments in this class. One to enable
    ' dbms_output - equivalent to SET SERVEROUTPUT on in SQL*PLUS.
    ' another to disable it -- like SET SERVEROUTPUT OFF.
    ' the last is to "dump" or display the results from dbms_output
    ' using system.out
    '
    '
    Private cmdEnable As OracleCommand
    Private cmdDisable As OracleCommand
    Private cmdShow As OracleCommand

    '
    ' our constructor simply prepares the three
    ' statements we plan on executing.
    '
    ' the statement we prepare for SHOW is a block of
    ' code to return a String of dbms_output output. Normally,
    ' you might bind to a PLSQL table type but the jdbc drivers
    ' don't support PLSQL table types -- hence we get the output
    ' and concatenate it into a string. We will retrieve at least
    ' one line of output -- so we may exceed your MAXBYTES parameter
    ' below. If you set MAXBYTES to 10 and the first line is 100
    ' bytes long, you will get the 100 bytes. MAXBYTES will stop us
    ' from getting yet another line but it will not chunk up a line.
    '
    '
    Public Sub New(ByVal conn As OracleConnection)
        cmdEnable = New OracleCommand("begin dbms_output.enable(:1); end;", conn)
        cmdEnable.Parameters.Add("1", OracleDbType.Int32)

        cmdDisable = New OracleCommand("begin dbms_output.disable;end;", conn)

        cmdShow = New OracleCommand("declare " & _
        " l_line varchar2(255); " & _
        " l_done number; " & _
        " l_buffer long; " & _
        "begin " & _
        " loop " & _
        " exit when length(l_buffer)+255 > :maxbytes OR l_done = 1; " & _
        " dbms_output.get_line( l_line, l_done ); " & _
        " l_buffer := l_buffer || l_line || chr(10); " & _
        " end loop; " & _
        " :done := l_done; " & _
        " :buffer := l_buffer; " & _
        "end;", conn)
        cmdShow.Parameters.Add("maxbytes", OracleDbType.Int32).Value() = 32000
        cmdShow.Parameters.Add("done", OracleDbType.Int32).Direction() = ParameterDirection.Output
        cmdShow.Parameters.Add("buffer", OracleDbType.Varchar2).Direction = ParameterDirection.Output
        cmdShow.Parameters("buffer").Size = 32000
    End Sub

    '
    ' enable simply sets your size and executes
    ' the dbms_output.enable call
    '
    '
    Public Sub Enable()
        cmdEnable.Parameters("1").Value = 32000
        cmdEnable.ExecuteNonQuery()
    End Sub


    '
    ' disable only has to execute the dbms_output.disable call
    '
    Public Sub Disable()
        cmdDisable.ExecuteNonQuery()
    End Sub

    '
    ' show does most of the work. It loops over
    ' all of the dbms_output data, fetching it in this
    ' case 32,000 bytes at a time (give or take 255 bytes).
    ' It will print this output on stdout by default (just
    ' reset what System.out is to change or redirect this
    ' output).
    '
    Public Sub Show(ByRef lb As LabelItem)
        Dim done As Integer = 0
        Dim msg As String = ""
        While True
            cmdShow.ExecuteNonQuery()
            msg = msg + cmdShow.Parameters("buffer").Value.ToString
            If cmdShow.Parameters("done").Value = 1 Then Exit While
        End While
        _ESTADO(msg, lb)
        Disable()
    End Sub

    Public Sub Show()
        Dim done As Integer = 0
        Dim msg As String = ""
        While True
            cmdShow.ExecuteNonQuery()
            msg = msg + cmdShow.Parameters("buffer").Value.ToString
            If cmdShow.Parameters("done").Value = 1 Then Exit While
        End While
        MsgBox(msg, MsgBoxStyle.Information)
        Disable()
    End Sub

End Class


