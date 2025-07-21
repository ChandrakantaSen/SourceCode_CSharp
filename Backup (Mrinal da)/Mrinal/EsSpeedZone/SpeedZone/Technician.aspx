<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Technician.aspx.cs" Inherits="SpeedZone.Technician" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            color: #000000;
        }
        
        .style3
        {
            color: #003366;
            width: 78px;
        }
        .style4
        {
            color: #003366;
            width: 15px;
        }
        .style5
        {
            color: #000000;
        }
        .style6
        {
            width: 106px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <tr>
        <td>
            <div id="body">
                <table width="500px" border="0" align="center">
                    <tr>
                        <td align="center" bgcolor="#CCFFCC">
                            <strong><font color="#800000" size="+2">Technician Master Form</font></strong>
                        </td>
                    </tr>
                </table>
                <table border="0" align="center" cellpadding="2" bgcolor="#00CC66" style="width: 500px">
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td class="style6">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style4">
                            &nbsp;
                        </td>
                        <td align="right" class="style6">
                            <strong><span class="style5">Name :</span></strong>
                        </td>
                        <td width="318" class="style3">
                            <asp:TextBox ID="StaffName" runat="server" Width="230px" Style="margin-left: 0px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style4">
                            &nbsp;
                        </td>
                        <td align="right" class="style6">
                            <strong><span class="style5">Nick Name :</span></strong>
                        </td>
                        <td width="318" class="style3">
                            <asp:TextBox ID="NickNam" runat="server" Width="151px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style4">
                            &nbsp;
                        </td>
                        <td align="right" class="style6">
                            <strong><span class="style5">Address :</span></strong>
                        </td>
                        <td width="318" class="style3">
                            <asp:TextBox ID="StaffAdd" runat="server" Width="230px" Height="50px" TextMode="MultiLine"
                                Style="margin-left: 0px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style4">
                            &nbsp;
                        </td>
                        <td align="right" class="style6">
                            <strong style="color: #000000">Contact Details :</strong>
                        </td>
                        <td width="318" class="style3">
                            <asp:TextBox ID="StaffCont" runat="server" Width="230px" Height="30px" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            &nbsp;
                        </td>
                        <td class="style6">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </div>
            <div id="Nevigator">
                <table border="0" align="center" cellpadding="2" style="width: 500px" bgcolor="#CCFFCC">
                    <tr>
                        <td width="14%" align="center">
                            &nbsp;
                        </td>
                        <td width="14%" align="center">
                            <asp:Button ID="btnInsert" runat="server" Text="Insert" Width="80px" />
                        </td>
                        <td width="14%" align="center">
                            &nbsp;
                        </td>
                        <td width="14%" align="center">
                            <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="80px" />
                        </td>
                        <td width="14%" align="center">
                            &nbsp;
                        </td>
                        <td width="14%" align="center">
                            <asp:Button ID="btnDel" runat="server" Text="Delete" Width="80px" />
                        </td>
                        <td width="14%" align="center">
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </div>
            <div id="list">
                <table border="0" align="center" cellpadding="0" bgcolor="#006600" style="width: 500px"
                    height="200px">
                    <tr>
                        <td>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
                                BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal"
                                Width="450px">
                                <AlternatingRowStyle BackColor="#F7F7F7" />
                                <Columns>
                                    <asp:BoundField HeaderText="MakeId" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="MakeId" HeaderText="Make">
                                        <ItemStyle Width="100px" />
                                    </asp:BoundField>
                                </Columns>
                                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                                <SortedDescendingHeaderStyle BackColor="#3E3277" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </div>
        </td>
    </tr>
</asp:Content>
