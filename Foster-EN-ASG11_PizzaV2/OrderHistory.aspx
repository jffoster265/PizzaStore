<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrderHistory.aspx.cs" Inherits="Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
<%--    <asp:Repeater ID="repeaterOrderHistory" runat="server">
        <ItemTemplate>
            <table>
                <tr>
                    <td><asp:Label ID="lblOrderID" runat="server" Text='<%#Eval("OrderID").ToString()  %>'/></td>
                    <td><asp:Label ID="lblName" runat="server" Text='<%#Eval("FirstName").ToString()  %>' /></td>
                    <td><asp:Label ID="lblDate" runat="server" Text='<%#Eval("OrderDate").ToString()  %>' /></td>
                    <td><asp:Label ID="lblProductName" runat="server" Text='<%#Eval("ProductName").ToString()  %>' /></td>
                    <td><asp:Label ID="lblItemPrice" runat="server" Text='<%#Eval("OrderID").ToString()  %>' /></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:Repeater>
    <p>
    </p>--%>
    <div class="content">
     <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    </div>

</asp:Content>

