﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SampleWebCrud.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
			<asp:Label ID="Label1" runat="server" Text="Label">Enter name:</asp:Label>
			<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
			<br />
			<asp:Button ID="Button1" runat="server" Text="Submit" />
			<br />
			<asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
