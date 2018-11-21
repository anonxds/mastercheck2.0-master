namespace MasterCheck2._0
{
    partial class Check
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.Timer(this.components);
            this.lbldept = new System.Windows.Forms.Label();
            this.btnhistorial = new System.Windows.Forms.Button();
            this.lbldepartamento = new System.Windows.Forms.Label();
            this.Insertar = new System.Windows.Forms.Timer(this.components);
            this.Eliminar = new System.Windows.Forms.Timer(this.components);
            this.lblChek = new System.Windows.Forms.Label();
            this.lbltimer = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 26);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Enabled = false;
            this.lblID.Location = new System.Drawing.Point(643, 194);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Nombre";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(761, 194);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(13, 20);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = " ";
            // 
            // mensaje
            // 
            this.mensaje.Interval = 6000;
            this.mensaje.Tick += new System.EventHandler(this.mensaje_Tick);
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(643, 224);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(112, 20);
            this.lbldept.TabIndex = 8;
            this.lbldept.Text = "Departamento";
            // 
            // btnhistorial
            // 
            this.btnhistorial.Location = new System.Drawing.Point(16, 17);
            this.btnhistorial.Name = "btnhistorial";
            this.btnhistorial.Size = new System.Drawing.Size(80, 45);
            this.btnhistorial.TabIndex = 9;
            this.btnhistorial.Text = "Historial";
            this.btnhistorial.UseVisualStyleBackColor = true;
            this.btnhistorial.Click += new System.EventHandler(this.btnhistorial_Click);
            // 
            // lbldepartamento
            // 
            this.lbldepartamento.AutoSize = true;
            this.lbldepartamento.Location = new System.Drawing.Point(761, 224);
            this.lbldepartamento.Name = "lbldepartamento";
            this.lbldepartamento.Size = new System.Drawing.Size(13, 20);
            this.lbldepartamento.TabIndex = 10;
            this.lbldepartamento.Text = " ";
            // 
            // Insertar
            // 
            this.Insertar.Interval = 1000;
            this.Insertar.Tick += new System.EventHandler(this.Insertar_Tick);
            // 
            // Eliminar
            // 
            this.Eliminar.Interval = 100000;
            this.Eliminar.Tick += new System.EventHandler(this.Eliminar_Tick);
            // 
            // lblChek
            // 
            this.lblChek.AutoSize = true;
            this.lblChek.Image = global::MasterCheck2._0.Properties.Resources.appbar_check;
            this.lblChek.Location = new System.Drawing.Point(856, 194);
            this.lblChek.Name = "lblChek";
            this.lblChek.Size = new System.Drawing.Size(141, 60);
            this.lblChek.TabIndex = 12;
            this.lblChek.Text = "                                 \r\n\r\n                                 ";
            this.lblChek.Visible = false;
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Location = new System.Drawing.Point(309, 42);
            this.lbltimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(13, 20);
            this.lbltimer.TabIndex = 13;
            this.lbltimer.Text = " ";
            this.lbltimer.Visible = false;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(82, 14);
            this.circularProgressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(480, 492);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "00";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 14;
            this.circularProgressBar1.Text = "00:00:00";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            this.circularProgressBar1.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1028, 509);
            this.ControlBox = false;
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.lblChek);
            this.Controls.Add(this.lbldepartamento);
            this.Controls.Add(this.btnhistorial);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.circularProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Check";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Check_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Timer mensaje;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Button btnhistorial;
        private System.Windows.Forms.Label lbldepartamento;
        private System.Windows.Forms.Timer Insertar;
        private System.Windows.Forms.Timer Eliminar;
        private System.Windows.Forms.Label lblChek;
        private System.Windows.Forms.Label lbltimer;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}