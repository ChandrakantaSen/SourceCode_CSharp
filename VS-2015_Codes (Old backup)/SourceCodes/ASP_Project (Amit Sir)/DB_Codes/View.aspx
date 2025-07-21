<%@ Page Language="C#" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="DB_Codes_View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </div>
        <asp:Button ID="Button1" runat="server" Text="See Records" />
    </form>
</body>
</html>
