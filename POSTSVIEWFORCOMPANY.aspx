<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="POSTSVIEWFORCOMPANY.aspx.cs" Inherits="JOBPORTALPROJECTDOWNLOADED.POSTSVIEWFORCOMPANY" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField />
            <asp:BoundField />
            <asp:BoundField />
            <asp:BoundField />
            <asp:BoundField />
            <asp:BoundField />
            <asp:BoundField />
            <asp:BoundField />
        </Columns>
    </asp:GridView>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click To See" />
</asp:Content>
