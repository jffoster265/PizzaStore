<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



<asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="main" runat="server">
    <div class="content">
        <p> Admin page</p>
         <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br />
        <a href="ListOfUsers.aspx">Get all users</a>
    </div>
</asp:Content>
