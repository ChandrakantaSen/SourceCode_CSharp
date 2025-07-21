<%@ Page Language="VB" AutoEventWireup="false" CodeFile="details.aspx.vb" Inherits="details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style7
        {
            width: 100px;
            text-align: right;
        }
        .style8
        {
            width: 113px;
        }
        .style9
        {
        }
        .style12
        {
            width: 520px;
        }
        .style14
        {
            width: 54px;
        }
        .style17
        {
            width: 111px;
        }
        .style18
        {
            width: 84px;
        }
        .style19
        {
            width: 9px;
        }
        .style20
        {
            width: 53px;
        }
        .style21
        {
            width: 177px;
            text-align: right;
        }
        .style23
        {
            width: 158px;
        }
        .style28
        {
            width: 91px;
            text-align: right;
        }
        .style29
        {
            width: 196px;
        }
        .style31
        {
            width: 24px;
        }
        .style32
        {
            width: 233px;
        }
        .style33
        {
            width: 28px;
        }
        .style38
        {
            width: 262px;
        }
        .style39
        {
            width: 92px;
            text-align: right;
        }
        .style40
        {
            width: 197px;
        }
        .style42
        {
            width: 338px;
        }
        .style43
        {
            width: 30px;
            text-align: right;
        }
        .style44
        {
            width: 55px;
        }
        .style48
        {
            width: 30px;
        }
        .style49
        {
            width: 29px;
        }
        .style50
        {
            width: 18px;
        }
        .style51
        {
            width: 149px;
        }
        .style52
        {
            width: 111px;
            text-align: right;
        }
        .style53
        {
            width: 108px;
            text-align: right;
        }
    </style>
</head>
<body bgcolor="e6f6d2">
    <form id="form1"  method="post" runat="server">

   <div>
       <table style="width:634px">
        <tr>
        <td style="text-align:right; font-size: medium; text-decoration: underline blink; font-family: 'Times New Roman', Times, serif; font-weight: bold; color: #FF0000;" >
                            Any Error / omission in data is regretted.                             Please contact WBMC for correction, if any </td>
                        
                        </td>
        </tr>
    </table>
        <table class="style1">
        
            <tr>
                <td class="style28">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Reg. No. : "></asp:Label>
                </td>
                <td class="style8">
                    <asp:TextBox ID="txtNo" runat="server" EnableTheming="True" ReadOnly="True" 
                        Width="68px" BackColor="#E6F6D2" BorderWidth="0px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Reg Date : "></asp:Label>
                </td>
                <td class="style44">
                    <asp:TextBox ID="txtDate" runat="server" Width="86px" ReadOnly="True" 
                        BackColor="#E6F6D2" BorderWidth="0px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td style="font-family: 'Times New Roman', Times, serif; font-size: small; color: #FF0000; font-weight: bold; text-align: center">
                    &nbsp;</td>
            </tr>
        </table>
            <table class="style1">
            
            <tr>
                <td class="style53">
                    &nbsp;
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Name : "></asp:Label>
                </td>
                <td class="style9">
                    <asp:TextBox ID="txtName" runat="server" Width="365px" ReadOnly="True" 
                        BackColor="#E6F6D2" BorderWidth="0px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table class="style1">
            <tr>
                <td class="style52">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Father's Name : "></asp:Label>
                </td>
                <td class="style12">
                    <asp:TextBox ID="txtFather" runat="server" Width="364px" ReadOnly="True" 
                        BackColor="#E6F6D2" BorderWidth="0px"></asp:TextBox>
                </td>
                <td class="style51">
                    <asp:TextBox ID="txtUpdtRem" runat="server" BackColor="#FFFF66" 
                        BorderStyle="Groove" ForeColor="#663300" Font-Bold="True" 
                        Font-Size="Medium"  ReadOnly="True" BorderWidth="3px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>        
        <table class="style1">
            <tr>
                <td class="style39">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Sex : "></asp:Label>
                </td>
                <td class="style14">
                    <asp:TextBox ID="txtSex" runat="server" Width="51px" ReadOnly="True" 
                        BackColor="#E6F6D2" BorderWidth="0px"></asp:TextBox>
                </td>
                <td class="style20">
                    &nbsp;</td>
                <td class="style18" style="text-align: right">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Date of Birth : "></asp:Label>
                </td>
                <td class="style17">
                    <asp:TextBox ID="txtDOB" runat="server" Width="107px" ReadOnly="True" 
                        BackColor="#E6F6D2" BorderWidth="0px"></asp:TextBox>
                </td>
                <td class="style19">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <table class="style1">
            <tr>
                <td class="style21">
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Permanent Address : "></asp:Label>
                </td>
                <td class="style40">
                    &nbsp;</td>
                <td class="style23">
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Present Address : "></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>    
       <table class="style1">
            <tr>
                <td class="style49">
                    &nbsp;</td>
                <td class="style42">
                    <asp:TextBox ID="txtPermanent" runat="server" Height="70px" Width="337px" 
                        ReadOnly="True" TextMode="MultiLine" BackColor="#E6F6D2" BorderWidth="0px"></asp:TextBox>
                </td>
                <td class="style50">
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="txtPresent" runat="server" Height="70px" Width="337px" 
                        ReadOnly="True" TextMode="MultiLine" BackColor="#E6F6D2" BorderWidth="0px"></asp:TextBox>
                </td>
            </tr>
        </table>        
       <table class="style1">
            <tr>
                <td class="style28">
                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Contact Details : "></asp:Label>
                </td>
                <td rowspan="2" class="style32">
                    <asp:TextBox ID="txtContact" runat="server" Height="52px" Width="228px" 
                        ReadOnly="True" TextMode="MultiLine" BackColor="#E6F6D2" BorderWidth="0px"></asp:TextBox>
                </td>
                <td rowspan="2" class="style38">
                    &nbsp;</td>
                <td rowspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style28">
                    &nbsp;</td>
            </tr>
        </table>        

 
 
       <table class="style1">
            <tr>
                <td class="style29">
                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Qualification And Specialisation : "></asp:Label>
&nbsp;:</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
      <table class="style1">
            <tr>
                <td class="style33">
                    &nbsp;</td>
                <td >
                    <asp:GridView ID="gvQuali" runat="server" AutoGenerateColumns="False" 
                        Font-Size="Small">
                        <Columns>
                            <asp:TemplateField HeaderText="University">
                                <ItemStyle Width="200px" />
                                    <ItemTemplate> 
                                        <asp:Label ID="Uni" Runat="Server" Text='<%# Eval("University") %>' />
                                    </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Institute">
                                <ItemStyle Width="200px" />
                                    <ItemTemplate> 
                                        <asp:Label ID="Ins" Runat="Server" Text='<%# Eval("Institute") %>' />
                                    </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Qualification">
                                <ItemStyle Width="200px" />
                                    <ItemTemplate> 
                                        <asp:Label ID="Qua" Runat="Server" Text='<%# Eval("Quali")  %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Year Passed">
                                <ItemStyle Width="70px" />
                                    <ItemTemplate> 
                                        <asp:Label ID="Yer" Runat="Server" Text='<%# Eval("QYear") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Specialisation">
                                <ItemStyle Width="100px" />
                                    <ItemTemplate> 
                                        <asp:Label ID="Spe" Runat="Server" Text='<%# Eval("Spec") %>' />
                                    </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <HeaderStyle BackColor="#006600" ForeColor="#CCFFCC" />
                    </asp:GridView>
                </td>

            </tr>
        </table>                     
        
       <table class="style1">
            <tr>
                <td>
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Changed Data (If Any) : "></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>    
        <table class ="style1"">
            <tr>
            <td class="style31">
                &nbsp;</td>
            <td>
                                                                  
        <asp:GridView ID="gvChange" runat="server" AutoGenerateColumns="False" 
                    Font-Size="Small">
            <Columns>
                            <asp:TemplateField HeaderText="Changed Item">
                                <ItemStyle Width="150px" />
                                    <ItemTemplate> 
                                        <asp:Label ID="Changed" Runat="Server" Text='<%# Eval("ItemChanged") %>' />
                                    </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Date">
                                <ItemStyle Width="75px" />
                                    <ItemTemplate> 
                                        <asp:Label ID="ChangedOn" Runat="Server" Text='<%# Eval("DateofChange","{0:d}")  %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Old Item">
                                <ItemStyle Width="350px" />
                                    <ItemTemplate> 
                                        <asp:Label ID="Before" Runat="Server" Text='<%# Eval("ItemOld") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="New Item">
                                <ItemStyle Width="350px" />
                                    <ItemTemplate> 
                                        <asp:Label ID="After" Runat="Server" Text='<%# Eval("ItemNew") %>' />
                                    </ItemTemplate>
                            </asp:TemplateField>
            </Columns>
            <HeaderStyle BackColor="#006600" ForeColor="#CCFFCC" />
        </asp:GridView>
            </td>
            </tr>
        </table> 
       <table class="style1">
            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="WBMC Remarks (If Any) :  "></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>    
       <table class="style1">
            <tr>
            <td class="style48">
                    &nbsp;</td>
                <td rowspan="2" class="style32">
                    <asp:GridView ID="gvRemark" runat="server" AutoGenerateColumns="False" 
                        Font-Size="Small" Width="657px">
                        <Columns>
                            <asp:TemplateField HeaderText="Date">
                                <ItemStyle Width="75px" />
                                <ItemTemplate> 
                                        <asp:Label ID="ActDate" Runat="Server" Text='<%# Eval("AcDate","{0:d}")  %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action taken by WBMC">
                                <ItemStyle Width="350px" />
                                <ItemStyle Width="300px" />
                                    <ItemTemplate> 
                                        <asp:Label ID="ActTaken" Runat="Server" Text='<%# Eval("Action") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <HeaderStyle BackColor="#006600" ForeColor="#CCFFCC" />
                    </asp:GridView>
                </td>
                <td rowspan="2" class="style38">
                    &nbsp;</td>
                <td rowspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style43">
                    &nbsp;</td>
            </tr>
        </table>               
    </div>
    </form>
</body>
</html>
