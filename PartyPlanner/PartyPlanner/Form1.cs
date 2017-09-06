using System;
using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numericUpDown1.Value, fancyBox.Checked, healthyBox.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numericUpDownBday.Value, fancyBoxBday.Checked,
                cakeWritingText.Text);
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.Cost;
            costLabel.Text = cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            decimal cost = birthdayParty.Cost;
            costLabelBday.Text = cost.ToString("c");
        }

        private void numericUpDownBday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDownBday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBoxBday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBoxBday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWritingText_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWritingText.Text;
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            DisplayBirthdayPartyCost();
        }
    }
}
