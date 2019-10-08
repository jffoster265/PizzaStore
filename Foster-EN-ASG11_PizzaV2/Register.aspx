<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Default5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="main" runat="server">

    <div class="content">
    
        <p>If your already registered please <a href="Login.aspx">login.</a></p>

        <asp:Label ID="lblMessage" runat="server" Text="All fields are required" ForeColor="Red"></asp:Label><br />

        <asp:Label ID="lblFirstName" class="lblRegister" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="Please enter your First Name." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblLastName"  class="lblRegister" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="Please enter your Last Name." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblEmail" class="lblRegister" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Please enter your Email Address" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblAddress" class="lblRegister" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAddress" Display="Dynamic" ErrorMessage="Please enter your street address" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblCity" class="lblRegister" runat="server" Text="City"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCity" Display="Dynamic" ErrorMessage="Please enter your City." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblState" class="lblRegister" runat="server" Text="State"></asp:Label>
        <asp:TextBox ID="txtState" runat="server" MaxLength="2"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtState" Display="Dynamic" ErrorMessage="Please enter your state" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblZip" class="lblRegister" runat="server" Text="Zip Code    "></asp:Label>
        <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtZip" Display="Dynamic" ErrorMessage="Please enter your Zip Code" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblUsername" class="lblRegister" runat="server" Text="Username      "></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtUsername" Display="Dynamic" ErrorMessage="Please enter a Username." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblPassword" class="lblRegister" runat="server" Text="Password       "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Please choose a Password." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblConfirmPassword" class="lblRegister" runat="server" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Please re-enter your password" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" Display="Dynamic" ErrorMessage="Passwords must match" ForeColor="Red"></asp:CompareValidator>
        <br />

        <asp:Button ID="btnSubmit" runat="server" OnClick="processRegistration" Text="Submit" Width="180px" />

</div>  
   
</asp:Content>


