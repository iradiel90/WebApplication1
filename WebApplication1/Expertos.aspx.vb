Public Class expertos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim tam As Integer
        tam = UBound(variables.Expertos)
        For i = 1 To tam Step 1
            Response.Write(variables.Expertos(i))
        Next
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Captura.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReDim Preserve variables.Expertos(UBound(variables.Expertos) + 1)
        variables.Expertos(UBound(variables.Expertos)) = TextBox1.Text()
        TextBox1.Text() = ""
        Response.Redirect("Expertos.aspx")
    End Sub
End Class