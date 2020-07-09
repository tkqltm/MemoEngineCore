using System;

namespace MemoEngineCore
{
    public partial class FrmHelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnClick_Click(object sender, EventArgs e)
        {
            lblDispaly.Text = txtInput.Text;
            txtInput.Text = String.Empty;
        }
    }
}