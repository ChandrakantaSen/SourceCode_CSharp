<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            height: 21px;
            width: 82px;
        }
        .style2
        {
            width: 82px;
        }
        .style3
        {
            height: 1px;
            width: 82px;
        }
        .style4
        {
            width: 21px;
        }
        .style5
        {
            height: 1px;
            width: 86px;
        }
        .style6
        {
            height: 21px;
            width: 86px;
        }
        .style11
        {
            width: 35px;
        }
        .style13
        {
            height: 1px;
            width: 77px;
        }
        .style15
        {
            width: 10px;
        }
        .style16
        {
            height: 1px;
            width: 10px;
        }
        .style17
        {
            height: 21px;
            width: 10px;
        }
        .style18
        {
            height: 21px;
            width: 1px;
        }
        .style19
        {
            height: 1px;
            width: 1px;
        }
        .style21
        {
            height: 21px;
            width: 147px;
        }
        .style22
        {
            height: 1px;
            width: 147px;
        }
        .style23
        {
            width: 147px;
        }
        .style24
        {
            width: 27px;
        }
        .style25
        {
            width: 129px;
        }
        .style26
        {
            height: 1px;
            width: 129px;
        }
        .style27
        {
            height: 21px;
            width: 129px;
        }
        .style28
        {
            width: 268435376px;
        }
        .style29
        {
            width: 70px;
        }
        .style30
        {
            height: 21px;
            width: 70px;
        }
        .style31
        {
            width: 32px;
        }
        .style32
        {
            width: 42px;
        }
        .style33
        {
            width: 479px;
        }
    </style>
</head>
<body bgcolor="e6f6d2">
    <table style="width:634px">
      <!--DWLayoutTable-->
        <tr>
        <td style="text-align:right; font-size: medium; text-decoration: underline blink; font-family: 'Times New Roman', Times, serif; font-weight: bold; color: #FF0000;" >&nbsp;                            </td>
                        
                        </td>
        </tr>
                <tr>
        <td style="text-align:right; font-size: medium; font-family: 'Times New Roman', Times, serif; font-weight: bold; color: #FF0000;" >
                            <div align="center">Any Error / omission in data is regretted.                             Please contact WBMC for correction, if any </div></td>
     <tr>                   
<td style="text-align:right; font-size: medium; font-family: 'Times New Roman', Times, serif; font-weight: bold; color: #FF0000;" > 
  <div align="center">Particulars of the doctors registered on and from 01.01.1945 have been included in the<br /> 
    website and the rests are in our Office Database. Doctor(s) registered before 01.01.1945 <br />
    may 
    contact us for inclusion in the list </div></td>
        </tr>
		</tr>
                <tr>
                  <td height="37"></td>
                  <td></td>
                </tr>
    </table>
    <form id="form1" runat="server">
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <table style="width: 634px">
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True"
                                Text="Final Registration" Font-Size="Small" Visible="False"></asp:Label></td>
                        
                    </tr>
                    <tr>
                        <td class="style15">
                        </td>
                        <td style="text-align: left" class="style25">
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Small"
                                Text="New Registration :" Visible="False"></asp:Label></td>
                        
                        </td>
                        <td colspan="3">
                        </td>
                        <td colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                        </td>
                        <td style="text-align: right;" colspan="2">
                            <asp:Label ID="Label3" runat="server" Text="Application Date :" 
                                Font-Size="Small" Visible="False"></asp:Label></td>
                        <td class="style4">
                            <asp:TextBox ID="RAppDt" runat="server" Width="76px" Font-Size="Small" 
                                Visible="False"></asp:TextBox></td>
                        <td class="style11">
                            <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="Small" 
                                Text="(mm/dd/yyyy)" Visible="False"></asp:Label>
                        </td>
                        <td class="style29">&nbsp;
                      </td>
                        <td colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                        </td>
                        <td class="style26">
                        </td>
                        <td class="style5" colspan="2">
                        </td>
                        <td class="style13">
                        </td>
                        <td style="height: 1px;" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="style17">
                        </td>
                        <td style="text-align: left;" class="style27">
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Small"
                                Text="Search By :" Width="149px"></asp:Label></td>
                        <td style="width: 8px; height: 21px;">
                        </td>
                        <td class="style6" colspan="2">
                        </td>
                        <td class="style30">
                        </td>
                        <td style="height: 21px;" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="style17">
                        </td>
                        <td style="text-align: right" class="style27">
                            <asp:Label ID="Label5" runat="server" Text="Registration No. : " Font-Size="Small"></asp:Label></td>
                        <td style="width: 8px; height: 21px">
                        </td>
                        <td class="style6" colspan="2">
                            <asp:TextBox ID="RRegNo" runat="server" Width="76px" Font-Size="Small"></asp:TextBox></td>
                        <td class="style30">
                        </td>
                        <td class="style24">
                            <asp:Button ID="RSubmit" runat="server" style="margin-left: 0px" 
                                Text="Submit" />
                        </td>
                        <td class="style28">&nbsp;
                      </td>
                    </tr>
                    <tr>
                        <td class="style15">
                        </td>
                        <td style="text-align: right;" class="style25">
                            <asp:Label ID="Label6" runat="server" Text="First Name :" Font-Size="Small"></asp:Label></td>

                        <td colspan="2">
                            <asp:TextBox ID="RNam" runat="server" Width="170px" Font-Size="Small"></asp:TextBox></td>
                        <td align="right" class="style29">
                            <asp:Label ID="Label15" runat="server" Font-Size="Small" Text="Last Name :"></asp:Label>
                        </td>
                        <td class="style24">
                            <asp:TextBox ID="LNam" runat="server" Font-Size="Small"></asp:TextBox>
                        </td>
                        <td class="style28">
                            <asp:Button ID="RClear" runat="server" Text="Clear" />
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <table style="width: 639px">
                    <tr>
                        <td colspan="2" style="height: 21px">
                            <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True"
                                Text="Provisional Registration" Font-Size="Small"></asp:Label></td>
                        <td class="style18">
                        </td>
                        <td class="style1" colspan="2">
                        </td>
                        <td style="height: 21px;" colspan="2">
                        </td>
                        <td style="width: 100px; height: 21px;">
                        </td>
                        <td style="width: 77px; height: 21px;">
                        </td>
                    </tr>
                    <tr>
                        <td class="style17">
                        </td>
                        <td style="text-align: left; " class="style21">
                            <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Small"
                                Text="New Registration :"></asp:Label></td>
                        <td class="style18">
                        </td>
                        <td colspan="4" style="height: 21px">
                        </td>
                        <td style="width: 100px; height: 21px;">
                        </td>
                        <td style="width: 77px; height: 21px;">
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                        </td>
                        <td style="text-align: right;" colspan="2">
                            <asp:Label ID="Label9" runat="server" Text="Application Date :" Font-Size="Small"></asp:Label></td>
                        <td class="style2">
                            <asp:TextBox ID="PAppDt" runat="server" Width="76px" Font-Size="Small"></asp:TextBox></td>
                        <td class="style31">
                            <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Size="Small" 
                                Text="(mm/dd/yyyy)"></asp:Label>
                        </td>
                        <td colspan="2">&nbsp;
                      </td>
                        <td style="width: 100px">
                        </td>
                        <td style="width: 77px">
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                        </td>
                        <td class="style22">
                        </td>
                        <td class="style19">
                        </td>
                        <td class="style3" colspan="2">
                        </td>
                        <td style="height: 1px;" colspan="2">
                        </td>
                        <td style="width: 100px; height: 1px;">
                        </td>
                        <td style="width: 77px; height: 1px;">
                        </td>
                    </tr>
                    <tr>
                        <td class="style17">
                        </td>
                        <td style="text-align: left;" class="style21">
                            <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Small"
                                Text="Registerted :" Width="149px"></asp:Label></td>
                        <td class="style18">
                        </td>
                        <td class="style1" colspan="2">
                        </td>
                        <td style="height: 21px;" colspan="2">
                        </td>
                        <td style="width: 100px; height: 21px;">
                        </td>
                        <td style="width: 77px; height: 21px;">
                        </td>
                    </tr>
                    <tr>
                        <td class="style17">
                        </td>
                        <td style="text-align: right" class="style21">
                            <asp:Label ID="Label11" runat="server" Text="Registration No. : " Font-Size="Small"></asp:Label></td>
                        <td class="style18">
                        </td>
                        <td class="style1" colspan="2">
                            <asp:TextBox ID="PRegNo" runat="server" Width="76px" Font-Size="Small"></asp:TextBox></td>
                        <td style="height: 21px" colspan="2">
                        </td>
                        <td style="width: 100px; height: 21px">
                            <asp:Button ID="PSubmit" runat="server" style="margin-bottom: 0px" 
                                Text="Submit" />
                        </td>
                        <td style="width: 77px; height: 21px">&nbsp;
                      </td>
                    </tr>
                    <tr>
                        <td class="style15">
                        </td>
                        <td style="text-align: right;" align="right" class="style23">
                            <asp:Label ID="Label12" runat="server" Text="First Name :" Font-Size="Small"></asp:Label></td>

                        <td colspan="3">
                            <asp:TextBox ID="PNam" runat="server" Width="180px" Font-Size="Small"></asp:TextBox></td>
                        <td align="right" class="style33">
                            <asp:Label ID="Label16" runat="server" Font-Size="Small" Text="Last Name :"></asp:Label>
                        </td>
                        <td class="style32">
                            <asp:TextBox ID="LPNam" runat="server" Font-Size="Small"></asp:TextBox>
                        </td>
                        <td style="width: 77px">
                            <asp:Button ID="PClear" runat="server" Text="Clear" />
                        </td>
                    </tr>
                </table>
            
            </asp:View>
        </asp:MultiView>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            Font-Bold="True" RepeatDirection="Horizontal" Font-Size="Small" Visible="False">
            <asp:ListItem Value="1">Provisional</asp:ListItem>
            <asp:ListItem Selected="True" Value="0">Registration</asp:ListItem>
        </asp:RadioButtonList><br />
        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="RegMasterId" Width="695px" Font-Size="Small" PageSize="100">
        
            <Columns>
                <asp:TemplateField HeaderText="Reg. No.">
                    <ItemStyle Width="60px" />
                        <ItemTemplate> 
                            <asp:Label ID="RegNo" Runat="Server" Text='<%# Eval("RegNo") %>' />
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Reg. Date">
                    <ItemStyle Width="60px" />
                        <ItemTemplate> 
                            <asp:Label ID="RegDate" Runat="Server" Text='<%# Eval("RegDate","{0:d}")  %>' />
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemStyle Width="200px" />
                        <ItemTemplate> 
                            <asp:Label ID="RName" Runat="Server" Text='<%# Eval("RName") %>' />
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Address">
                    <ItemStyle Width="300px" />
                        <ItemTemplate> 
                            <asp:Label ID="RPAdd" Runat="Server" Text='<%# Eval("PresentAddress") %>' />
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Application Date">
                    <ItemStyle Width="60px" />
                        <ItemTemplate> 
                            <asp:Label ID="AppDt" Runat="Server" Text='<%# Eval("ApplicationDate","{0:d}") %>' />
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" EditText="Current Status" >
                    <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:CommandField>
            </Columns>
            <HeaderStyle BackColor="#006600" ForeColor="#CCFFCC" />
        </asp:GridView>

        <asp:GridView ID="pgv" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="RegMasterId" Width="869px" Font-Size="Small">
        
            <Columns>
                <asp:TemplateField HeaderText="Prov. No.">
                    <ItemStyle Width="60px" />
                        <ItemTemplate> 
                            <asp:Label ID="PRegNo" Runat="Server" Text='<%# Eval("ProvRegNo") %>' />
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Prov. Date">
                    <ItemStyle Width="60px" />
                        <ItemTemplate> 
                            <asp:Label ID="PRegDate" Runat="Server" Text='<%# Eval("ProvRegDate","{0:d}")  %>' />
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemStyle Width="200px" />
                        <ItemTemplate> 
                            <asp:Label ID="PRName" Runat="Server" Text='<%# Eval("RName") %>' />
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Address">
                    <ItemStyle Width="300px" />
                        <ItemTemplate> 
                            <asp:Label ID="PRPAdd" Runat="Server" Text='<%# Eval("PresentAddress") %>' />
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Application Date">
                    <ItemStyle Width="60px" />
                        <ItemTemplate> 
                            <asp:Label ID="PAppDt" Runat="Server" Text='<%# Eval("ApplicationDate","{0:d}") %>' />
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Recpt.No.">
                    <ItemStyle Width="30px" />
                        <ItemTemplate> 
                            <asp:Label ID="PRecNo" Runat="Server" Text='<%# Eval("AppFeeRtNo") %>' />
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Recpt. Date">
                    <ItemStyle Width="60px" />
                        <ItemTemplate> 
                            <asp:Label ID="PRecDt" Runat="Server" Text='<%# Eval("AppFeeRtDate","{0:d}") %>' />
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Valid Upto">
                    <ItemStyle Width="60px" />
                        <ItemTemplate> 
                            <asp:Label ID="PValDt" Runat="Server" Text='<%# Eval("ValidityDate","{0:d}") %>' />
                        </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <HeaderStyle BackColor="#006600" ForeColor="#CCFFCC" />
        </asp:GridView>


    </form>
</body>
</html>
