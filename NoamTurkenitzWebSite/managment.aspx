<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="managment.aspx.cs" Inherits="managment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>User Management</h2>
  
    <center>
        <h1>Search with two criteria</h1>

        <form name="managerForm" method="post" runat="server">
            name
            <input name="fun1" id="fun1" type="text" />
            <br />
            email
            <input name="email" id="email" type="text" />
            <br />
            <input id="Submit1" type="submit" value="submit" />
            <br />
            <input type="submit" name="reset" value="Reset" />
        </form>

        <%= st %>
        <br />
    </center>
</asp:Content>

