Imports System.Xml

Public Class Datos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("hipotesis.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Expertos.aspx")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Response.Redirect("ProbSimp.aspx")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Response.Redirect("ProbCond.aspx")
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Response.Redirect("ProbCondSin.aspx")
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        variables.Doc.RemoveAll()
        Dim NumHip As Integer = UBound(variables.Hipotesis, 2)
        Dim nodo As XmlNode
        nodo = variables.Doc.CreateElement("Datos")
        variables.Doc.AppendChild(nodo)
        Dim nodop As XmlNode = variables.Doc.DocumentElement
        nodo = variables.Doc.CreateNode(XmlNodeType.Element, "Hipotesis", "")
        nodop.AppendChild(nodo)
        For j = 1 To NumHip Step 1
            Dim atr As XmlElement = variables.Doc.CreateElement("Hipo")
            atr.InnerText = variables.Hipotesis(1, j)
            nodo.AppendChild(atr)
            atr = variables.Doc.CreateElement("Abr")
            atr.InnerText = variables.Hipotesis(2, j)
            nodo.AppendChild(atr)
        Next
        nodo = variables.Doc.CreateNode(XmlNodeType.Element, "Expertos", "")
        nodop.AppendChild(nodo)
        Dim NumExp = UBound(variables.Expertos)
        For j = 1 To NumExp Step 1
            Dim atr As XmlElement = variables.Doc.CreateElement("Expert")
            atr.InnerText = variables.Expertos(j)
            nodo.AppendChild(atr)
        Next
        nodo = variables.Doc.CreateNode(XmlNodeType.Element, "ProbSimp", "")
        nodop.AppendChild(nodo)
        Dim NumProb = UBound(variables.ProbSimp, 1)
        Dim NumProb2 = UBound(variables.ProbSimp, 2)
        For i = 1 To NumProb Step 1
            For j = 1 To NumProb2 Step 1
                Dim atr As XmlElement = variables.Doc.CreateElement("Simp")
                atr.InnerText = variables.ProbSimp(i, j)
                nodo.AppendChild(atr)
            Next
        Next
        nodo = variables.Doc.CreateNode(XmlNodeType.Element, "ProbCond", "")
        nodop.AppendChild(nodo)
        NumProb = UBound(variables.ProbCond, 1)
        NumProb2 = UBound(variables.ProbCond, 2)
        For i = 1 To NumProb Step 1
            For j = 1 To NumProb2 Step 1
                Dim atr As XmlElement = variables.Doc.CreateElement("Cond")
                atr.InnerText = variables.ProbCond(i, j)
                nodo.AppendChild(atr)
            Next
        Next
        nodo = variables.Doc.CreateNode(XmlNodeType.Element, "ProbCondSin", "")
        nodop.AppendChild(nodo)
        NumProb = UBound(variables.ProbCondSin, 1)
        NumProb2 = UBound(variables.ProbCondSin, 2)
        For i = 1 To NumProb Step 1
            For j = 1 To NumProb2 Step 1
                Dim atr As XmlElement = variables.Doc.CreateElement("CondSin")
                atr.InnerText = variables.ProbCondSin(i, j)
                nodo.AppendChild(atr)
            Next
        Next
        variables.Doc.Save(System.AppDomain.CurrentDomain.BaseDirectory & "Datos.xml")
        Dim servicio As New WebService1
        Dim lista As XmlNodeList = servicio.matriz(variables.Doc)
        For i = 0 To lista.Count - 1 Step 1
            Response.Write(lista(i).ChildNodes.Item(0).InnerText)
        Next
    End Sub
End Class