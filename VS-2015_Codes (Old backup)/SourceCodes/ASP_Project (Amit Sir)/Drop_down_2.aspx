<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Drop_down_2.aspx.cs" Inherits="Drop_down_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label">
            <font face="verdana" color="green" Width="150px">Enter the City:</font>
        </asp:Label>
        <asp:DropDownList ID="ddl_1" runat="server" Height="27px" Width="140px" AutoPostBack="True" OnSelectedIndexChanged="ddl_1_SelectedIndexChanged"></asp:DropDownList>
    </div>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="Label">
            <font face="verdana" color="green" Width="150px">Enter the Fees:</font>
        </asp:Label>
        <asp:TextBox ID="txt_1" runat="server" Height="22px" Width="140px"></asp:TextBox>
    </div>
    </form>
    <div>
        <asp:Literal ID="Lit_1" runat="server"></asp:Literal>
    </div>
</body>
</html>
