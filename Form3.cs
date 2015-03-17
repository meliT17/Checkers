using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int x, y;
            int buttonWidth = 40;
            int buttonHeight = 40;
            int distance = 20;
            int startX = 10;
            int startY = 10;

            for(x = 0; x < 8; x++)
            {
                for(y = 0; y < 8; y++)
                {
                    Button button1 = new Button();
                    button1.Top = startX + (x * buttonHeight + distance);
                    button1.Left = startY + (y * buttonWidth + distance);
                    button1.Width = buttonWidth;
                    button1.Height = buttonHeight;
                    //button1.Text = "X: " + x.ToString() + "\nY: " + y.ToString();
                    this.Controls.Add(button1);
                }
            }
        }
    }
}
