using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchingGame
{
    public partial class Form1 : Form
    {
        String message;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            falseMain_display();
        }

        private void falseMain_display()
        {
            title_lbl.Visible = false;

            start_btn.Visible = false;
            help_btn.Visible = false;
            quit_btn.Visible = false;
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            message = "Hello! Thank you for downloading the game.";
            MessageBox.Show(message);
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
