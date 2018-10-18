using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormWebApp
{
    public partial class IndexUI : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            ViewState["myName"] = nameTextBox.Text;
            nameTextBox.Text = String.Empty;
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = ViewState["myName"].ToString();
        }
    }
}