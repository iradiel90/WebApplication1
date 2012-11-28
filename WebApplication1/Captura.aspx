<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Captura.aspx.vb" Inherits="WebApplication1.Datos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Hipotesis: "></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Añadir hipotesis" />
        </p>
        <asp:Label ID="Label2" runat="server" Text="Expertos: "></asp:Label>
        <asp:Button ID="Button2" runat="server" Text="Añadir expertos" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Probabilidades Simples: "></asp:Label>
        <asp:Button ID="Button3" runat="server" Text="Añadir Probabilidades" />
    </form>
</body>
</html>
