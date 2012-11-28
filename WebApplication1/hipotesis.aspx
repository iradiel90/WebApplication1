<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="hipotesis.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Hipotesis:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Abreviación: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
    </div>
        <p style="margin-left: 40px">
        <asp:Button ID="Button1" runat="server" Text="Añadir" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Guardar" />
        </p>
    </form>
</body>
</html>
