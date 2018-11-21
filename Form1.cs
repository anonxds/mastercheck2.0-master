﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
namespace MasterCheck2._0
{
    public partial class Form1 : CustomForm.MyForm
    {
      
        string[] dept = new string[5] { "Computacion", "Industrial", "Bioquimica", "Literatura", "Aeronatica" };
        string[] puesto = new string[2] { "Empleado", "Profesor" };
        public Form1()
        {
            InitializeComponent();

          btnguardar2.Enabled =  txtnombre2.Enabled = txtedad2.Enabled = txtapellido2.Enabled = cbPuesto2.Enabled = cbDepartamento2.Enabled = false;
            bunifuCustomDataGrid1.DataSource = db.SelectDataTable("select idrfid as `ID`, Nombre, Apellido, Edad, Departamento, FechaIn as `Fecha de Ingreso` from registros");
            //  label1.Text = DateTime.Now.ToString("h:mm:ss tt");
            for (int i = 0; i < dept.Length-1; i++)
            {
                cbDepartamento2.Items.Add(dept[i]);
            }
            for (int i = 0; i < puesto.Length; i++)
            {
                cbPuesto2.Items.Add(puesto[i]);
            }
   
        }
        BaseDeDatos db = new BaseDeDatos();

        private void btnid_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar c = new Consultar();
            c.Show();
            this.Hide();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
      

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void btnselimagen_Click(object sender, EventArgs e)
        {
            
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista l = new Lista();
            l.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnrregresar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
          
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
         
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
         
        }

        private void txtid2_TextChange(object sender, EventArgs e)
        {
            btnguardar2.Enabled = txtnombre2.Enabled = txtedad2.Enabled = txtapellido2.Enabled = cbPuesto2.Enabled = cbDepartamento2.Enabled = !string.IsNullOrWhiteSpace(this.txtid2.Text);

        }

        private void txtid2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtnombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtapellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtedad2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnregresar3_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            this.Hide();
        }

        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = db.SelectDataTable("select idrfid as `ID`, Nombre, Apellido, Edad, Departamento, FechaIn as `Fecha de Ingreso` from registros");
        }

        private void btnguardar2_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                string Agregar = string.Format("INSERT INTO `mastercheck`.`registros` (`idrfid`, `Nombre`, `Apellido`, `Edad`, `Departamento`, `FechaIn`, `puesto`, `Perfil`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}')",
                    txtid2.Text, txtnombre2.Text, txtapellido2.Text, txtedad2.Text, cbDepartamento2.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), cbPuesto2.Text, img);

                if (db.executecommand(Agregar))
                {
                    MessageBox.Show("Agregado al Sistema");
                    txtapellido2.Text = txtedad2.Text = txtid2.Text = txtnombre2.Text = "";
                    cbPuesto2.Text = null;
                    cbDepartamento2.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique si los Datos estan correctos " + ex.Message);
            }
        }

        private void btnpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
