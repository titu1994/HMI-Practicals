using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMI_1
{
    class ImageHelper
    {

        private static readonly Bitmap[] ImageIds =
        {
            HMI_1.Properties.Resources.apple,
            HMI_1.Properties.Resources.jerry,
            HMI_1.Properties.Resources.jerry_2,
            HMI_1.Properties.Resources.orange,
            HMI_1.Properties.Resources.star
        };

        private static readonly Bitmap[] NumberIds =
        {
            HMI_1.Properties.Resources._0,
            HMI_1.Properties.Resources._1,
            HMI_1.Properties.Resources._2,
            HMI_1.Properties.Resources._3,
            HMI_1.Properties.Resources._4,
            HMI_1.Properties.Resources._5,
            HMI_1.Properties.Resources._6,
            HMI_1.Properties.Resources._7,
            HMI_1.Properties.Resources._8,
            HMI_1.Properties.Resources._9,
            HMI_1.Properties.Resources._10
        };

        private int imageChoice = -1;

        public ImageHelper()
        {
            Random r = new Random();
            imageChoice = r.Next(ImageIds.Length);
        }

        public Bitmap GetRandomChoiceImage()
        {
            return ImageIds[imageChoice];
        }

        public Bitmap GetNumberImage(int number)
        {
            return NumberIds[number];
        }

        public Bitmap GetSignImage(bool neg)
        {
            if (neg)
            {
                return HMI_1.Properties.Resources._069568_blue_jelly_icon_alphanumeric_minus_sign_simple;
            }
            else
            {
                return HMI_1.Properties.Resources._069598_blue_jelly_icon_alphanumeric_plus_sign;
            }
        }
    }
}
