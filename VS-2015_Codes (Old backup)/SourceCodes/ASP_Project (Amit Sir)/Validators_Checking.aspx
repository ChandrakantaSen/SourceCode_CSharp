<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Validators_Checking.aspx.cs" Inherits="Validators_Checking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 780px">
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label">UserName:&nbsp;</asp:Label>
        <asp:TextBox ID="Txt_1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter correct username" ControlToValidate="Txt_1" Font-Bold="True" Font-Size="Medium" ForeColor="#FF9933" Display="None"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label">Password:&nbsp;</asp:Label>
        <asp:TextBox ID="Txt_2" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Length with in 6 - 8 characters" Font-Size="Medium" Font-Bold="True" ControlToValidate="Txt_2" ValidationExpression="\S{6,8}"></asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label">ReType Password:&nbsp;</asp:Label>
        <asp:TextBox ID="Txt_3" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Please check correct password" ControlToCompare="Txt_2" ControlToValidate="Txt_3" Font-Bold="True" Font-Size="Medium" ForeColor="#FF3300"></asp:CompareValidator>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label">Age:&nbsp;</asp:Label>
        <asp:TextBox ID="Txt_4" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Please insert age within 20 - 25 range" ControlToValidate="Txt_4" Font-Bold="True" Font-Size="Medium" ForeColor="#FF3300" MaximumValue="25" MinimumValue="20"></asp:RangeValidator>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Label">Alt. Email Address:&nbsp;</asp:Label>
        <asp:TextBox ID="Txt_5" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter Correct email id" ControlToValidate="Txt_5" Font-Bold="True" Font-Size="Medium" ForeColor="#FF9966" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Label">Admin Code:&nbsp;</asp:Label>
        <asp:TextBox ID="Txt_6" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Enter custom validation" ControlToValidate="Txt_6" Font-Bold="True" Font-Size="Medium" ForeColor="#66FF33" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="84px" />
    </form>
</body>
</html>
