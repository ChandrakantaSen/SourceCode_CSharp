<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_DBProject._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/insert.aspx">Insert</asp:HyperLink>
  <br /><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/view.aspx">View</asp:HyperLink>
  <br /><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/search.aspx">Search</asp:HyperLink>
    </div>
    <div>
    
    </div>
    </form>
</body>
</html>
