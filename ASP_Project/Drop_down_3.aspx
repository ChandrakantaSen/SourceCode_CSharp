<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Drop_down_3.aspx.cs" Inherits="Drop_down_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label">
            <font face="verdana" color="green" Width="150px">Enter the Day:</font>
        </asp:Label>
        <asp:DropDownList ID="ddl_1" runat="server" Height="27px" Width="140px"></asp:DropDownList>
    </div>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="Label">
            <font face="verdana" color="green" Width="150px">Enter the Month:</font>
        </asp:Label>
        <asp:DropDownList ID="ddl_2" runat="server" Height="27px" Width="140px"></asp:DropDownList>
    </div>
    <br />
    <div>
        <asp:Label ID="Label3" runat="server" Text="Label">
            <font face="verdana" color="green" Width="150px">Enter the Year:</font>
        </asp:Label>
        <asp:DropDownList ID="ddl_3" runat="server" Height="27px" Width="140px"></asp:DropDownList>
    </div>
    <br /><br />
    <div>
        <asp:Button ID="btn_1" runat="server" Text="Submit" OnClick="btn_1_Click" Width="94px" />   
    </div>
    </form>
    <div>
        <asp:Literal ID="Lit_1" runat="server"></asp:Literal>
    </div>
</body>
</html>
