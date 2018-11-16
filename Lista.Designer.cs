namespace MasterCheck2._0
{
    partial class Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista));
            this.btnemp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbcmd = new System.Windows.Forms.ComboBox();
            this.txtSaveLoc = new System.Windows.Forms.TextBox();
            this.Text_ip = new System.Windows.Forms.TextBox();
            this.btnExp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnemp
            // 
            this.btnemp.Image = global::MasterCheck2._0.Properties.Resources.if_Revert_132070;
            this.btnemp.Location = new System.Drawing.Point(32, 477);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(110, 85);
            this.btnemp.TabIndex = 2;
            this.btnemp.UseVisualStyleBackColor = true;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(909, 455);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbcmd
            // 
            this.cbcmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcmd.FormattingEnabled = true;
            this.cbcmd.Location = new System.Drawing.Point(705, 495);
            this.cbcmd.Name = "cbcmd";
            this.cbcmd.Size = new System.Drawing.Size(121, 28);
            this.cbcmd.TabIndex = 4;
            this.cbcmd.SelectedIndexChanged += new System.EventHandler(this.cbcmd_SelectedIndexChanged);
            // 
            // txtSaveLoc
            // 
            this.txtSaveLoc.Location = new System.Drawing.Point(550, 495);
            this.txtSaveLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSaveLoc.Name = "txtSaveLoc";
            this.txtSaveLoc.Size = new System.Drawing.Size(148, 26);
            this.txtSaveLoc.TabIndex = 5;
            this.txtSaveLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text_ip
            // 
            this.Text_ip.Location = new System.Drawing.Point(369, 495);
            this.Text_ip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_ip.Name = "Text_ip";
            this.Text_ip.Size = new System.Drawing.Size(148, 26);
            this.Text_ip.TabIndex = 6;
            this.Text_ip.Text = "192.168.0.5";
            this.Text_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExp
            // 
            this.btnExp.Image = global::MasterCheck2._0.Properties.Resources.if_Excel_84567;
            this.btnExp.Location = new System.Drawing.Point(832, 477);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(84, 75);
            this.btnExp.TabIndex = 1;
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Regresar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(837, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Exportar";
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_ip);
            this.Controls.Add(this.txtSaveLoc);
            this.Controls.Add(this.cbcmd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnemp);
            this.Controls.Add(this.btnExp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbcmd;
        private System.Windows.Forms.TextBox txtSaveLoc;
        private System.Windows.Forms.TextBox Text_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}