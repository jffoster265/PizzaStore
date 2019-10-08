<%@ Page Language="C#"  MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditUser.aspx.cs" Inherits="EditUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="main" runat="server">
    <div class="content">
        
        
        <asp:Label ID="Label3" runat="server" Text=" First Name:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label4" runat="server" Text="Last Name:"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Role"></asp:Label>
        <asp:DropDownList ID="ddListRoles" runat="server">
             <asp:ListItem Text="End User" Value="1"></asp:ListItem>
             <asp:ListItem Text="Admin" Value="2"></asp:ListItem>
        </asp:DropDownList><br />
        <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label5" runat="server" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label6" runat="server" Text="City:"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label9" runat="server" Text="State:"></asp:Label>
        <asp:TextBox ID="txtState" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label8" runat="server" Text="Zip:"></asp:Label>
        <asp:TextBox ID="txtZip" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label7" runat="server" Text="isActive"></asp:Label>
        <asp:DropDownList ID="ddListIsActive" runat="server">
             <asp:ListItem Text="Active" Value="1"></asp:ListItem>
             <asp:ListItem Text="Deleted" Value="2"></asp:ListItem>
        </asp:DropDownList><br />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <br />
        
    </div>
</asp:Content>
