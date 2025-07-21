<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" name="frm1" runat="server">
    <div>
        <asp:Literal ID="Literal1" runat="server">
        </asp:Literal>
        <asp:Table ID="Table1" runat="server" BorderStyle="Dotted" BorderWidth="1" Height="119px" Width="352px">
            <asp:TableRow>
                <asp:TableCell>User Name: </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txt1" runat="server" TextMode="SingleLine" ToolTip="Enter the user name"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Password</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txt2" runat="server" TextMode="Password" ToolTip="Enter the password"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>&nbsp;</asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="submit" runat="server" OnClick="submit_click" Text="Login" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>