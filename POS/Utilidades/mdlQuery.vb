Imports Oracle.DataAccess.Client
Imports DevComponents.DotNetBar.Controls

Module mdlQuery
    Dim query As String

    Sub setDgProducto(ByVal Ma As String, ByVal Mo As String, ByRef dg As DataGridView)
        If Ma > 0 And Mo > 0 Then
            query = "SELECT MO.IDPR_MARCA AS idMarca,	MO.IDPR_MODELO AS idModelo, CA.NOMBRE AS CATEGORIA,	" &
                    "   TI.NOMBRE AS TIPO,	MA.NOMBRE AS MARCA,   MO.NOMBRE AS MODELO,	MO.DETALLE AS DETALLE " &
                    "FROM AGENCIA.PR_MODELO Mo" &
                    "   INNER JOIN AGENCIA.PR_MARCA MA ON MO.IDPR_MARCA = MA.IDMARCA" &
                    "   INNER JOIN AGENCIA.PR_TIPO TI ON MO.IDPR_TIPO = TI.IDPR_TIPO " &
                    "   INNER JOIN AGENCIA.PR_CATEGORIA CA ON TI.IDPR_CATEGORIA = CA.IDPR_CATEGORIA " &
                    "WHERE" &
                    "   MO.IDPR_MARCA = " & Ma & " AND" &
                    "   MO.IDPR_MODELO = " & Mo
        Else
            query = "SELECT MO.IDPR_MARCA AS idMarca,	MO.IDPR_MODELO AS idModelo, CA.NOMBRE AS CATEGORIA,	" &
                   "   TI.NOMBRE AS TIPO,	MA.NOMBRE AS MARCA,   MO.NOMBRE AS MODELO,	MO.DETALLE AS DETALLE " &
                   "FROM AGENCIA.PR_MODELO Mo" &
                   "   INNER JOIN AGENCIA.PR_MARCA MA ON MO.IDPR_MARCA = MA.IDMARCA" &
                   "   INNER JOIN AGENCIA.PR_TIPO TI ON MO.IDPR_TIPO = TI.IDPR_TIPO " &
                   "   INNER JOIN AGENCIA.PR_CATEGORIA CA ON TI.IDPR_CATEGORIA = CA.IDPR_CATEGORIA "
            '"WHERE" &
            '"   MO.IDPR_MARCA = v_marca AND" &
            '"   MO.IDPR_MODELO = v_modelo "
        End If
        frmMain._cmd = New OracleCommand(query, frmMain._cnn)
        Dim r As OracleDataReader = frmMain._cmd.ExecuteReader()
        While r.Read
            dg.Rows.Add(r.GetDecimal(0), r.GetDecimal(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetString(6))
        End While
        r.Close()
        'Dim ds = New DataSet
        'Dim da = New OracleDataAdapter(query, frmMain._cnn)
        'da.Fill(ds)
        'dg.DataSource = ds.Tables(0)

    End Sub

    Sub setBSProducto(ByVal Ma As String, ByVal Mo As String, ByRef BS As BindingSource, ByRef dg As DataGridView, ByRef cbf As ComboBoxEx)
        If Ma > 0 And Mo > 0 Then
            query = "SELECT MO.IDPR_MARCA AS idMarca,	MO.IDPR_MODELO AS idprModelo, MO.IDPR_MARCA ||'-'||MO.IDPR_MODELO as CODIGO, CA.NOMBRE AS CATEGORIA,	" &
                    "   TI.NOMBRE AS TIPO,	MA.NOMBRE AS MARCA,   MO.NOMBRE AS MODELO,	MO.DETALLE AS DETALLE " &
                    "FROM AGENCIA.PR_MODELO Mo" &
                    "   INNER JOIN AGENCIA.PR_MARCA MA ON MO.IDPR_MARCA = MA.IDMARCA" &
                    "   INNER JOIN AGENCIA.PR_TIPO TI ON MO.IDPR_TIPO = TI.IDPR_TIPO " &
                    "   INNER JOIN AGENCIA.PR_CATEGORIA CA ON TI.IDPR_CATEGORIA = CA.IDPR_CATEGORIA " &
                    "WHERE" &
                    "   MO.IDPR_MARCA = " & Ma & " AND" &
                    "   MO.IDPR_MODELO = " & Mo
        Else
            query = "SELECT MO.IDPR_MARCA AS idMarca,	MO.IDPR_MODELO AS idprModelo, MO.IDPR_MARCA ||'-'||MO.IDPR_MODELO as CODIGO, CA.NOMBRE AS CATEGORIA,	" &
                   "   TI.NOMBRE AS TIPO,	MA.NOMBRE AS MARCA,   MO.NOMBRE AS MODELO,	MO.DETALLE AS DETALLE " &
                   "FROM AGENCIA.PR_MODELO Mo" &
                   "   INNER JOIN AGENCIA.PR_MARCA MA ON MO.IDPR_MARCA = MA.IDMARCA" &
                   "   INNER JOIN AGENCIA.PR_TIPO TI ON MO.IDPR_TIPO = TI.IDPR_TIPO " &
                   "   INNER JOIN AGENCIA.PR_CATEGORIA CA ON TI.IDPR_CATEGORIA = CA.IDPR_CATEGORIA "
            '"WHERE" &
            '"   MO.IDPR_MARCA = v_marca AND" &
            '"   MO.IDPR_MODELO = v_modelo "
        End If
        'frmMain._cmd = New OracleCommand(query, frmMain._cnn)
        'Dim r As OracleDataReader = frmMain._cmd.ExecuteReader()
        'While r.Read
        '    dg.Rows.Add(r.GetDecimal(0), r.GetDecimal(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetString(6))
        'End While
        'r.Close()
        Dim dt = New DataTable
        Dim da = New OracleDataAdapter(query, frmMain._cnn)
        da.Fill(dt)
        BS.DataSource = dt
        dg.DataSource = BS.DataSource
        ' dg.Columns(0).Visible = False
        ' dg.Columns(1).Visible = False
        'cargar los items de opciones para filtrar
        With (cbf)
            .Items.Add("CODIGO")
            .Items.Add("CATEGORIA")
            .Items.Add("TIPO")
            .Items.Add("MARCA")
            .Items.Add("MODELO")
            .Items.Add("DETALLE")
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = 3
        End With
    End Sub

    Sub setBSInventario(ByVal Envio As Boolean, ByVal Ti As String, ByRef BS As BindingSource, ByRef dg As DataGridView, ByRef cbf As ComboBoxEx)
        If Envio Then
            query = "SELECT MO.IDPR_MARCA, MO.IDPR_MODELO, MO.IDPR_MARCA || '-' || MO.IDPR_MODELO AS CODIGO, CA.NOMBRE AS CATEGORIA, TI.NOMBRE AS TIPO, MA.NOMBRE AS MARCA," &
                           "MO.NOMBRE AS MODELO, MO.DETALLE AS DETALLE, INV.NUEVA AS NUEVOS, INV.SEGUNDA AS USADOS, INV.DETALLE AS DESCRIPCION " &
                    "FROM AGENCIA.PR_INVENTARIO INV " &
                         "INNER JOIN AGENCIA.PR_MODELO MO ON INV.IDPR_MODELO = MO.IDPR_MODELO AND INV.IDPR_MARCA = MO.IDPR_MARCA  " &
                         "INNER JOIN AGENCIA.PR_MARCA MA ON MO.IDPR_MARCA = MA.IDMARCA " &
                         "INNER JOIN AGENCIA.PR_TIPO TI ON MO.IDPR_TIPO = TI.IDPR_TIPO AND MO.IDPR_CATEGORIA = TI.IDPR_CATEGORIA " &
                         "INNER JOIN AGENCIA.PR_CATEGORIA CA ON TI.IDPR_CATEGORIA = CA.IDPR_CATEGORIA " &
                         "INNER JOIN AGENCIA.LUGAR LU ON INV.IDLUGAR = LU.IDLUGAR " &
                         "WHERE LU.IDLU_TIPO = 2 AND LU.IDLUGAR = '" & Ti & "'"
        Else
            query = "SELECT MO.IDPR_MARCA, MO.IDPR_MODELO, MO.IDPR_MARCA || '-' || MO.IDPR_MODELO AS CODIGO, CA.NOMBRE AS CATEGORIA, TI.NOMBRE AS TIPO, MA.NOMBRE AS MARCA," &
                           "MO.NOMBRE AS MODELO, MO.DETALLE AS DETALLE, INV.NUEVA AS NUEVOS, INV.SEGUNDA AS USADOS, INV.DETALLE AS DESCRIPCION " &
                    "FROM AGENCIA.PR_INVENTARIO INV " &
                         "INNER JOIN AGENCIA.PR_MODELO MO ON INV.IDPR_MODELO = MO.IDPR_MODELO AND INV.IDPR_MARCA = MO.IDPR_MARCA  " &
                         "INNER JOIN AGENCIA.PR_MARCA MA ON MO.IDPR_MARCA = MA.IDMARCA " &
                         "INNER JOIN AGENCIA.PR_TIPO TI ON MO.IDPR_TIPO = TI.IDPR_TIPO AND MO.IDPR_CATEGORIA = TI.IDPR_CATEGORIA " &
                         "INNER JOIN AGENCIA.PR_CATEGORIA CA ON TI.IDPR_CATEGORIA = CA.IDPR_CATEGORIA " &
                         "INNER JOIN AGENCIA.LUGAR LU ON INV.IDLUGAR = LU.IDLUGAR " &
                         "WHERE LU.IDLU_TIPO = 3 AND LU.IDLUGAR = '" & Ti & "'"
            '"WHERE" &
            '"   MO.IDPR_MARCA = v_marca AND" &
            '"   MO.IDPR_MODELO = v_modelo "
        End If
        'frmMain._cmd = New OracleCommand(query, frmMain._cnn)
        'Dim r As OracleDataReader = frmMain._cmd.ExecuteReader()
        'While r.Read
        '    dg.Rows.Add(r.GetDecimal(0), r.GetDecimal(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetString(6))
        'End While
        'r.Close()
        Dim dt = New DataTable
        Dim da = New OracleDataAdapter(query, frmMain._cnn)
        da.Fill(dt)
        BS.DataSource = dt
        dg.DataSource = BS.DataSource
        dg.Columns(0).Visible = False
        dg.Columns(1).Visible = False
        'cargar los items de opciones para filtrar
        
    End Sub

End Module
