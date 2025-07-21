<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Image_5.aspx.cs" Inherits="Image_5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ImageMap ID="ImageMap1" runat="server" Height="272px" HotSpotMode="Navigate" ImageUrl="~/image/0.jpeg" Width="557px">
            <asp:CircleHotSpot HotSpotMode="Navigate" NavigateUrl="~/Drop_down.aspx" Radius="20" X="280" Y="107" />
        </asp:ImageMap>
    </div>
    </form>
</body>
</html>
