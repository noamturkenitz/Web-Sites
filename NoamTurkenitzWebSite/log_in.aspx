<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="log_in.aspx.cs" Inherits="log_in" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>
        function checkLogin() {
            emailErr.innerHTML = "";
            passErr.innerHTML = "";

            var result = true;

            var email = document.getElementById("email").value;
            var pass = document.getElementById("password").value;

            if (email == "" || email.indexOf("@") == -1 || email.indexOf(".") == -1) {
                emailErr.innerHTML = "invalid email";
                result = false;
            }

            pass = pass.trim();

            if (pass == "") {
                passErr.innerHTML = "enter password";
                result = false;
            }
            else if (pass.length < 6) {
                passErr.innerHTML = "password must be at least 6 characters";
                result = false;
            }

            return result;
        }
        function showPass() {
            var p = document.getElementById("password");

            if (p.type == "password")
                p.type = "text";
            else
                p.type = "password";
        }
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 
<form runat="server" method="post" onsubmit="return checkLogin();">
    <h2>log in</h2>
    <br />
          enter your  Email<input type="text" name="Email" id="email" placeholder="enter your Email ">
    <span id="emailErr"></span>

  <br />
  enter your  password<input type="password" name="Password" id="password" placeholder="enter your password">
    <span id="passErr"></span>

        <br />
        <input type="checkbox" onclick="showPass()"> Show Password
        <br />
                <input id="Submit1" type="submit" value="שלח" />
        <%=st %>
        </form>
</asp:Content>

