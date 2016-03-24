
<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApp1.index" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<div>
<asp:DropDownList ID="ddl" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="height: 22px" AutoPostBack="True"></asp:DropDownList>
<br /><br />
OrderID: <asp:Label ID="lblOrder" runat="server" BackColor="#FF9966"></asp:Label><br />
Customer: <asp:Label ID="lblCustomer" runat="server"></asp:Label><br />
Products: <asp:GridView ID="gvProducts" runat="server"></asp:GridView>

</div>
    
</asp:Content>
