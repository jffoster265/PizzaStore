<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
 
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <div class="content">
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblPizza1" runat="server" Text="Order your first Pizza"></asp:Label>
            <asp:DropDownList ID="DropDownListPizza1" runat="server">
            </asp:DropDownList><br /><br />
             <asp:Label ID="lblPizza2" runat="server" Text="Order your second pizza"></asp:Label>
            <asp:DropDownList ID="DropDownListPizza2" runat="server">
            </asp:DropDownList><br /><br />
            <asp:Label ID="lblPizza3" runat="server" Text="Order your third pizza"></asp:Label>
            <asp:DropDownList ID="DropDownListPizza3" runat="server">
            </asp:DropDownList><br /><br />
   
            <asp:Button ID="btnSubmitOrder" runat="server" OnClick="btnSubmitOrder_Click" Text="Place Order" />
    </div>    
</asp:Content>

