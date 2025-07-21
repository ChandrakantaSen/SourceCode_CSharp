<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerMaster.aspx.cs" Inherits="SpeedZone.CustomerMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            color: #000000;
            width: 107px;
        }
        .style3
        {
            width: 713px;
        }
        .style4
        {
            width: 149px;
        }
        .style5
        {
            color: #000000;
            width: 149px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<div id="body">
<table width="834px" border="0" align="center" >
  <tr>
    <td align="center" bgcolor="#003300"><strong><font color="#FFFF00" size="+2">Customer Master Form</font></strong></td>
  </tr>
</table>
<table border="0" align="center" cellpadding="2" bgcolor="#85D6AD" style="width: 834px">
  <tr>
    <td>&nbsp;</td>
    <td class="style4">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td width="131" align="right" class="style2">&nbsp;</td>
    <td align="right" class="style5"><strong>Customer Name :</strong></td>
    <td width="318" class="style3">
        <asp:TextBox ID="CustName" runat="server" Width="300px"></asp:TextBox>
    </td>
  </tr>
  <tr>
    <td width="131" align="right" class="style2">&nbsp;</td>
    <td align="right" class="style5"><strong>Contact Person :</strong></td>
    <td>
        <asp:TextBox ID="CustContact" runat="server" Width="250px"></asp:TextBox>
    </td>
  </tr>
  <tr>
    <td width="131" align="right" class="style2">&nbsp;</td>
    <td align="right" class="style5"><strong>Address : </strong></td>
    <td>
        <asp:TextBox ID="CustAddr" runat="server" Width="300px" Rows="3" 
            TextMode="MultiLine"></asp:TextBox>
      
    </td>
  </tr>
  <tr>
    <td width="131" align="right" class="style2">&nbsp;</td>
    <td align="right" class="style5"><strong>Phone : </strong></td>
    <td>
        <asp:TextBox ID="CustPhon" runat="server" Width="250px"></asp:TextBox>

    </td>
  </tr>
  <tr>
    <td width="131" align="right" class="style2">&nbsp;</td>
    <td align="right" class="style5"><strong>Mobile : </strong></td>
    <td>
        <asp:TextBox ID="CustMob" runat="server" Width="250px"></asp:TextBox>
    </td>
  </tr>
  <tr>
    <td width="131" align="right" class="style2"> &nbsp;</td>
    <td align="right" class="style5"> <strong>eMail : </strong></td>
    <td>
        <asp:TextBox ID="CustEmail" runat="server" Width="250px"></asp:TextBox>
    </td>
  </tr>
  <tr>
    <td width="131" align="right" class="style2">&nbsp;</td>
    <td align="right" class="style5"><strong>GST No. : </strong></td>
    <td>
        <asp:TextBox ID="GSTNo" runat="server" Width="250px"></asp:TextBox>
   </td>
  </tr>
</table>
<table border="0" align="center" cellpadding="2" bgcolor="#009999" style="width: 834px" height="200px">
<tr>
<td>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#003300" BorderStyle="Double" BorderWidth="3px" 
        CellPadding="4" GridLines="Horizontal" Width="791px">
        <Columns>
            <asp:BoundField DataField="CarId" HeaderText="Car No."><ItemStyle Width="100px" /></asp:BoundField>
            <asp:BoundField DataField="ModelID" HeaderText="Model"><ItemStyle Width="100px" /></asp:BoundField>
            <asp:BoundField DataField="CustContact" HeaderText="Car User" ><ItemStyle Width="150px" /></asp:BoundField>
            <asp:BoundField DataField="CustMob" HeaderText="User Contact No" ><ItemStyle Width="120px" /></asp:BoundField>
            <asp:BoundField DataField="CardNo" HeaderText="Coupon No." ><ItemStyle Width="70px" /></asp:BoundField>
            <asp:BoundField DataField="VIdFrom" HeaderText="From"><ItemStyle Width="70px" /></asp:BoundField>
            <asp:BoundField DataField="VIdTo" HeaderText="To" ><ItemStyle Width="70px" /></asp:BoundField>
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
</td>
</tr>

</table>
</div>
<div id="Nevigator">
<table border="0" align="center" cellpadding="2"  style="width: 834px" bgcolor="#003300">
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

</asp:Content>
