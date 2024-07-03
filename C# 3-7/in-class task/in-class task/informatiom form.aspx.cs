using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace in_class_task
{

    public partial class informatiom_form : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GenderRadio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> selectedCourses = new List<string>();
            foreach (ListItem Item in CoursesCheckBox.Items)
            {
                if (Item.Selected)
                {
                    selectedCourses.Add(Item.Value);
                }
            }

            string inputName = NameBox.Text;
            string inputEmail = EmailBox.Text;
            string inputId = IdBox.Text;
            string inputGender = GenderRadioBox.SelectedItem.Value.ToString();
            string inputCourses = string.Join(",", selectedCourses);
            string inputMessage = MessageBox.Text;

            NameOutput.Text = inputName;
            EmailOutput.Text = inputEmail;
            IdOutput.Text = inputId;
            GenderOutput.Text = inputGender;
            CoursesOutput.Text = inputCourses;
            MessageOutput.Text = inputMessage;

            output.Visible = true;

        }
    }
}