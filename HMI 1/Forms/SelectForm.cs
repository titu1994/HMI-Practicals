using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMI_1.Forms;

namespace HMI_1
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SubtractionBtn_Click(object sender, EventArgs e)
        {
            SubtractionForm s = new SubtractionForm();
            s.Show();
            this.Hide();
        }

        private void AdditionBtn_Click(object sender, EventArgs e)
        {
            AdditionForm a = new AdditionForm();
            a.Show();
            this.Hide();
        }

        private void CountingBtn_Click(object sender, EventArgs e)
        {
            CountingForm f = new CountingForm();
            f.Show();
            this.Hide();
        }
    }
}
