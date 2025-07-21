<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPage.aspx.cs" Inherits="Recapsulation.InsertPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
				<asp:Label ID="Label1" runat="server" Text="Label">Enter the name:&nbsp;</asp:Label>
				<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
		<div>
			<asp:Label ID="Label2" runat="server" Text="Label">Enter the class:&nbsp;</asp:Label>
			<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
		</div>
		<div>
			<asp:Label ID="Label3" runat="server" Text="Label">Enter the roll:&nbsp;</asp:Label>
			<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
		</div>
		<div>
			<asp:Button ID="Button1" runat="server" Text="Submit" />
		</div>
    	<asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </form>
</body>
</html>
