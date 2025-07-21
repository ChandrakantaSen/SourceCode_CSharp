<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileUpload_3.aspx.cs" Inherits="FileUpload_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 419px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" Width="324px" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="UpLoad" Height="33px" OnClick="Button1_Click" Width="100px" />
        <br />
        <br />
        <br />
    </div>
        <br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        <br />
    </form>
</body>
</html>
