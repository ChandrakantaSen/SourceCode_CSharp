<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="ASPCRUD1.Contacts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvContacts" runat="server" AutoGenerateColumns="false"
            DataKeyNames="ContactId, CountryId, StateId" CellPadding="10" 
            CellSpacing="0" ShowFooter="true" OnRowCommand="gvContacts_RowCommand">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>Contact Person</HeaderTemplate>
                    <ItemTemplate><%#Eval("ContactPerson") %></ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtContactPerson" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <HeaderTemplate>Contact No</HeaderTemplate>
                    <ItemTemplate><%#Eval("ContactNo") %></ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtContactNo" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <HeaderTemplate>Country</HeaderTemplate>
                    <ItemTemplate><%#Eval("CountryName") %></ItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCountry_SelectedIndex">
                            <asp:ListItem Text="Select Country" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                    </FooterTemplate>
                    <HeaderTemplate>State</HeaderTemplate>
                    <ItemTemplate><%#Eval("StateName") %></ItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="ddlState" runat="server">
                            <asp:ListItem Text="Select State" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lbEdit" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                        &nbsp;&nbsp;
                        <asp:LinkButton ID="lbDelete" runat="server" CommandName="Delete">Delete</asp:LinkButton>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:Button ID="btnInsert" runat="server" Text="Save" CommandName="Insert" ValidationGroup="Add" />
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
