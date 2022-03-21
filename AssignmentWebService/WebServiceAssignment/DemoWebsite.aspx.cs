using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceAssignment
{
    public partial class DemoWebsite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonViewPopulationInformation_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = $"The total population in PinCode {TextBoxPinCode.Text} is 5,343,324";
            LabelThanksMessage.Text = "Thank you for your interest in our population services.";
        }
    }
}