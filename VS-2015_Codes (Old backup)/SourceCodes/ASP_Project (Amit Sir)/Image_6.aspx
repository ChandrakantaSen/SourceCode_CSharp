<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Image_6.aspx.cs" Inherits="Image_6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ImageMap ID="ImageMap1" runat="server" Height="272px" ImageUrl="~/image/5.jpg" Width="557px">
            <asp:PolygonHotSpot Coordinates="(164,230),(384,111),(335,231),(251,34),(115,109)" HotSpotMode="Navigate" NavigateUrl="Drop_down.aspx" />
        </asp:ImageMap>
    </form>
</body>
</html>
