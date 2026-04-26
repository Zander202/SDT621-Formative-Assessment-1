using System;
using System.Windows.Forms;

namespace HomeAffairsProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ✅ Always load from resources (reliable)
            picCoatOfArms.Image = Properties.Resources.coat_of_arms_of_south_africa_seeklogo;
            picCoatOfArms.SizeMode = PictureBoxSizeMode.Zoom;
            picCoatOfArms.BringToFront();
        }

        // Validate ID button
        private void btnValidate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string id = txtID.Text.Trim();
            string citizenship = cmbCitizenship.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(citizenship))
            {
                lblResult.Text = "Please fill in all fields and select citizenship.";
                return;
            }

            CitizenProfile profile = new CitizenProfile(name, id, citizenship);
            lblResult.Text = profile.ValidateID();
        }

        // Generate Profile button
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string id = txtID.Text.Trim();
            string citizenship = cmbCitizenship.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(citizenship))
            {
                txtSummary.Text = "Please fill in all fields before generating a profile.";
                return;
            }

            CitizenProfile profile = new CitizenProfile(name, id, citizenship);
            string validation = profile.ValidateID();
            string timestamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            txtSummary.Text =
                $"==== DIGITAL CITIZEN SUMMARY ===={Environment.NewLine}" +
                $"Name: {profile.FullName}{Environment.NewLine}" +
                $"ID Number: {profile.IDNumber}{Environment.NewLine}" +
                $"Age: {profile.Age}{Environment.NewLine}" +
                $"Citizenship: {profile.CitizenshipStatus}{Environment.NewLine}" +
                $"Validation: {validation}{Environment.NewLine}" +
                $"Processed at: Home Affairs Digital Desk{Environment.NewLine}" +
                $"Timestamp: {timestamp}";
        }

        private void picCoatOfArms_Click(object sender, EventArgs e)
        {
        }
    }
}