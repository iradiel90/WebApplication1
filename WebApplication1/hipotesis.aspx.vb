Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim tabla As New DataTable("tabla")
        tabla.Columns.Add("Hipotesis")
        tabla.Columns.Add("Abreviacion")
        Dim NumHip As Integer = UBound(variables.Hipotesis, 2)
        For j = 1 To NumHip Step 1
            Dim fila As DataRow
            fila = tabla.NewRow
            fila("Hipotesis") = variables.Hipotesis(1, j)
            fila("Abreviacion") = variables.Hipotesis(2, j)
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

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text() <> "" And TextBox2.Text() <> "" Then
            ReDim Preserve variables.Hipotesis(2, UBound(variables.Hipotesis, 2) + 1)
            variables.Hipotesis(1, UBound(variables.Hipotesis, 2)) = TextBox1.Text()
            variables.Hipotesis(2, UBound(variables.Hipotesis, 2)) = TextBox2.Text()
            TextBox1.Text() = ""
            TextBox2.Text() = ""
        End If
        Response.Redirect("hipotesis.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Captura.aspx")
    End Sub
End Class