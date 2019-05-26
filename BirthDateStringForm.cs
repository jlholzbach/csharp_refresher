using System;
using System.Windows.Forms;

namespace BirthDateString
{
    public partial class BirthDateStringForm : Form
    {
        public BirthDateStringForm()
        {
            InitializeComponent();
        }

        private void ShowDateButton_Click(object sender, EventArgs e)
        {
            string output = "";
            output += dayOfWeekTextBox.Text + ", " + monthTextBox.Text
                + " " + dayOfMonthTextBox.Text + ", " + yearTextBox.Text;
            dateOutputLabel.Text = output;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";
            dateOutputLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
