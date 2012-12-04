Public Class ProbCond
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim tabla As New DataTable("tabla")
        If UBound(variables.ProbCond, 1) = 0 Then
            Dim NumHip As Integer = UBound(variables.Hipotesis, 2)
            ReDim variables.ProbCond(NumHip, NumHip)
        End If
        Dim tam As Integer = UBound(variables.Hipotesis, 2)
        For j = 1 To tam Step 1
            Dim etiquetae As Label = New Label
            etiquetae.ID = "labele" & j
            etiquetae.Text = variables.Hipotesis(2, j) & ": <BR>"
            Panel1.Controls.Add(etiquetae)
            tabla.Columns.Add(variables.Hipotesis(2, j))
            For i = 1 To tam Step 1
                Dim etiqueta As Label = New Label
                etiqueta.ID = "Label" & j & i
                etiqueta.Text = variables.Hipotesis(2, i) & ": "
                Dim fila As DataRow
                fila = tabla.NewRow
                fila(variables.Hipotesis(2, j)) = variables.Hipotesis(2, i)
                tabla.Rows.Add(fila)
                tabla.AcceptChanges()
                Panel1.Controls.Add(etiqueta)
                Dim texto As TextBox = New TextBox
                texto.ID = "text" & j & i
                Panel1.Controls.Add(texto)
                Panel1.Controls.Add(New LiteralControl("<BR>"))
            Next
            Panel1.Controls.Add(New LiteralControl("<BR><BR>"))
        Next
        GridView1.DataSource = tabla
        GridView1.DataBind()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
    End Sub
End Class