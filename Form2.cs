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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            firstForm.Show();
            this.Dispose();
        }

        private void onePlayerButton_Click(object sender, EventArgs e)
        {
            levelLabel.Visible = true;
            levelComboBox.Visible = true;
        }

        private void twoPlayersButton_Click(object sender, EventArgs e)
        {
            levelLabel.Visible = false;
            levelComboBox.Visible = false;
            startGameButton.Enabled = true;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            Form3 thirdForm = new Form3();
            thirdForm.Show();
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void levelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startGameButton.Enabled = true;
        }
    }
}
