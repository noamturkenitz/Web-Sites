<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="managment.aspx.cs" Inherits="managment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>User Management</h2>
    <br />
  
    <center>
        <h1>search with two things</h1>

        <form name="managerForm" method="post" runat="server">
            name
            <input name="fun1" id="fun1" type="text" />
            <br />
            email
            <input name="email" id="email" type="text" />
            <br />
            <input id="Submit1" type="submit" value="submit" />
            <br />
        </form>

        <%= st %>
        <br />
    </center>
</asp:Content>

