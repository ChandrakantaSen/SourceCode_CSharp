<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Code_1.aspx.cs" Inherits="MyCodes_Code_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
        <label><font face="verdana" color="green">Enter ur name:</font></label>
        <asp:TextBox ID="txt1" runat="server" Width="160px"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="submit" runat="server" Text="submit" Height="35px" OnClick="submit_Click" style="font-size: medium" Width="65px" />
    </div>
    <div>
        <asp:Literal ID="lit1" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
