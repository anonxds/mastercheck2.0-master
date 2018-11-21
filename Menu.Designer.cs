namespace MasterCheck2._0
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnagregar3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btneditar3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar\r\nEmpleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "  Editar\r\nEmpleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Consultar\r\n   Listas";
            // 
            // btnagregar3
            // 
            this.btnagregar3.BackColor = System.Drawing.Color.Transparent;
            this.btnagregar3.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar3.Image")));
            this.btnagregar3.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnagregar3.ImageActive")));
            this.btnagregar3.Location = new System.Drawing.Point(76, 41);
            this.btnagregar3.Name = "btnagregar3";
            this.btnagregar3.Size = new System.Drawing.Size(71, 71);
            this.btnagregar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnagregar3.TabIndex = 10;
            this.btnagregar3.TabStop = false;
            this.btnagregar3.Zoom = 10;
            this.btnagregar3.Click += new System.EventHandler(this.btnagregar3_Click);
            // 
            // btneditar3
            // 
            this.btneditar3.BackColor = System.Drawing.Color.Transparent;
            this.btneditar3.Image = ((System.Drawing.Image)(resources.GetObject("btneditar3.Image")));
            this.btneditar3.ImageActive = ((System.Drawing.Image)(resources.GetObject("btneditar3.ImageActive")));
            this.btneditar3.Location = new System.Drawing.Point(175, 41);
            this.btneditar3.Name = "btneditar3";
            this.btneditar3.Size = new System.Drawing.Size(71, 71);
            this.btneditar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btneditar3.TabIndex = 11;
            this.btneditar3.TabStop = false;
            this.btneditar3.Zoom = 10;
            this.btneditar3.Click += new System.EventHandler(this.btneditar3_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ImageActive")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(275, 41);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 12;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(412, 173);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.btneditar3);
            this.Controls.Add(this.btnagregar3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton btnagregar3;
        private Bunifu.Framework.UI.BunifuImageButton btneditar3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
    }
}