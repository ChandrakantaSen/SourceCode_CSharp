<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Image_2.aspx.cs" Inherits="Image_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:ImageButton ID="ImageButton1" runat="server" PostBackUrl="~/Image_2Mailer.aspx" Height="250" Width="250" ImageAlign="Middle" ImageUrl="~/image/4.jpg" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
