<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="COMPANY REGISTER.aspx.cs" Inherits="JOBPORTALPROJECTDOWNLOADED.COMPANY_REGISTER" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <script type="text/javascript">
        function alertMessage()
        {
            alert("Thankyou for Registering With Us...You Can Now Post Jobs By Loging in")
        }


      </script>


     <style type="text/css">
    .auto-style1 {
        width: 88%;
        margin-right: 0px;
    }
    .auto-style2 {
        color: #9999FF;
    }
    .auto-style3 {
        font-weight: bold;
    }
        .auto-style4 {
            width: 151px;
        }
         .auto-style5 {
             height: 47px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
    &nbsp;&nbsp;&nbsp;<table class="auto-style1" align="center">
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="auto-style2"><strong>REGISTERATION</strong></span></td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td colspan="2">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4" rowspan="5">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/img/companyregiser.png" />
        </td>
        <td>REG NO</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Enter First Name"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>COMPANY ADDRESS</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please Enter Last Name"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>PH NO</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please Enter Username"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">EMAIL</td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please Provide Password"></asp:RequiredFieldValidator>
        &nbsp;</td>
    </tr>
    <tr>
        <td>HR HEAD NAME</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox5" ErrorMessage="Please Provide HR Name"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td>HR NUMBER</td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox6" ErrorMessage="Please Provide HR Number"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td>PASSWORD</td>
        <td>
            <asp:TextBox ID="TextBox7" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox7" ErrorMessage="Please Provide Password"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td>CONFIRM PASSWORD</td>
        <td>
            <asp:TextBox ID="TextBox8" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="TextBox7" ControlToValidate="TextBox8" ErrorMessage="Password Should Be same"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td><strong>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style3" Text="REGISTER" OnClick="Button1_Click" />
            &nbsp;&nbsp;
            </strong></td>
        <td>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>
</table>
        </div>
</asp:Content>
