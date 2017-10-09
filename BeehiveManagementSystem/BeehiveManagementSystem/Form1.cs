using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveManagementSystem
{
    public partial class Form1 : Form
    {
        private Queen queen;

        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(175, new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(114, new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(149, new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(155, new string[] { "Baby bee tutoring", "Egg care",
                "Hive maintenance", "Honey manufacturing", "Nectar collector", "Sting patrol" });
            queen = new Queen(275, workers);
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value))
                MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in " 
                    + shifts.Value + " shifts.", "The queen bee says...");
            else
                MessageBox.Show("No worker bees are available to do the job '" 
                    + workerBeeJob.Text + "'.", "The queen bee says...");
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
