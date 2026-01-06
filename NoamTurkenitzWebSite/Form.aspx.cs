using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Form : System.Web.UI.Page
{
    public string name;
    public string age;
    public string color;
    public string food;
    public string requests;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack) {
            name="name:"+ Request.Form["fullname"];
            age = "age:" + Request.Form["age"];   
            color = "favorite color:" + Request.Form["radio-1"];
            requests = "requests/suggestions/questions:" + Request.Form["textarea1"];
            food = "favorite food:" + Request.Form["check-2"];



        }
    }
}