Imports Oracle.DataAccess.Client

Public Class ctrlStokAdd



    Dim query As String
    Dim marca As String
    Dim modelo As String
    Private Sub TextBoxX1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            'ElseIf e.KeyChar = "," Then para agregar comas y convertir el texto a punto flotante
            '    e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txSegunda_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txSegunda.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            'ElseIf e.KeyChar = "," Then para agregar comas y convertir el texto a punto flotante
            '    e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ctrlStokAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            frmMain._cnn.Open()
            frmMain._Bs = New BindingSource
            setBSProducto("0", "0", frmMain._Bs, dgP, cbF)
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try
        

    End Sub


    Private Sub txB_TextChanged(sender As Object, e As EventArgs) Handles txB.TextChanged
        Try
            Dim ret As Integer = Filtrar_tabla(cbF.Text, txB.Text.Trim, frmMain._Bs, dgP)
            If ret = 0 Then
                txB.BackColor = Color.Red
            Else
                txB.BackColor = Color.White
            End If
        Catch ex As Exception
            _ESTADO(ex.Message, frmMain.lbEstado)
        End Try
        
    End Sub

    Private Sub dgP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgP.CellClick
        marca = dgP.SelectedCells(0).Value
        modelo = dgP.SelectedCells(1).Value
        '  MsgBox(marca)
        '  MsgBox(modelo)
        lbCodigo.Text = dgP.SelectedCells(2).Value
    End Sub

    
    Private Sub btGuarda_Click(sender As Object, e As EventArgs) Handles btGuarda.Click
        If txCantidad.Text <> "" Then
            Dim r As Integer = MsgBox("Esta seguro de agregar este producto al invetario local?", vbYesNo)
            If r = vbYes Then
                Try
                    frmMain._cnn.Open()
                    Dim dbms As New DBMSOutput(frmMain._cnn)
                    dbms.Enable()
                    frmMain._cmd = New OracleCommand()
                    frmMain._cmd.Connection = frmMain._cnn
                    With frmMain._cmd
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_NUEVO_PR_INVENTARIO"
                        .Parameters.Add(New OracleParameter("v_idlugar", OracleDbType.Varchar2)).Value = "BOD"
                        .Parameters.Add(New OracleParameter("v_marca", OracleDbType.Varchar2)).Value = CStr(marca)
                        .Parameters.Add(New OracleParameter("v_modelo", OracleDbType.Varchar2)).Value = CStr(modelo)
                        .Parameters.Add(New OracleParameter("v_nueva", OracleDbType.Varchar2)).Value = CStr(txCantidad.Text)
                        .Parameters.Add(New OracleParameter("v_segunda", OracleDbType.Varchar2)).Value = CStr(txSegunda.Text)
                        .Parameters.Add(New OracleParameter("v_detalle", OracleDbType.Varchar2)).Value = CStr(txDetalle.Text)
                        .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                    End With
                    frmMain._cmd.ExecuteNonQuery()
                    If frmMain._cmd.Parameters("v_estado").Value > 0 Then
                        dbms.Show(frmMain.lbEstado)
                        dbms.Disable()
                        txCantidad.Text = ""
                        txSegunda.Text = ""
                        lbCodigo.Text = "--"
                        txDetalle.Text = ""
                        marca = 0
                        modelo = 0
                    ElseIf frmMain._cmd.Parameters("v_estado").Value = 0 Then
                        dbms.Show(frmMain.lbEstado)
                        txB.Focus()
                        txB.SelectAll()
                    Else
                        dbms.Show()
                    End If
                Catch ex As Exception
                    _ESTADO(ex.Message, frmMain.lbEstado)
                Finally
                    frmMain._cnn.Close()
                End Try
            End If
        Else
            _ESTADO("No pueden existir campos vacios", frmMain.lbEstado)
        End If
    End Sub
End Class
