<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Expertos.aspx.vb" Inherits="WebApplication1.expertos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Experto: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    </div>
        <div style="margin-left: 40px">
            <asp:Button ID="Button1" runat="server" Text="Añadir experto" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Guardar" />
        </div>
    </form>
</body>
</html>
