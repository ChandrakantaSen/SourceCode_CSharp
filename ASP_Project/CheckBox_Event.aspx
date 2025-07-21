<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckBox_Event.aspx.cs" Inherits="CheckBox_Event" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="Table1" runat="server" BorderStyle="Dashed" BorderWidth="1" Height="131px" Width="444px" >
            <asp:TableRow>
                <asp:TableCell><asp:Label ID="Label1" runat="server" Text="Label">Enter ur name:</asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txt1" runat="server" Width="191px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><asp:CheckBox ID="chk1" runat="server" AutoPostBack="True" /><asp:Label ID="Label2" runat="server" Text="Label">Are u graduate ?</asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txt2" runat="server" Width="191px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>&nbsp;</asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="submit" runat="server" Text="Submit" /></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
           <asp:Literal ID="Lit" runat="server"></asp:Literal>
    </div>

        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
    </form>
</body>
</html>
