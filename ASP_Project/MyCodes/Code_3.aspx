
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Code_3.aspx.cs" Inherits="MyCodes_Code_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label><font face="verdana" color="green">Enter the name:</font></asp:Label>
        <asp:TextBox ID="txt1" runat="server" Width="150px"></asp:TextBox>
    </div>
    <div>
        <asp:Label>
           <font face="verdana" color="red">
            <asp:RadioButtonList ID="rb_list" runat="server" RepeatDirection="Vertical" RepeatLayout="Table">
               <asp:ListItem Text="Excellent" Value="Excellent" ></asp:ListItem>
               <asp:ListItem Text="Very Good" Value="Very Good"></asp:ListItem>
               <asp:ListItem Text="Good" Value="Good"></asp:ListItem>
               <asp:ListItem Text="Fair" Value="Fair"></asp:ListItem>
               <asp:ListItem Text="Bad" Value="Bad"></asp:ListItem>
             </asp:RadioButtonList>
            </font>
        </asp:Label>
    </div>
    <div>
        <br />
        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click"/>
    </div>
    </form>
    <div>
        <font face="verdana" color="green"><asp:Literal ID="lit_1" runat="server"></asp:Literal></font>
    </div>
</body>
</html>