<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Drop_down.aspx.cs" Inherits="Drop_down" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label">
            <font face="verdana" color="green" Width="150px">Enter the City:</font>
        </asp:Label>
        <asp:DropDownList ID="ddl_1" runat="server" Height="25px" Width="107px">
            <asp:ListItem>C</asp:ListItem>
            <asp:ListItem>C++</asp:ListItem>
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>php</asp:ListItem>
            <asp:ListItem>C#</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btn_1" runat="server" Text="Submit" OnClick="btn_1_Click" Width="74px" />
    </div>
    </form>
    <div>
        <asp:Literal ID="Lit_1" runat="server"></asp:Literal>
    </div>
</body>
</html>
