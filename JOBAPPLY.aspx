<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="JOBAPPLY.aspx.cs" Inherits="JOBPORTALPROJECTDOWNLOADED.JOBAPPLY" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
        function alertMessage()
        {
            alert("Thankyou For Applying For The Post. Our HR Will Contact You Soon....")
        }





    </script>
    <style type="text/css">
        .auto-style1 {
            margin-left: 80px;
        height: 38px;
        width: 589px;
    }
        .auto-style2 {
            font-size: 12pt;
            width: 228px;
        }
    .auto-style3 {
        font-weight: bold;
        background-color: #00FF00;
    }
    .auto-style4 {
        color: #66FF66;
    }
    .auto-style5 {
        height: 38px;
    }
    .auto-style6 {
        height: 94px;
    }
    .auto-style7 {
            width: 589px;
        }
    .auto-style8 {
        height: 94px;
        width: 589px;
    }
        .auto-style9 {
            color: #FF3300;
        }
        .auto-style10 {
            background-color: #fff;
            color: #FF3300;
        }
        .auto-style11 {
            height: 38px;
            width: 228px;
        }
        .auto-style12 {
            width: 228px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="text-center" colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <h1><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; JOB APPLICATION FORM</strong></h1>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="3">
                <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Font-Bold="True" Font-Size="Large"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">NAME</td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="please provide name" CssClass="auto-style9"></asp:RequiredFieldValidator>
&nbsp;&nbsp; 
                </td>
            <td class="auto-style11">DATE OF BIRTH</td>
            <td class="auto-style5">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="72px">
                    <asp:ListItem>DD</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="89px">
                    <asp:ListItem>MON</asp:ListItem>
                    <asp:ListItem>JAN</asp:ListItem>
                    <asp:ListItem>FEB</asp:ListItem>
                    <asp:ListItem>MAR</asp:ListItem>
                    <asp:ListItem>APR</asp:ListItem>
                    <asp:ListItem>MAY</asp:ListItem>
                    <asp:ListItem>JUN</asp:ListItem>
                    <asp:ListItem>JUL</asp:ListItem>
                    <asp:ListItem>AUG</asp:ListItem>
                    <asp:ListItem>SEP</asp:ListItem>
                    <asp:ListItem>OCT</asp:ListItem>
                    <asp:ListItem>NOV</asp:ListItem>
                    <asp:ListItem>DEC</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList3" runat="server" Width="97px">
                    <asp:ListItem>YYYY</asp:ListItem>
                </asp:DropDownList>
                &nbsp;</td>
        </tr>
        <tr>
            <td>PHNO</td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please Provide PHNO" CssClass="auto-style9"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style12">TOTAL EXPERIENCE</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Height="44px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please Provide Experience" CssClass="auto-style9"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">EDUCATIONAL QUALIFICATION</td>
            <td class="auto-style8">
                <asp:TextBox ID="TextBox3" runat="server" Height="44px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please Provide Qualification" CssClass="auto-style9"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style12">RESUME</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="FileUpload1" ErrorMessage="Please Upload Resume" CssClass="auto-style10"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Mention your notice period(if any)</td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">POST APPLIED TO </td>
            <td>
                <asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>SELECT POST</asp:ListItem>
                    <asp:ListItem>MARKETING MANAGER</asp:ListItem>
                    <asp:ListItem>SOFTWARE ENGINEER</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            <td class="auto-style12">&nbsp;</td>
            <td><strong>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="APPLY" BorderColor="#FF66FF" BorderStyle="Solid" CssClass="auto-style3" Width="164px" />
                </strong></td>
        </tr>
    </table>
</asp:Content>
