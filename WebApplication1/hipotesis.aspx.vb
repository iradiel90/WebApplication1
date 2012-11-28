Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim tam As Integer
        tam = UBound(variables.Hipotesis, 2)
        For i = 1 To tam Step 1
            Response.Write(variables.Hipotesis(1, i))
            Response.Write(variables.Hipotesis(2, i))
        Next

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReDim Preserve variables.Hipotesis(2, UBound(variables.Hipotesis, 2) + 1)
        variables.Hipotesis(1, UBound(variables.Hipotesis, 2)) = TextBox1.Text()
        variables.Hipotesis(2, UBound(variables.Hipotesis, 2)) = TextBox2.Text()
        TextBox1.Text() = ""
        TextBox2.Text() = ""
        Response.Redirect("hipotesis.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Captura.aspx")
    End Sub
End Class