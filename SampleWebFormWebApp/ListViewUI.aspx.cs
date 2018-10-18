using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormWebApp
{
    public partial class ListViewUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

            string name = nameTextBox.Text;
            nameTextBox.Text = "";
            if (ViewState["nameListVS"] == null)
            {
                List<string> nameList = new List<string>();
                nameList.Add(name);
                ViewState["nameListVS"] = nameList;
            }
            else
            {
                List<string> nameList1 =(List<string>)ViewState["nameListVS"];
                nameList1.Add(name);
                ViewState["nameListVS"] = nameList1;
            }
                                   
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            List<string> nameList1 = (List<string>)ViewState["nameListVS"];
            nameListBox.Items.Clear();
            foreach (string name in nameList1)
            {
                nameListBox.Items.Add(name);                
            }
        }
    }
}