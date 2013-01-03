Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Xml

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
<System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService1
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hola a todos"
    End Function

    <WebMethod()>
    Public Function matriz(ByVal documento As XmlDocument)
        Dim lista As XmlNodeList
        Dim Hipotesis(2, 0) As String
        Dim Expertos(0) As String
        Dim ProbSimp(0, 0) As Double
        Dim ProbCond(0, 0) As Double
        Dim ProbCondSin(0, 0) As Double
        lista = documento.SelectNodes("/Datos/Hipotesis/Hipo")
        Dim NumHip = lista.Count
        ReDim Hipotesis(2, NumHip)
        For i = 0 To NumHip - 1 Step 1
            Hipotesis(1, i) = lista(i).ChildNodes.Item(0).InnerText
        Next
        lista = documento.SelectNodes("/Datos/Hipotesis/Abr")
        For i = 0 To NumHip - 1 Step 1
            Hipotesis(2, i) = lista(i).ChildNodes.Item(0).InnerText
        Next
        lista = documento.SelectNodes("/Datos/Expertos/Expert")
        Dim NumExp = lista.Count
        ReDim Expertos(NumExp)
        For i = 0 To NumExp - 1 Step 1
            Expertos(i) = lista(i).ChildNodes.Item(0).InnerText
        Next
        lista = documento.SelectNodes("/Datos/ProbSimp/Simp")
        ReDim ProbSimp(NumExp, NumHip)
        For i = 0 To NumHip - 1 Step 1
            For j = 0 To NumExp - 1 Step 1
                ProbSimp(j, i) = lista(i).ChildNodes.Item(0).InnerText
            Next
        Next
        lista = documento.SelectNodes("/Datos/ProbCond/Cond")
        ReDim ProbCond(NumHip, NumHip)
        For i = 0 To NumHip - 1 Step 1
            For j = 0 To NumHip - 1 Step 1
                ProbCond(j, i) = lista(i).ChildNodes.Item(0).InnerText
            Next
        Next
        lista = documento.SelectNodes("/Datos/ProbCondSin/CondSin")
        ReDim ProbCondSin(NumHip, NumHip)
        For i = 0 To NumHip - 1 Step 1
            For j = 0 To NumHip - 1 Step 1
                ProbCondSin(j, i) = lista(i).ChildNodes.Item(0).InnerText
            Next
        Next


        Return ProbSimp(0, 1)
    End Function

End Class