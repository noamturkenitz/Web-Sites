using System;

public partial class sign_up : System.Web.UI.Page
{
    public string strRes = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            string fullname = Request.Form["fullname-2"];
            string email = Request.Form["Email"];
            string password = Request.Form["password"];
            string type = Request.Form["check-1"];
            string connection = Request.Form["radio-2"];
            string recommend = Request.Form["textarea3"];
            string age = Request.Form["age"];

            string sqlcheck = "Select * from tUsers where Email=N'" + email +    "'";

            bool isExist = MyAdoHelper.IsExist(sqlcheck);
            if (isExist)
            {
                strRes = "mail is already occupied";
            }
            else { 
                string sqlinsert = "INSERT INTO tUsers values ("
                       + "N'" + fullname + "',"
                       + "N'" + email + "',"
                       + "N'" + password + "',"
                       + "N'" + type + "',"
                       + "N'" + connection + "',"
                       + "N'" + recommend + "',"
                       + age
                       + ")";

                MyAdoHelper.DoQuery( sqlinsert);
                Response.Redirect("log_in.aspx");
            }
           
        }
    }
}