﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.17929
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.WebService1Soap")>  _
    Public Interface WebService1Soap
        
        'CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*")>  _
        Function HelloWorld(ByVal request As ServiceReference1.HelloWorldRequest) As ServiceReference1.HelloWorldResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*")>  _
        Function HelloWorldAsync(ByVal request As ServiceReference1.HelloWorldRequest) As System.Threading.Tasks.Task(Of ServiceReference1.HelloWorldResponse)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class HelloWorldRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="HelloWorld", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ServiceReference1.HelloWorldRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReference1.HelloWorldRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class HelloWorldRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class HelloWorldResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="HelloWorldResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ServiceReference1.HelloWorldResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReference1.HelloWorldResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class HelloWorldResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public HelloWorldResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal HelloWorldResult As String)
            MyBase.New
            Me.HelloWorldResult = HelloWorldResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface WebService1SoapChannel
        Inherits ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class WebService1SoapClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.WebService1Soap)
        Implements ServiceReference1.WebService1Soap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_WebService1Soap_HelloWorld(ByVal request As ServiceReference1.HelloWorldRequest) As ServiceReference1.HelloWorldResponse Implements ServiceReference1.WebService1Soap.HelloWorld
            Return MyBase.Channel.HelloWorld(request)
        End Function
        
        Public Function HelloWorld() As String
            Dim inValue As ServiceReference1.HelloWorldRequest = New ServiceReference1.HelloWorldRequest()
            inValue.Body = New ServiceReference1.HelloWorldRequestBody()
            Dim retVal As ServiceReference1.HelloWorldResponse = CType(Me,ServiceReference1.WebService1Soap).HelloWorld(inValue)
            Return retVal.Body.HelloWorldResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_WebService1Soap_HelloWorldAsync(ByVal request As ServiceReference1.HelloWorldRequest) As System.Threading.Tasks.Task(Of ServiceReference1.HelloWorldResponse) Implements ServiceReference1.WebService1Soap.HelloWorldAsync
            Return MyBase.Channel.HelloWorldAsync(request)
        End Function
        
        Public Function HelloWorldAsync() As System.Threading.Tasks.Task(Of ServiceReference1.HelloWorldResponse)
            Dim inValue As ServiceReference1.HelloWorldRequest = New ServiceReference1.HelloWorldRequest()
            inValue.Body = New ServiceReference1.HelloWorldRequestBody()
            Return CType(Me,ServiceReference1.WebService1Soap).HelloWorldAsync(inValue)
        End Function
    End Class
End Namespace