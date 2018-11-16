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
            this.txtListas = new System.Windows.Forms.Button();
            this.txtConsultar = new System.Windows.Forms.Button();
            this.txtagregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar\r\nEmpleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "  Editar\r\nEmpleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Consultar\r\n   Listas";
            // 
            // txtListas
            // 
            this.txtListas.Image = global::MasterCheck2._0.Properties.Resources.if_table_information_84941;
            this.txtListas.Location = new System.Drawing.Point(331, 41);
            this.txtListas.Name = "txtListas";
            this.txtListas.Size = new System.Drawing.Size(89, 72);
            this.txtListas.TabIndex = 2;
            this.txtListas.UseVisualStyleBackColor = true;
            this.txtListas.Click += new System.EventHandler(this.txtListas_Click);
            // 
            // txtConsultar
            // 
            this.txtConsultar.Image = global::MasterCheck2._0.Properties.Resources.if_user_male_edit_85002;
            this.txtConsultar.Location = new System.Drawing.Point(219, 41);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(78, 72);
            this.txtConsultar.TabIndex = 1;
            this.txtConsultar.UseVisualStyleBackColor = true;
            this.txtConsultar.Click += new System.EventHandler(this.txtConsultar_Click);
            // 
            // txtagregar
            // 
            this.txtagregar.Image = global::MasterCheck2._0.Properties.Resources.if_user_male_add_85000;
            this.txtagregar.Location = new System.Drawing.Point(103, 41);
            this.txtagregar.Name = "txtagregar";
            this.txtagregar.Size = new System.Drawing.Size(78, 72);
            this.txtagregar.TabIndex = 0;
            this.txtagregar.UseVisualStyleBackColor = true;
            this.txtagregar.Click += new System.EventHandler(this.txtagregar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 207);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListas);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.txtagregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtagregar;
        private System.Windows.Forms.Button txtConsultar;
        private System.Windows.Forms.Button txtListas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}