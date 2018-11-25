using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MasterCheck2._0
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
            Eliminar.Start();
        }
        BaseDeDatos db = new BaseDeDatos();
        string cnn = @"SERVER=localhost; DATABASE=mastercheck; UID=root; PASSWORD=12345;";

        private void Check_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Maximum = 60;
            Eliminar.Start();
            Insertar.Start();
          System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapse;
            timer.Start();  
        }

        private void Timer_Elapse(object sender,System.Timers.ElapsedEventArgs e)
        {
            
            circularProgressBar1.Invoke((MethodInvoker)delegate
            {
                circularProgressBar1.Text = DateTime.Now.ToString("hh:mm:ss");
            //    circularProgressBar1.SubscriptText = DateTime.Now.AddMilliseconds(100);
            });
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            /*
            string sql = "select count(*) from checks where (ID = @ID)";
        //    string sql2 = "select count(*) from checks where (ID = @IDS) and (Entrada=@Entrada)";
            using (MySqlConnection cn = new MySqlConnection(cnn))
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    var result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result > 0)
                    {
                       
                        string alter = string.Format("update checks set Salida ='{0}' where ID='{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), textBox1.Text);
                        string his = string.Format("insert into salida values('{0}','{1}')",  textBox1.Text ,DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        db.executecommand(alter);
                        db.executecommand(his);
                        lblNom.Text= textBox1.Text;
                        lblSal.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        lblEnt.Visible = true;
                        lblEntrada.Visible = true;
                        lblID.Visible = true;
                        lblNom.Visible = true;
                        lblSal.Visible = true;
                        lblSalida.Visible = true;
                      

                    }
                    else
                    {
                        //
                    

                        //
                        string add = string.Format("insert into checks (`ID`,`Entrada`,`Salida`) values ('{0}','{1}','{2}')", textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "");
                        string historial = string.Format("insert into entrada values ('{0}','{1}')", textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "");
                        string asistencia = string.Format("update registros set Asistencias = Asistencias + 1 where idrfid = 1");
                        db.executecommand(asistencia);
                        db.executecommand(add);
                        db.executecommand(historial);
                       lblEnt.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                     
                        mensaje.Enabled = true;
                        mensaje.Start();
                      
                    }
                }
            }
           
            */

            
        }

        private void mensaje_Tick(object sender, EventArgs e)
        {
            lblChek.Visible = false;
            lblNom.Text = "";
            lbldepartamento.Text = "";
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            
        }

        private void Insertar_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToString("ss");
            circularProgressBar1.Value = Convert.ToInt32(lbltimer.Text);
        }

        private void Eliminar_Tick(object sender, EventArgs e)
        {
            string el = string.Format("delete table checks");
            if (db.executecommand(el))
            {
                MessageBox.Show("se borraron los registros");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string sql = "select count(*) from registros where (idrfid = @idrfid)";
            string sql2 = "select count(*) from checks where (ID = @ID)";
            //   MessageBox.Show("Se inserto dato",textBox1.Text);
            using (MySqlConnection cn = new MySqlConnection(cnn))
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                using (MySqlCommand cmd2 = new MySqlCommand(sql2, cn))
                {
                    {
                        cmd.Parameters.AddWithValue("@idrfid", textBox1.Text);
                        var result = Convert.ToInt32(cmd.ExecuteScalar());
                        cmd2.Parameters.AddWithValue("@ID", textBox1.Text);
                        var res2 = Convert.ToInt32(cmd2.ExecuteScalar());
                        if (result > 0)
                        {
                      
                            if (res2 > 0 && result > 0)
                            {
                                string del = string.Format("delete from entrada where Entrada = '{0}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                                db.executecommand(del);
                                string upt = string.Format("update checks set Salida ='{0}' where ID='{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), textBox1.Text);
                                db.executecommand(upt);
                                string his = string.Format("insert into salida values('{0}','{1}')", textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                db.executecommand(his);
                                string asis = string.Format("update registros set Asistencias = (Asistencias - 1) where idrfid = '{0}'", textBox1.Text);
                                db.executecommand(asis);
                                
                                MessageBox.Show("el usuario ya salio");
                                
                            }

                            var cn2 = new MySqlConnection(cnn);
                            cn2.Open();
                            MySqlCommand cmd3 = cn.CreateCommand();
                            cmd3.CommandType = CommandType.Text;
                            cmd3.CommandText = "select * from registros where idrfid='" + textBox1.Text + "'";
                            cmd3.ExecuteNonQuery();



                            DataTable dt = new DataTable();
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd3);
                            da.Fill(dt);
                            foreach (DataRow dr in dt.Rows)
                            {
                                lblNom.Text = dr["Nombre"].ToString();
                                lbldepartamento.Text = dr["Departamento"].ToString();
                                lblChek.Visible = true;
                            }


                            string ins = string.Format("insert into checks values('{0}','{1}','{2}')",textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),"");
                            db.executecommand(ins);
                            string historial = string.Format("insert into entrada values ('{0}','{1}')", textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "");
                            db.executecommand(historial);
                            string asistencia = string.Format("update registros set Asistencias = (Asistencias + 1) where idrfid = '{0}'",textBox1.Text);
                            db.executecommand(asistencia);
                            lblChek.Visible = true;
                            mensaje.Start();
                          //  mensaje.Stop();
                            
                            
                            /*
                            var cn2 = new MySqlConnection(cnn);
                            cn2.Open();
                            MySqlCommand cmd2 = cn.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "select * from registros where idrfid='" + textBox1.Text + "'";
                            cmd2.ExecuteNonQuery();



                            DataTable dt = new DataTable();
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                            da.Fill(dt);
                            foreach (DataRow dr in dt.Rows)
                            {
                                lblNom.Text = dr["Nombre"].ToString();
                                lbldepartamento.Text = dr["Departamento"].ToString();
                                lblEnt.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                lblChek.Visible = true;
                            }

                            //
                            string add = string.Format("insert into checks (`ID`,`Entrada`,`Salida`) values ('{0}','{1}','{2}')", textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "");
 
                            
                            db.executecommand(add);
                            db.executecommand(historial);

                            //   mensaje.Enabled = true;
                            //mensaje.Start();
                            string hist = string.Format("select * from entrada where id='{0}'", textBox1.Text);
                            dataGridView1.DataSource = db.SelectDataTable(hist);
                            */

                            //MessageBox.Show("El usuario entro");
                            textBox1.Text = "";
                            
                        }
                        else if (res2 > 0 || result > 0)
                        {
                            //
                            MessageBox.Show("el usuario ya salio");

                            /*
                            string alter = string.Format("update checks set Salida ='{0}' where ID='{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), textBox1.Text);
                
                            db.executecommand(alter);
                            db.executecommand(his);
                            //
                            var cn2 = new MySqlConnection(cnn);
                            cn2.Open();
                            MySqlCommand cmd2 = cn.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "select * from registros where idrfid='" + textBox1.Text + "'";
                            cmd2.ExecuteNonQuery();



                            DataTable dt = new DataTable();
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                            da.Fill(dt);
                            foreach (DataRow dr in dt.Rows)
                            {
                                lblNom.Text = dr["Nombre"].ToString();
                                lbldepartamento.Text = dr["Departamento"].ToString();
                                lblChek.Visible = true;
                            }

                            //
                            lblEnt.Visible = true;
                            lblEntrada.Visible = true;
                            lblID.Visible = true;
                            lblNom.Visible = true;

                            //mensaje.Start();
                            string hist = string.Format("select id, sal as salida from salida where id='{0}'", textBox1.Text);
                            dataGridView1.DataSource = db.SelectDataTable(hist);
                            */
                        }
                    }
                }
            }
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
