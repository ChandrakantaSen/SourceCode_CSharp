<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdRotator.aspx.cs" Inherits="AdRotator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/AD.xml" Height="100px" Width="800px" />
    </div>
    </form>
</body>
</html>
