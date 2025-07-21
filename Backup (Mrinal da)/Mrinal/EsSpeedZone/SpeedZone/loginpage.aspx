<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="SpeedZone.loginpage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Styles/Login.css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">
        .style2
        {
        }
        .style3
        {
            color: #CCFFFF;
        }
        .style4
        {
            width: 113px;
        }
        .style5
        {
            width: 31px;
        }
        .style6
        {
            background-color: #FFFF66;
        }
    </style>
</head>
<body>
    <form id="Form1" runat="server">
    <div id="login">

        <center>
        <table style="width: 600px; background-color: #0066FF;">
        <tr>
                <td class="style6" colspan="5" align="center" 
                    style="font-family: 'Arial Black'; font-size: x-large; color: #003399; font-weight: bold; font-variant: normal">

                    User Login</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;
                </td>
                <td class="style2">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td class="style4">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr >
                <td class="style5" align="center" rowspan="6" width="200px" >

                    <asp:Image ID="Image1" runat="server" Height="110px" 
                        ImageUrl="~/Images/login.png" Width="110px" ImageAlign="Middle" />
                </td>
                <td class="style2">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td class="style4">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style2" align="right" width="100px">
                    <strong style="color: #CCFFFF">User Name :</strong></td>
                <td align="left" colspan="2">
                    <asp:TextBox ID="TextBox1" runat="server" Width="150px" BackColor="#CCFFFF"></asp:TextBox>

                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td class="style4">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style2" align="right"  width="100px">
                    <span class="style3"><strong>Password :</strong> </span>
                </td>
                <td align="left" colspan="2">

                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="100px" 
                        BackColor="#CCFFFF"></asp:TextBox>

                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td class="style4">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
          <tr>
                <td class="style2" colspan="2" align="center">
                    &nbsp;<asp:Button ID="btnLogin" runat="server" Font-Bold="True" Height="25px" 
                        Text="Login" Width="85px" />
&nbsp;&nbsp;
                </td>
                <td class="style4"  align="center">
                    <asp:Button ID="btnCancel" runat="server" Font-Bold="True" Height="25px" 
                        Text="Cancel" Width="85px" />
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
          <tr>
                <td class="style5" width="200px">
                    &nbsp;
                </td>
                <td class="style2"  width="100px">
                    &nbsp;
                </td>
                <td width="100px">
                    &nbsp;
                </td>
                <td class="style4" width="100px">
                    &nbsp;
                </td>
                <td width="100px">
                    &nbsp;
                </td>
            </tr>
        </table>
        </center>
 
    </div>
       </form>
</body>
</html>
