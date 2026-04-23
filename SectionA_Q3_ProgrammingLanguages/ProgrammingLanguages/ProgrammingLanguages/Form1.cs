using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingLanguages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Favourite Programming Languages";

            // Placeholder
            txtLanguage.Text = "Enter programming language";
            txtLanguage.ForeColor = Color.Gray;

            // Add default languages
            lstLanguages.Items.Add("C#");
            lstLanguages.Items.Add("Python");
            lstLanguages.Items.Add("Java");
            lstLanguages.Items.Add("JavaScript");
            lstLanguages.Items.Add("Go");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void txtLanguage_Enter(object sender, EventArgs e)
        {
            if (txtLanguage.Text == "Enter programming language")
            {
                txtLanguage.Text = "";
                txtLanguage.ForeColor = Color.Black;
            }
        }

        private void txtLanguage_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLanguage.Text))
            {
                txtLanguage.Text = "Enter programming language";
                txtLanguage.ForeColor = Color.Gray;
            }
        }

        private void txtLanguage_TextChanged(object sender, EventArgs e)
        {
        }

        private void lstLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string language = txtLanguage.Text.Trim();

            // Check for empty input or placeholder
            if (string.IsNullOrEmpty(language) ||
                language == "Enter programming language")
            {
                lblStatus.Text = "Please enter a programming language.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            // Check for duplicates
            foreach (var item in lstLanguages.Items)
            {
                if (item.ToString().ToLower() == language.ToLower())
                {
                    lblStatus.Text = $"'{language}' already exists in the list.";
                    lblStatus.ForeColor = Color.Red;
                    return;
                }
            }

            // Add language
            lstLanguages.Items.Add(language);
            string timestamp = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
            lblStatus.Text = $"Added '{language}' at {timestamp}";
            lblStatus.ForeColor = Color.Green;

            // Reset to placeholder
            txtLanguage.Text = "Enter programming language";
            txtLanguage.ForeColor = Color.Gray;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedItem == null)
            {
                lblStatus.Text = "Please select a language to remove.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            string language = lstLanguages.SelectedItem.ToString();
            lstLanguages.Items.Remove(lstLanguages.SelectedItem);
            string timestamp = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
            lblStatus.Text = $"Removed '{language}' at {timestamp}";
            lblStatus.ForeColor = Color.Red;
        }
    }
}