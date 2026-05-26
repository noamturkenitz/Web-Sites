<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sign_up.aspx.cs" Inherits="sign_up" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script language="javascript">
        function checkAll() {
            nameErr.innerHTML = "";
            result = true;
            if (checkName() == false)
                result = false;
                //איפה שיהיה האימייל
            return result;

        }
        function checkName() {
            name = document.getElementById("fullname2").value;
            if (name.length < 2) {
                nameErr.innerHTML = "name must contain at least 2 characters";
                return false;
            }
            return true;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form runat="server" method="post" onsubmit="return checkAll();">
        <h2>sign up form</h2>

        enter your  name<input type="text" name="fullname-2" id="fullname2" placeholder="enter your full name  ">
        <span id="nameErr"></span>
        <br />
        enter your  Email<input type="text" name="Email" id="email" placeholder="enter your Email ">
        <br />
        enter your  password<input type="text" name="password" id="password" placeholder="enter your password  ">

        <br />
        types of music you like to listen to 
        <br />
        rock<input type="checkbox" name="check-1" checked value="rock" id="check_1"><br />
        rap
        <input type="checkbox" name="check-1" checked value="rap" id="check_2"><br />
        jazz
        <input type="checkbox" name="check-1" value="jazz" id="check_3"><br />
        pop
        <input type="checkbox" name="check-1" value="pop" id="check_4"><br />
        eastern(מוזיקה מזרחית)  
        <input type="checkbox" checked name="check-1" value="eastern" id="check_5"><br />
        electronic
        <input type="checkbox" name="check-1" checked value="electronic" id="check_6"><br />
        reggae
        <input type="checkbox" name="check-1" checked value="reggae" id="check_7"><br />
        classical
        <input type="checkbox" name="check-1" value="classical" id="check_8"><br />
        blues
        <input type="checkbox" name="check-1" value="blues" id="check_9"><br />
        disco
        <input type="checkbox" name="check-1" value="disco" id="check_10"><br />
        metal
        <input type="checkbox" name="check-1" value="metal" id="check_11"><br />
        punk
        <input type="checkbox" name="check-1" value="punk" id="check_12"><br />
        <br />

        what is your connection to music?
        <br />
        I play the guitar
        <input type="radio" name="radio-2" value="guitar" id="radio_1"><br />
        I play the piano
        <input type="radio" name="radio-2" value="piano" id="radio_2"><br />
        I play the bass
        <input type="radio" name="radio-2" value="bass" id="radio_3"><br />
        I play the drums
        <input type="radio" name="radio-2" value="drums" id="radio_4"><br />
        I play the violin
        <input type="radio" name="radio-2" value="violin" id="radio_5"><br />
        I play the trumpet
        <input type="radio" name="radio-2" value="trumpet" id="radio_6"><br />
        I play the clarinet
        <input type="radio" name="radio-2" value="clarinet" id="radio_7"><br />
        I play the saxsophone
        <input type="radio" name="radio-2" value="saxsophone" id="radio_8"><br />
        I play the flute
        <input type="radio" name="radio-2" value="flute" id="radio_9"><br />
        I play the banjo
        <input type="radio" name="radio-2" value="banjo" id="radio_10"><br />
        I play the harp
        <input type="radio" name="radio-2" value="harp" id="radio_11"><br />
        I play another instrument
        <input type="radio" name="radio-2" value="other" id="radio_12"><br />
        I am a singer
        <input type="radio" name="radio-2" value="sing" id="radio_13"><br />
        I just like to listen and maybe watch concerts
        <input type="radio" name="radio-2" checked value="watch and listen" id="radio_14"><br />
        <br />

        recommendations for songs and favorite band or singer<textarea rows="10" cols="40" name="textarea3" id="textarea1" placeholder="enter your favorite singer or band or a recomendation for songs "></textarea>
        <br />

        <select name="age" id="age">

            <option value="0">select your age</option>
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
    <%=strRes %>
</asp:Content>

