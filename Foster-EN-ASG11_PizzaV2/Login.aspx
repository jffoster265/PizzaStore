<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
  <div class="contentLogin">
    <asp:Label ID="lblLoginStatus" runat="server" Text="Please enter your username and password "></asp:Label><br />
  
    <asp:Label ID="lblUserName" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="txtUserName" runat="server">admin@test.com</asp:TextBox><br />
    <asp:Label ID="lblPassword" runat="server" Text="Password">Password</asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password">testpass</asp:TextBox><br />
    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Log In" />
 </div>
</asp:Content>
