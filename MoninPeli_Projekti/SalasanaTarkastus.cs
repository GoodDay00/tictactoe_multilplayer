using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoninPeli_Projekti
{
    public partial class SalasanaTarkastus : Form
    {
        public SalasanaTarkastus()
        {
            InitializeComponent();
        }

        private void SalasanaTarkastus_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liityHuone.pass = salasana.Text;
            Close();
        }
    }
}
