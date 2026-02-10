<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="log_in.aspx.cs" Inherits="log_in" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 
    <form runat="server" method="post">
    <h2>log in</h2>
        <br />
          enter your  Email<input type="text" name="Email" id="email" placeholder="enter your Email ">
  <br />
  enter your  password<input type="text" name="Password" id="password" placeholder="enter your password  ">
        <br />
                <input id="Submit1" type="submit" value="שלח" />
        <%=st %>
        </form>
</asp:Content>

