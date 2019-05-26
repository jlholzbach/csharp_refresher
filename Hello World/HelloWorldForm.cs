using System.Windows.Forms;

namespace Hello_World
{
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}
