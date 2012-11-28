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
        <p>
        <asp:Button ID="Button1" runat="server" Text="Añadir" />
        </p>
    </form>
</body>
</html>
