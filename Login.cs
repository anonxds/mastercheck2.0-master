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
namespace MasterCheck2._0
{
    public partial class Login : Form
    {
        string cnn = @"SERVER=localhost; DATABASE=mastercheck; UID=root; PASSWORD=12345";

        public Login()
        {
            InitializeComponent();
            populate();
            btncontra2.Enabled = btnlogin2.Enabled =  false;
            
        }
        BaseDeDatos db = new BaseDeDatos();
        //    Form1 c = new Form1();
        Menu m = new Menu();
        //     Login l = new Login();

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
        }
        public void populate()
        {

            using (var cn = new MySqlConnection(cnn))
            {
                cn.Open();
                string consulta = "SELECT users FROM users";
                using (var cmd = new MySqlCommand(consulta, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            cbusers2.Items.Add(reader.GetString("users"));
                        }
                }
            }
        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cnn);
                con.Open();


                string login = string.Format("select * from users where users = '{0}' and pass= '{1}'", cbusers2.Text, btncontra2.Text);
                MySqlCommand cmd = new MySqlCommand(login, con);
                MySqlDataReader l = cmd.ExecuteReader();
                if (l.Read())
                {
                    this.Hide();
                    m.Show();

                }
                else
                    MessageBox.Show("No existe el usario");

                /*          
                                if (db.executecommand(login))
                                {
                                    this.Hide();
                                    c.Show();

                                }
                                */
            }
            catch
            {
                MessageBox.Show("Usario no existe");
            }
        }

        private void cbusuarios2_onItemSelected(object sender, EventArgs e)
        {
           
        }

        private void cbusers2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btncontra2.Enabled = true;
        }

        private void btncontra2_OnValueChanged(object sender, EventArgs e)
        {
            btnlogin2.Enabled = !string.IsNullOrWhiteSpace(this.btncontra2.Text);
        }
    }
}
