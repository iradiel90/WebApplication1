Public Class ProbSimp
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim tabla As New DataTable("tabla")
        tabla.Columns.Add("Eventos")
        Dim NumExp As Integer = UBound(variables.Expertos)
        Dim NumHip As Integer = UBound(variables.Hipotesis, 2)
        If UBound(variables.ProbSimp, 1) = 0 Then
            ReDim variables.ProbSimp(NumHip, NumExp)
        End If
        For j = 1 To NumExp Step 1
            tabla.Columns.Add(variables.Expertos(j))
        Next
        For j = 1 To NumHip Step 1
            Dim fila As DataRow
            fila = tabla.NewRow
            fila("Eventos") = variables.Hipotesis(2, j)
            tabla.Rows.Add(fila)
            tabla.AcceptChanges()
        Next
        GridView1.DataSource = tabla
        GridView1.DataBind()
        For i = 0 To GridView1.Rows.Count() Step 1
            Try
                For j = 1 To GridView1.Rows(i).Cells.Count Step 1
                    Dim celda As TextBox = New TextBox
                    celda.ID = "prob" & (i + 1) & j
                    Try
                        celda.Text = variables.ProbSimp(i + 1, j)
                    Catch ex As Exception

                    End Try
                    GridView1.Rows(i).Cells(j).Controls.Add(celda)
                Next
            Catch ex As Exception

            End Try
        Next
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NumHip As Integer = UBound(variables.Hipotesis, 2)
        Dim NumExp As Integer = UBound(variables.Expertos)
        ReDim variables.ProbCondSin(NumHip, NumExp)
        For i = 1 To NumHip Step 1
            For j = 1 To NumExp Step 1
                Dim texto As TextBox = DirectCast(GridView1.Rows(i - 1).Cells(j).FindControl("prob" & i & j), TextBox)
                If texto.Text <> "" Then
                    variables.ProbSimp(i, j) = Convert.ToDouble(texto.Text())
                End If
            Next
        Next
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Captura.aspx")
    End Sub
End Class