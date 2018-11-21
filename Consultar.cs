using System;
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
    public partial class Consultar : CustomForm.MyForm
    {
        public void populate()
        {

            using (var cn = new MySqlConnection(cnn))
            {
               cn.Open();
                string consulta = "SELECT idrfid FROM registros";
                using (var cmd = new MySqlCommand(consulta, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            cbid2.Items.Add(reader.GetString("idrfid"));
                        }
                }
            }


            DataTable dt = new DataTable();
        }

        string[] dept = new string[5] { "Computacion", "Industrial", "Bioquimica", "Literatura", "Aeronatica" };
        string[] puesto = new string[2] { "Empleado", "Profesor" };

        public Consultar()
        {
            InitializeComponent();

            btnerase3.Enabled = btnguardar3.Enabled  = txtNombre2.Enabled = txtApellido2.Enabled = txtedad2.Enabled = cbpuesto2.Enabled = cbdepartamento2.Enabled = true;

            lbltiempo.Text = DateTime.Now.ToString("yyyy-MM-dd");
            populate();
            timer1.Start();
            lbltime.Text = DateTime.Now.ToLongTimeString();

            for (int i = 0; i < dept.Length - 1; i++)
            {
                cbdepartamento2.Items.Add(dept[i]);
            }
            for (int i = 0; i < puesto.Length; i++)
            {
                cbpuesto2.Items.Add(puesto[i]);
            }
        }
        BaseDeDatos db = new BaseDeDatos();
        string cnn = @"SERVER=localhost; DATABASE=mastercheck; UID=root; PASSWORD=12345";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   string c = string.Format("Select idrfid, Nombre, FechaIn, Asistencias, Faltas, Puesto, noEmp from registros");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(entrada, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }




        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
        
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
           
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            lblApellido.Font = new Font("Paloseco", 10, FontStyle.Regular);
            lbledad.Font = new Font("Paloseco", 10, FontStyle.Regular);
            lblpuesto.Font = new Font("Paloseco", 10, FontStyle.Regular);
            label1.Font = new Font("Paloseco", 10, FontStyle.Regular);
            label2.Font = new Font("Paloseco", 10, FontStyle.Regular);
            label3.Font = new Font("Paloseco", 10, FontStyle.Regular);
            label4.Font = new Font("Paloseco", 10, FontStyle.Regular);
            label5.Font = new Font("Paloseco", 10, FontStyle.Regular);
            label6.Font = new Font("Paloseco", 10, FontStyle.Regular);
            label7.Font = new Font("Paloseco", 10, FontStyle.Regular);
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
        }

        private void cbid2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cn = new MySqlConnection(cnn);
            cn.Open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registros where idrfid='" + cbid2.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {


                //  comboBox1.Text = dr["idrfid"].ToString();
                txtNombre2.Text = dr["Nombre"].ToString();
                txtApellido2.Text = dr["Apellido"].ToString();
                txtedad2.Text = dr["Edad"].ToString();
                cbdepartamento2.Text = dr["Departamento"].ToString();
                cbpuesto2.Text = dr["puesto"].ToString();
                string his = string.Format("select * from entrada where id='{0}'", cbid2.Text);
                string sal = string.Format("select sal as Salida from salida where id='{0}'", cbid2.Text);
                entrada.DataSource = db.SelectDataTable(his);
                Salida.DataSource = db.SelectDataTable(sal);

            }
            cn.Close();
        }

        private void cbid2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbid2_TextChanged(object sender, EventArgs e)
        {
            btnerase3.Enabled = btnguardar3.Enabled  = txtNombre2.Enabled = txtApellido2.Enabled = txtedad2.Enabled = cbpuesto2.Enabled = cbdepartamento2.Enabled =!string.IsNullOrWhiteSpace(this.cbid2.Text);

        }

        private void btnerase3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Quiere eliminar este usuario", "Eliminar", MessageBoxButtons.YesNo);
                string delete = string.Format("DELETE FROM `mastercheck`.`registros` WHERE(`idrfid` = '{0}')", cbid2.Text);
                string deletehis = string.Format("DELETE FROM `mastercheck`.`checks` WHERE(`ID` = '{0}')", cbid2.Text);
                string deletesal = string.Format("DELETE FROM `mastercheck`.`entrada` WHERE(`id` = '{0}')", cbid2.Text);
                string deleteent = string.Format("DELETE FROM `mastercheck`.`salida` WHERE(`id` = '{0}')", cbid2.Text);

                string deletechecks = string.Format("DELETE FROM `mastercheck`.`historial` WHERE(`id` = '{0}')", cbid2.Text);





                if (dialogResult == DialogResult.Yes)
                {
                    if (db.executecommand(deletehis) && db.executecommand(deletesal) && db.executecommand(deleteent) && db.executecommand(deletechecks))
                    {

                        db.executecommand(delete);
                        MessageBox.Show("Se Elimino");
                        cbid2.Text = "";
                        txtApellido2.Text = "";
                        txtedad2.Text = "";
                        txtNombre2.Text = "";
                        cbdepartamento2.Text = "";
                        cbpuesto2.Text = "";
                        cbid2.Refresh();




                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error");
            }

        }

        private void btnguardar3_Click(object sender, EventArgs e)
        {
            try
            {
                string alter = string.Format("UPDATE `mastercheck`.`registros` SET `Nombre` = '{0}', `Apellido` = '{1}', `Edad` = '{2}', `Departamento` = '{3}', `puesto` = '{4}' WHERE (`idrfid` = '{5}')", txtNombre2.Text, txtApellido2.Text, txtedad2.Text, cbdepartamento2.Text, cbpuesto2.Text, cbid2.Text);
                if (db.executecommand(alter))
                {
                    MessageBox.Show("Se guardo los cambios");
                }
                else
                {
                    MessageBox.Show("Hubo un error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error2 ", ex.Message);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
