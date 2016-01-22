using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMI_1
{
    public partial class StartForm : Form
    {

        private Timer timer;

        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Click(object sender, EventArgs e)
        {
            timer.Stop();

            SelectForm s = new SelectForm();
            s.Show();
            this.Hide();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 4*1000;
            timer.Tick += NextForm;
            timer.Start();
        }

        private void NextForm(object sender, EventArgs eventArgs)
        {
            timer.Stop();

            SelectForm s = new SelectForm();
            s.Show();
            this.Hide();
        }
    }
}
