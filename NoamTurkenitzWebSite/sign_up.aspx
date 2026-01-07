<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sign_up.aspx.cs" Inherits="sign_up" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form>
        <h2>sign up form</h2>

        enter your  name<input type="text" name="fullname-2" id="fullname-2" placeholder="enter your full name  ">
        <br />
        types of music you like to listen to 
        <br />
        rock<input type="checkbox" name="check-1"  value="המבורגר" id="check_1"><br />
     rap <input type="checkbox" name="check-1" checked value="המבורגר" id="check_2"><br />
        jazz <input type="checkbox" name="check-1" checked value="המבורגר" id="check_3"><br />
        pop <input type="checkbox" name="check-2" checked value="המבורגר" id="check_1"><br />
      eastern(מוזיקה מזרחית)   <input type="checkbox" name="check-2" checked value="המבורגר" id="check_1"><br />
        המבורגר <input type="checkbox" name="check-2" checked value="המבורגר" id="check_1"><br />
        המבורגר <input type="checkbox" name="check-2" checked value="המבורגר" id="check_1"><br />
        המבורגר <input type="checkbox" name="check-2" checked value="המבורגר" id="check_1"><br />
    </form>
</asp:Content>

