using Data_Base_Project.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Base_Project
{
    public partial class MainMenu : UserControl
    {
        private Form1 form;
        public MainMenu()
        {
            InitializeComponent();
        }

        public void setform(Form1 form1)
        {
            this.form = form1;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            form.ShowLogin();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            form.ShowRegister();
        }
    }
}
