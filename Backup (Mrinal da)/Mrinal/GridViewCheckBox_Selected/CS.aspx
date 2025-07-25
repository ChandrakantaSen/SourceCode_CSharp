﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CS.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
        AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="chkRow" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="150" />
            <asp:TemplateField HeaderText="Country" ItemStyle-Width="150">
                <ItemTemplate>
                    <asp:Label ID="lblCountry" runat="server" Text='<%# Eval("Country") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnGetSelected" runat="server" Text="Get selected records" OnClick="GetSelectedRecords" />
    <hr />
    <u>Selected Rows</u>
    <br />
    <asp:GridView ID="gvSelected" runat="server" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
        AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="150" />
            <asp:BoundField DataField="Country" HeaderText="Country" ItemStyle-Width="150" />
        </Columns>
    </asp:GridView>
    </form>
</body>
</html>
