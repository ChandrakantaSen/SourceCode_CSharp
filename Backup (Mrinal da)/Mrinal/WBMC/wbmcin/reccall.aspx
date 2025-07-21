<%@ Page Language="VB" AutoEventWireup="false" CodeFile="reccall.aspx.vb" Inherits="reccall" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 76px;
        }
        .style3
        {
        }
        .style4
        {
            width: 113px;
        }
        .style5
        {
            width: 108px;
        }
    </style>
</head>
<body bgcolor="e6f6d2">
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style3">&nbsp;
                    </td>
                <td class="style2">&nbsp;
                    </td>
                <td class="style4">&nbsp;
                    </td>
                <td class="style5">&nbsp;
                    </td>
                <td>&nbsp;
                    </td>
            </tr>
            <tr>
                <td class="style3">&nbsp;
                    </td>
                <td class="style2">&nbsp;
                    </td>
                <td class="style4">&nbsp;
                    </td>
                <td class="style5">&nbsp;
                    </td>
                <td>&nbsp;
                    </td>
            </tr>
            <tr>
                <td class="style3">&nbsp;
                    </td>
                <td class="style2">
                    <asp:Label ID="Label1" runat="server" Text="Login ID : "></asp:Label>
                </td>
                <td class="style4">
                    <asp:TextBox ID="txtPW" runat="server" TextMode="Password" Width="104px"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:Button ID="btnSubmit" runat="server" Text="Show" Width="64px" />
                </td>
                <td>&nbsp;
                    </td>
            </tr>
            <tr>
                <td class="style3">&nbsp;
                    </td>
                <td class="style2">&nbsp;
                    </td>
                <td class="style4">&nbsp;
                    </td>
                <td class="style5">&nbsp;
                    </td>
                <td>&nbsp;
                    </td>
            </tr>
            <tr>
                <td class="style3" align="center" colspan="5">Final checkings are being made. As soon as the same is finalised, it will be open. Till then please bear with us</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
