<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calender_Control.aspx.cs" Inherits="Calender_Control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label">Date of Withdrawl</asp:Label>
        <asp:TextBox ID="T1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" Width="81px" />
        <asp:Calendar ID="C1" runat="server" OnSelectionChanged="C1_SelectionChanged">
        </asp:Calendar>
    </div>
    </form>
</body>
</html>
