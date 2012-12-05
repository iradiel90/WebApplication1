Public Class expertos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim tam As Integer
        tam = UBound(variables.Expertos)
        For i = 1 To tam Step 1
            Response.Write(variables.Expertos(i))
        Next

        Dim tabla As New DataTable("tabla")
        tabla.Columns.Add("Expertos")
        Dim NumExp As Integer = UBound(variables.Expertos)
        For j = 1 To NumExp Step 1
            Dim fila As DataRow
            fila = tabla.NewRow
            fila("Expertos") = variables.Expertos(j)
            tabla.Rows.Add(fila)
            tabla.AcceptChanges()
        Next
        GridView1.DataSource = tabla
        GridView1.DataBind()
        'For i = 0 To GridView1.Rows.Count() Step 1
        'Try
        'For j = 0 To GridView1.Rows(i).Cells.Count Step 1
        'Dim celda As TextBox = New TextBox
        'celda.ID = "hipo" & (i + 1) & (j + 1)
        'celda.ReadOnly = True
        'Try
        'celda.Text = variables.Hipotesis(j + 1, i + 1)
        'Catch ex As Exception
        '
        'End Try
        'GridView1.Rows(i).Cells(j).Controls.Add(celda)
        'Next
        'Catch ex As Exception
        '
        'End Try
        'Next
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Captura.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text() <> "" Then
            ReDim Preserve variables.Expertos(UBound(variables.Expertos) + 1)
            variables.Expertos(UBound(variables.Expertos)) = TextBox1.Text()
            TextBox1.Text() = ""
        End If
        Response.Redirect("Expertos.aspx")
    End Sub
End Class