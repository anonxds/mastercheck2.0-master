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
            this.btnreturn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnemp
            // 
            this.btnemp.Image = global::MasterCheck2._0.Properties.Resources.if_Revert_132070;
            this.btnemp.Location = new System.Drawing.Point(21, 310);
            this.btnemp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(73, 55);
            this.btnemp.TabIndex = 2;
            this.btnemp.UseVisualStyleBackColor = true;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(606, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbcmd
            // 
            this.cbcmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcmd.FormattingEnabled = true;
            this.cbcmd.Location = new System.Drawing.Point(470, 322);
            this.cbcmd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbcmd.Name = "cbcmd";
            this.cbcmd.Size = new System.Drawing.Size(82, 21);
            this.cbcmd.TabIndex = 4;
            this.cbcmd.SelectedIndexChanged += new System.EventHandler(this.cbcmd_SelectedIndexChanged);
            // 
            // txtSaveLoc
            // 
            this.txtSaveLoc.Location = new System.Drawing.Point(367, 322);
            this.txtSaveLoc.Name = "txtSaveLoc";
            this.txtSaveLoc.Size = new System.Drawing.Size(100, 20);
            this.txtSaveLoc.TabIndex = 5;
            this.txtSaveLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text_ip
            // 
            this.Text_ip.Location = new System.Drawing.Point(261, 322);
            this.Text_ip.Name = "Text_ip";
            this.Text_ip.Size = new System.Drawing.Size(100, 20);
            this.Text_ip.TabIndex = 6;
            this.Text_ip.Text = "192.168.0.5";
            this.Text_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExp
            // 
            this.btnExp.Image = global::MasterCheck2._0.Properties.Resources.if_Excel_84567;
            this.btnExp.Location = new System.Drawing.Point(555, 310);
            this.btnExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(56, 49);
            this.btnExp.TabIndex = 1;
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Regresar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 361);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Exportar";
            // 
            // btnreturn
            // 
            this.btnreturn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnreturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnreturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreturn.BorderRadius = 0;
            this.btnreturn.ButtonText = "";
            this.btnreturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreturn.DisabledColor = System.Drawing.Color.Gray;
            this.btnreturn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnreturn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnreturn.Iconimage")));
            this.btnreturn.Iconimage_right = null;
            this.btnreturn.Iconimage_right_Selected = null;
            this.btnreturn.Iconimage_Selected = null;
            this.btnreturn.IconMarginLeft = 0;
            this.btnreturn.IconMarginRight = 0;
            this.btnreturn.IconRightVisible = true;
            this.btnreturn.IconRightZoom = 0D;
            this.btnreturn.IconVisible = true;
            this.btnreturn.IconZoom = 90D;
            this.btnreturn.IsTab = false;
            this.btnreturn.Location = new System.Drawing.Point(154, 309);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnreturn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnreturn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnreturn.selected = false;
            this.btnreturn.Size = new System.Drawing.Size(57, 55);
            this.btnreturn.TabIndex = 9;
            this.btnreturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreturn.Textcolor = System.Drawing.Color.White;
            this.btnreturn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 377);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_ip);
            this.Controls.Add(this.txtSaveLoc);
            this.Controls.Add(this.cbcmd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnemp);
            this.Controls.Add(this.btnExp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private Bunifu.Framework.UI.BunifuFlatButton btnreturn;
    }
}