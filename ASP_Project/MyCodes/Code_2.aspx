<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Code_2.aspx.cs" Inherits="MyCodes_Code_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label><font face="verdana" color="green">Enter number 1:</font></label>
        <asp:TextBox ID="txt1" runat="server" Width="160px"></asp:TextBox>
    </div>
    <div>
        <label><font face="verdana" color="green">Enter number 2:</font></label>
        <asp:TextBox ID="txt2" runat="server" Width="160px"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="submit" runat="server" Text="submit" Height="35px" OnClick="submit_Click" style="font-size: medium" Width="65px" />
    </div>
    <div> 
        <div><br /></div>       
        <font face="verdana" color="green">
            <asp:Literal ID="lit1" runat="server"></asp:Literal>
        </font>
    </div>
    </form>
</body>
</html>
