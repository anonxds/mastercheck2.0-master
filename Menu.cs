﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterCheck2._0
{
    public partial class Menu : CustomForm.MyForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void txtConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtagregar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtListas_Click(object sender, EventArgs e)
        {
        
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Paloseco", 10, FontStyle.Regular);
            label2.Font = new Font("Paloseco", 10, FontStyle.Regular);
            label3.Font = new Font("Paloseco", 10, FontStyle.Regular);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Lista l = new Lista();
            l.Show();
            this.Hide();
        }

        private void btneditar3_Click(object sender, EventArgs e)
        {
            Consultar c = new Consultar();
            c.Show();
            this.Hide();
        }

        private void btnagregar3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
