<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab1_ASPwithEF.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>ASP.NET Example with Entity Framework</h1>
        <table>
            <tr>
                <td>Enter Product Name : </td>
                <td>
                    <asp:TextBox ID="txtProdName" runat="server"></asp:TextBox>
                    &nbsp; &nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                </td>
            </tr>
            <tr>
                <td>Select Product :</td>
                <td colspan="2">
                    <asp:DropDownList ID="ddlProduct" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProduct_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <table>
                        <tr>
                            <td>Product Name:</td>
                            <td>
                                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Price:</td>
                            <td>
                                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Quantity:</td>
                            <td>
                                <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnSave" runat="server" Text="SAVE" OnClick="btnSave_Click" />
                            </td>
                            <td>
                                <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
