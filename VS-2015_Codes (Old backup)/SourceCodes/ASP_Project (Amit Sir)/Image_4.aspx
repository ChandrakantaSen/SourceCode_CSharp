<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Image_4.aspx.cs" Inherits="Image_4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/image/4.jpg" Height="200px" Width="400px" ImageAlign="Middle" HotSpotMode="Inactive">
            <asp:RectangleHotSpot HotSpotMode="Navigate" NavigateUrl="~/Image_1.aspx" Right="200" Top="200" />
            <asp:RectangleHotSpot HotSpotMode="Navigate" Left="201" NavigateUrl="~/Image_2.aspx" Right="400" Top="200" />
        </asp:ImageMap>
    </div>
    </form>
</body>
</html>
