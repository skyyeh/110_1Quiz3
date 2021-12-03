using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Quiz3
{
    public partial class ch7_3_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string S_Name = "霸道總裁";
            string S_Id "A123456789";
            Session["name"] = S_Name;
            Session["Id"] = S_Id;
            Respomse.Write("Session已註冊，保存資訊有2 <br />");
            Respomse.Write("保存客戶端姓名"+ S_Name+  "<br />");
            Respomse.Write("保存客戶端ID" + S_Id + "<br />");
            Respomse.Write("會議室ID" + Session.SessionID + "<br />");
            Respomse.Write("生命週期" + Session.Timeout.ToString() + "分鐘 <br />");

        }
    }
}