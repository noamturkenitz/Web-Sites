    <%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Form.aspx.cs" Inherits="Form" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <h1>my form</h1>
        <form runat="server" method="post">
            שם מלא: <input type="text" name="fullname" id="fullname" placeholder="enter your full name  ">
            <br />
        :מאכלים אהובים
            <br />
            המבורגר <input type="checkbox" name="check-1" checked value="המבורגר" id="check_1"><br />
            פיצה <input type="checkbox" name="check-2" checked value="פיצה" id="check_2"><br />
            סושי <input type="checkbox" name="check-3" value="סושי"  id="check_3"><br />
            שניצל <input type="checkbox" name="check-4" value="שניצל" id="check_4"> <br />  
            פסטה <input type="checkbox" name="check-5" value="פסטה" id="check_5">

             <br />
           :צבע אהוב
            <br />
           שחור <input type="radio" name="radio-1"  value="שחור" id="radio_1"><br />
         לבן   <input type="radio" name="radio-2" value="לבן" id="radio_2"><br />
         אדום <input type="radio" name="radio-3" value="אדום"  id="radio_3"><br />
          כחול  <input type="radio" name="radio-4" checked value="כחול" id="radio_4"><br />
          ירוק  <input type="radio" name="radio-5" value="ירוק" id="radio_5"><br />
          צהוב  <input type="radio" name="radio-6" value="צהוב" id="radio_6"><br />
          סגול  <input type="radio" name="radio-7" value="סגול" id="radio_7"><br />
          תכלת  <input type="radio" name="radio-8" value="תכלת" id="radio_8"><br />
        :שאלות/בקשות/המלצות
            <textarea rows="10" cols="20" name="textarea1" id="textarea1" placeholder="הכנס מלל חופשי"></textarea>
            <br />
            <select name="age" id="age">
                <option value="0">תבחר את הגיל שלך</option>
                <option value="13">13</option>
                <option value="14">14</option>
                <option value="15">15</option>
                <option value="16">16</option>
                <option value="17">17</option>
                <option value="18">18</option>
            </select>
            <br />
            <input id="Submit1" type="submit" value="שלח" />
            </form>
    </asp:Content>


