<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Wizard.aspx.cs" Inherits="Wizard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" Width="537px" Height="242px" OnFinishButtonClick="Wizard1_FinishButtonClick">
            <WizardSteps>
                <asp:WizardStep ID="WizardStep1" runat="server" Title="Quesition 1">
                     <asp:Label ID="Label1" runat="server" Text="Label"><b>What is the Capital of India ?</b></asp:Label><br />
                     <asp:RadioButton ID="R1" runat="server" />Kolkata
                     <asp:RadioButton ID="R2" runat="server" />Delhi<br />
                     <asp:RadioButton ID="R3" runat="server" />Mumbai
                     <asp:RadioButton ID="R4" runat="server" />Kochi
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep2" runat="server" Title="Quesition 2">
                    <asp:Label ID="Label2" runat="server" Text="Label"><b>Who is the current Captain of Indian Cricket Team ?</b></asp:Label><br />
                     <asp:RadioButton ID="R5" runat="server" />Sachin Tendulkar
                     <asp:RadioButton ID="R6" runat="server" />Rahul Dravid<br />
                     <asp:RadioButton ID="R7" runat="server" />Umesh Yadav
                     <asp:RadioButton ID="R8" runat="server" />M.S. Dhoni
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </form>
    <asp:Literal ID="L1" runat="server"></asp:Literal>
</body>
</html>
