using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        //Windows Forms uygulaması açılmıştır.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button = new Button();
            //Butonu ekrana ekleme
            button.Width = 50;
            button.Height = 50;
            this.Controls.Add(button);
        }
    }
}
