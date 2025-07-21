<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Image_1.aspx.cs" Inherits="Image_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="Table1" runat="server" BorderStyle="Dotted" BorderWidth="1" style="text-align: justify" Width="526px">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>Image</asp:TableHeaderCell>
                <asp:TableHeaderCell>Image Details</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell><asp:Image ID="Image1" runat="server" ImageUrl="~/image/1.jpg" BorderStyle="Solid" BorderWidth="1" Height="250" Width="250" ImageAlign="Middle" /></asp:TableCell>
                <asp:TableCell>
                    <ul>
                        <li>Glass</li>
                        <li>Spectacles</li>
                        <li>Books</li>
                        <li>Novels</li>
                    </ul>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
