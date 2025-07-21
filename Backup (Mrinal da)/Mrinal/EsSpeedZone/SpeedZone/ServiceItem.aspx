<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ServiceItem.aspx.cs" Inherits="SpeedZone.ServiceItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <tr>
        <td>

<div id="body">
<table width="500px" border="0" align="center" >
  <tr>
    <td align="center" bgcolor="#990000"><strong><font color="#FFFF00" size="+2">Service Item Master Form</font></strong></td>
  </tr>
</table>
<table border="0" align="center" cellpadding="2" bgcolor="#FF9191" style="width: 500px">
  <tr>
    <td class="style1">&nbsp;</td>
    <td class="style2">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>

 <tr>
    <td align="right" class="style1">&nbsp;</td>
    <td align="right" class="style2"><strong><span class="style3">Service</span> :</strong></td>
    <td width="318" class="style3">
        <asp:TextBox ID="Make" runat="server" Width="300px"></asp:TextBox>
    </td>
  </tr>
  <tr>
    <td class="style1">&nbsp;</td>
    <td class="style2">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
</div>

<div id="Nevigator">
<table border="0" align="center" cellpadding="2"  style="width: 500px" bgcolor="#990000">
<tr>
    <td width="14%" align="center">&nbsp;</td>
    <td width="14%" align="center"><asp:Button ID="btnInsert" runat="server" Text="Insert"  Width="80px" /></td>
    <td width="14%" align="center">&nbsp;</td>
    <td width="14%" align="center"><asp:Button ID="btnEdit" runat="server" Text="Edit" Width="80px" /></td>
    <td width="14%" align="center">&nbsp;</td>
    <td width="14%" align="center"><asp:Button ID="btnDel" runat="server" Text="Delete"  Width="80px" /></td>
    <td width="14%" align="center">&nbsp;</td>
</tr>
</table>
</div>

<div id="list">
<table border="0" align="center" cellpadding="0" bgcolor="#D50000" style="width: 500px" height="200px">
<tr>
<td>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" GridLines="Horizontal" Width="450px">
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
