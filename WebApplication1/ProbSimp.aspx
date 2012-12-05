<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ProbSimp.aspx.vb" Inherits="WebApplication1.ProbSimp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
        <p style="margin-left: 40px">
            <asp:Button ID="Button1" runat="server" Text="Guardar" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Atrás" />
        </p>
    </form>
</body>
</html>
