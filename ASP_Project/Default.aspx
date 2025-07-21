<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label">Enter ur name:</asp:Label>
        <asp:TextBox ID="txt1" runat="server" Width="191px"></asp:TextBox>
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <asp:TextBox ID="txt2" runat="server" Width="191px"></asp:TextBox>
        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
    </div> 
        <br />
        <asp:Literal ID="Lit" runat="server"></asp:Literal>
    </form>
</body>
</html>
