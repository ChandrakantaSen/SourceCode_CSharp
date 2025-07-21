<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="ASP_DBProject.insert" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label">Employee Id</asp:Label>
        <asp:TextBox ID="id" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label">Employee Name</asp:Label>
        <asp:TextBox ID="nm" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label">Employee Salary</asp:Label>
        <asp:TextBox ID="sal" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="submit" runat="server" Text="Submit" onclick="submit_Click"/>
        <br />
        <br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <span lang="en-us">&nbsp; </span>
        <asp:Literal ID="Literal2" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
