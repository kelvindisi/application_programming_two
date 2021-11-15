using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    public partial class StudentRegistrationSystem : Form
    {
        public StudentRegistrationSystem()
        {
            InitializeComponent();
        }

        private void StudentRegistrationSystem_Load(object sender, EventArgs e)
        {
            rdoFullTime.Checked = true;
            // To populate county data
            //Nairobi, Mombasa and Kiambu counties
            string[] counties = new string[] { "Nairobi", "Mombasa", "Kiambu" };

            cboCounty.Items.AddRange(counties);
            // handle mode of study selection mode
            rdoFullTime.Click += HandleModeSelection_Click;
            rdoPartTime.Click += HandleModeSelection_Click;
            
        }

        private void HandleModeSelection_Click(object sender, EventArgs e)
        {
            if (rdoFullTime.Checked)
                rdoPartTime.Checked = false;
            if (rdoPartTime.Checked)
                rdoFullTime.Checked = false;
        }

        private void cboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string county = cboCounty.SelectedItem.ToString();
            // To populate sub county
            //Juja, Thika and Ruiru once Kiambu County is selected
            if (county == "Kiambu")
                cboSubCounty.Items.AddRange(new string[] { "Juja", "Thika", "Ruiru" });
            else
                cboSubCounty.Items.Clear();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            string surname = txtSurname.Text;
            string other = txtOtherNames.Text;
            string county = cboCounty.SelectedItem.ToString();
            string subCounty = cboSubCounty.SelectedItem.ToString();
            string modeOfStudy = "";
            if (rdoFullTime.Checked == true)
            {
                modeOfStudy = "Full time";
            }else
            {
                modeOfStudy = "Part time";
            }
            StringBuilder sports = new StringBuilder();
            
            if (cboxBasketBall.Checked)
                sports.Append("Basket Ball|");
            if (cboxHockey.Checked)
                sports.Append("Hockey|");
            if (cboxSoccer.Checked)
                sports.Append("Soccer|");



            lstResults.Items.Add("Surname " + surname);
            lstResults.Items.Add("Other Names " + other);
            lstResults.Items.Add("County " + county);
            lstResults.Items.Add("Sub County " + subCounty);
            lstResults.Items.Add("Mode of Study " + modeOfStudy);
            lstResults.Items.Add("Sports: " + sports);
        }
    }
}
