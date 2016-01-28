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
    public partial class CountingForm : Form
    {
        private readonly Button[] ImageButtons;

        private ImageHelper imgHelper;
        private int Count = 0;

        public CountingForm()
        {
            InitializeComponent();

            // Init the image helper

            imgHelper = new ImageHelper();
            ImageButtons = new Button[]
            {
                row10, row11, row12, row13, row14,
                row15, row16, row17, row18, row19
            };

            // Load the images each time it is shown.
            this.Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs eventArgs)
        {
            // Load the images.
            Random r = new Random();
            Count = r.Next(10) + 1;

            for (int i = 0; i < Count; i++)
            {
                ImageButtons[i].Visible = true;
                ImageButtons[i].BackgroundImage = imgHelper.GetRandomChoiceImage();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            SelectForm s = new SelectForm();
            s.Show();
            this.Hide();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            resultBtn.Visible = true;
            resultBtn.BackgroundImage = imgHelper.GetNumberImage(Count);
        }
    }
}
