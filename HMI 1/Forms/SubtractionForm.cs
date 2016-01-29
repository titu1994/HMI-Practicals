using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMI_1.Forms
{
    public partial class SubtractionForm : Form
    {
        private readonly Button[] ImageButtons, ImageButtons2;

        private ImageHelper imgHelper;
        private int Count1 = 0, Count2 = 0, totalCount = 0;
        public SubtractionForm()
        {
            InitializeComponent();

            // Init the image helper

            imgHelper = new ImageHelper();

            ImageButtons = new Button[]
            {
                row10, row11, row12, row13, row14,
                row15, row16, row17, row18, row19
            };

            ImageButtons2 = new Button[]
            {
                row20, row21, row22, row23, row24,
                row25, row26, row27, row28, row29
            };

            // Load the images each time it is shown.
            this.Shown += OnShown;
        }

        private void subtractionBtn_Click(object sender, EventArgs e)
        {
            result1.Visible = true;
            result2.Visible = true;
            
            bool neg = totalCount < 0;

            result1.BackgroundImage = imgHelper.GetSignImage(neg);

            if (neg)
            {
                result2.BackgroundImage = imgHelper.GetNumberImage(-totalCount);
            }
            else
            {
                result2.BackgroundImage = imgHelper.GetNumberImage(totalCount);
            }
        
            
        }

        private void OnShown(object sender, EventArgs eventArgs)
        {
            // Load the images.
            Random r = new Random();
            Count1 = r.Next(10) + 1;

            for (int i = 0; i < Count1; i++)
            {
                ImageButtons[i].Visible = true;
                ImageButtons[i].BackgroundImage = imgHelper.GetRandomChoiceImage();
            }

            Count2 = r.Next(10) + 1;

            for (int i = 0; i < Count2; i++)
            {
                ImageButtons2[i].Visible = true;
                ImageButtons2[i].BackgroundImage = imgHelper.GetRandomChoiceImage();
            }

            totalCount = Count1 - Count2;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            SelectForm s = new SelectForm();
            s.Show();
            this.Hide();
        }

        
    }
}
