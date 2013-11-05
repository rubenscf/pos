Imports Oracle.DataAccess.Client

Public Class ctrlGestionContratos
    Dim query As String
    Dim impreso As Boolean = False
    Sub cargaPedido()
         Try
            Me.CREDITOSTableAdapter.Fill(Me._DS.CREDITOS, "CSO")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        If dgD.Rows.Count > 0 Then
            dgD.DataSource = vbNull
            dgD.Refresh()

            lbCtipo.Text = ""
            lbCdpi.Text = ""
            lbcNombre.Text = ""
            lbCApellido.Text = ""
            lbCBienes.Text = ""
            lbCNit.Text = ""
            lbCDireccion.Text = ""
            lbCTelefono.Text = ""
            lbCIngreso.Text = ""

            lbFTipo.Text = ""
            lbFDPI.Text = ""
            lbFNombre.Text = ""
            lbFApellido.Text = ""
            lbFbienes.Text = ""
            lbFnit.Text = ""
            lbFDireccion.Text = ""
            lbFTelefono.Text = ""
            lbFingreso.Text = ""
        End If
    End Sub


    Private Sub ctrlPedidos_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaPedido()
    End Sub

    


    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
         If dg.RowCount > 0 Then
            Dim resp As Integer = MsgBox("ACEPTAR SOLICITUD DE CONTRATO?", MsgBoxStyle.YesNo)
            If resp = vbYes Then
                Try

               
                frmMain._cnn.Open()
                Dim dbms As New DBMSOutput(frmMain._cnn)
                dbms.Enable()
                frmMain._cmd = New OracleCommand()
                frmMain._cmd.Connection = frmMain._cnn
                With frmMain._cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SP_ACEPTAR_CREDITO"
                    .Parameters.Add(New OracleParameter("v_sale", OracleDbType.Varchar2)).Value = dg.CurrentRow.Cells(4).Value.ToString
                    .Parameters.Add(New OracleParameter("v_idenvio", OracleDbType.Int32)).Value = CInt(dg.CurrentRow.Cells(5).Value)
                    .Parameters.Add(New OracleParameter("v_estado", OracleDbType.Int32, ParameterDirection.Output))
                End With
                frmMain._cmd.ExecuteNonQuery()

                If frmMain._cmd.Parameters("v_estado").Value > 0 Then
                    dbms.Show(frmMain.lbEstado)
                    dbms.Disable()
                Else
                    dbms.Show()
                End If
                    cargaPedido()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                Finally
                    frmMain._cnn.Close()
                End Try
            End If
        End If

    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If dg.RowCount > 0 Then
            Dim resp As Integer = MsgBox("ANULAR SOLICITUD DE CONTRATO?", MsgBoxStyle.YesNo)
            If resp = vbYes Then
                query = "UPDATE VE_CREDITO SET ESTADO = 'CAN' WHERE IDLUGAR = '" & dg.CurrentRow.Cells(4).Value & "' and IDVE_CREDITO = " & dg.CurrentRow.Cells(5).Value
                Try
                    frmMain._cmd = New OracleCommand
                    frmMain._cnn.Open()
                    frmMain._cmd.CommandText = query
                    frmMain._cmd.Connection = frmMain._cnn
                    frmMain._cmd.ExecuteNonQuery()
                    cargaPedido()
                    _ESTADO("Contrato Anulado", frmMain.lbEstado)
                Catch ex As Exception
                    _ESTADO(ex.Message, frmMain.lbEstado)
                Finally
                    frmMain._cnn.Close()
                End Try
            End If
        End If
    End Sub
    

   

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        Dim r As OracleDataReader
        Dim query As String
        Try


            query = "SELECT ma.NOMBRE as MARCA, mo.NOMBRE as MODELO, crd.SUBTOTAL FROM  AGENCIA.VE_CR_DETALLE crd" &
" INNER JOIN AGENCIA.PR_MODELO mo ON crd.IDPR_MARCA = mo.IDPR_MARCA AND crd.IDPR_MODELO = mo.IDPR_MODELO " &
" INNER JOIN AGENCIA.PR_MARCA ma ON mo.IDPR_MARCA = ma.IDMARCA " &
" WHERE CRD.IDLUGAR = '" & dg.CurrentRow.Cells(4).Value & "' and CRD.IDVE_CREDITO = '" & dg.CurrentRow.Cells(5).Value & "'"

            _SET_DG("detalle_credito", query, dgD)
        


            query = "SELECT CL_NIVEL, DPI, NOMBRE, APELLIDO, BIENES, NIT, DIRECCION, TELEFONO, INGRESO FROM CLIENTE WHERE IDCLIENTE = " & dg.CurrentRow.Cells(0).Value
        frmMain._cnn.Open()

        r = _CONSULTAR_orcl(query)
        While (r.Read)
            lbCtipo.Text = r.GetOracleString(0).ToString
            lbCdpi.Text = r.GetString(1).ToString
            lbcNombre.Text = r.GetString(2).ToString
            lbCApellido.Text = r.GetString(3).ToString
            lbCBienes.Text = r.GetString(4).ToString
            lbCNit.Text = r.GetString(5).ToString
            lbCDireccion.Text = r.GetString(6).ToString
            lbCTelefono.Text = r.GetString(7).ToString
            lbCIngreso.Text = "Q." & r.GetDecimal(8).ToString
        End While
        r.Close()
        query = "SELECT  CL_NIVEL, DPI, NOMBRE, APELLIDO, BIENES, NIT, DIRECCION, TELEFONO, INGRESO FROM CLIENTE WHERE IDCLIENTE = " & dg.CurrentRow.Cells(1).Value

        r = _CONSULTAR_orcl(query)
        While (r.Read)
            lbFTipo.Text = r.GetOracleString(0).ToString
            lbFDPI.Text = r.GetString(1).ToString
            lbFNombre.Text = r.GetString(2).ToString
            lbFApellido.Text = r.GetString(3).ToString
            lbFbienes.Text = r.GetString(4).ToString
            lbFnit.Text = r.GetString(5).ToString
            lbFDireccion.Text = r.GetString(6).ToString
            lbFTelefono.Text = r.GetString(7).ToString
            lbFingreso.Text = "Q." & r.GetDecimal(8).ToString
        End While
        r.Close()
        dgD.Refresh()
        Catch ex As System.Exception

            _ESTADO(ex.Message, frmMain.lbEstado)
        Finally
            frmMain._cnn.Close()
        End Try



    End Sub


    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        cargaPedido()
        _ESTADO("Datos Cargados...", frmMain.lbEstado)
    End Sub

    
  
End Class
