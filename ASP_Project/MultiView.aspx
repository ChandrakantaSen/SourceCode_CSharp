<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MultiView.aspx.cs" Inherits="MultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Label">Enter Name:</asp:Label>
                <asp:TextBox ID="T1" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Label">Enter Address:</asp:Label>
                <asp:TextBox ID="T2" runat="server"></asp:TextBox>
                <asp:Button ID="B1" runat="server" Text="Next" CommandArgument="1" CommandName="SwitchViewByIndex" />
            </asp:View> 
            <asp:View ID="View2" runat="server">
                <asp:Label ID="Label3" runat="server" Text="Label">Enter UserName:</asp:Label>
                <asp:TextBox ID="T3" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label4" runat="server" Text="Label">Enter PassWord:</asp:Label>
                <asp:TextBox ID="T4" runat="server"></asp:TextBox>
                <asp:Button ID="B2" runat="server" Text="Next" CommandArgument="2" CommandName="SwitchViewByIndex" />
            </asp:View>
            <asp:View ID="View3" runat="server">
                <asp:Label ID="Label5" runat="server" Text="Label">Enter Email Id:</asp:Label>
                <asp:TextBox ID="T5" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label6" runat="server" Text="Label">Enter Phone:</asp:Label>
                <asp:TextBox ID="T6" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </asp:View>
        </asp:MultiView>
    </form>
    <asp:Literal ID="L1" runat="server"></asp:Literal>
</body>
</html>
