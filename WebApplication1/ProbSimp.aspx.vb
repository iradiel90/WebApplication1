Public Class ProbSimp
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If UBound(variables.ProbSimp, 1) = 0 Then
            Dim NumExp As Integer = UBound(variables.Expertos)
            Dim NumHip As Integer = UBound(variables.Hipotesis, 2)
            ReDim variables.ProbSimp(NumHip, NumExp)
        End If
        Dim tam As Integer = UBound(variables.Hipotesis, 2)
        Dim tame As Integer = UBound(variables.Expertos)
        For j = 1 To tame Step 1
            Dim etiquetae As Label = New Label
            etiquetae.ID = "labele" & j
            etiquetae.Text = variables.Expertos(j) & ": <BR>"
            Panel1.Controls.Add(etiquetae)
            For i = 1 To tam Step 1
                Dim etiqueta As Label = New Label
                etiqueta.ID = "Label" & j & i
                etiqueta.Text = variables.Hipotesis(2, i) & ": "
                Panel1.Controls.Add(etiqueta)
                Dim texto As TextBox = New TextBox
                texto.ID = "text" & j & i
                Panel1.Controls.Add(texto)
                Panel1.Controls.Add(New LiteralControl("<BR>"))
            Next
            Panel1.Controls.Add(New LiteralControl("<BR><BR>"))
        Next
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tam As Integer = UBound(variables.Hipotesis, 2)
        Dim tame As Integer = UBound(variables.Expertos)
        For j = 1 To tame Step 1
            For i = 1 To tam Step 1
                Dim texto As TextBox = DirectCast(Panel1.FindControl("text" & j & i), TextBox)
                variables.ProbSimp(i, j) = Convert.ToDouble(texto.Text())
            Next
        Next
        For j = 1 To tame Step 1
            Response.Write(DirectCast(Panel1.FindControl("labele" & j), Label).Text)
            'Response.Write("<BR>")
            For i = 1 To tam Step 1
                Response.Write(DirectCast(Panel1.FindControl("label" & j & i), Label).Text)
                Response.Write(variables.ProbSimp(i, j))
                Response.Write("<BR>")
            Next
            Response.Write("<BR>")
        Next
    End Sub
End Class