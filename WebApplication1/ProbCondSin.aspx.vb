Public Class ProbCondSin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim tabla As New DataTable("tabla")
        tabla.Columns.Add("Eventos")
        If UBound(variables.ProbCondSin, 1) = 0 Then
            Dim NumHip As Integer = UBound(variables.Hipotesis, 2)
            ReDim variables.ProbCondSin(NumHip, NumHip)
        End If
        Dim tam As Integer = UBound(variables.Hipotesis, 2)
        For j = 1 To tam Step 1
            tabla.Columns.Add(variables.Hipotesis(2, j))
        Next
        For j = 1 To tam Step 1
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
                        celda.Text = variables.ProbCondSin(i + 1, j)
                    Catch ex As Exception

                    End Try
                    If (i + 1) = j Then
                        celda.Text = 0
                        celda.ReadOnly = True
                    End If
                    GridView1.Rows(i).Cells(j).Controls.Add(celda)
                Next
            Catch ex As Exception

            End Try
        Next
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Captura.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NumHip As Integer = UBound(variables.Hipotesis, 2)
        ReDim variables.ProbCondSin(NumHip, NumHip)
        For i = 1 To NumHip Step 1
            For j = 1 To NumHip Step 1
                Dim texto As TextBox = DirectCast(GridView1.Rows(i - 1).Cells(j).FindControl("prob" & i & j), TextBox)
                variables.ProbCondSin(i, j) = Convert.ToDouble(texto.Text())
            Next
        Next
    End Sub
End Class