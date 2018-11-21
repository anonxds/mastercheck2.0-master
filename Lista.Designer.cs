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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnregresar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnexport = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtip = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtpath = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cdlistas = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnregresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(35, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Regresar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(916, 694);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Exportar";
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnregresar, BunifuAnimatorNS.DecorationType.None);
            this.btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("btnregresar.Image")));
            this.btnregresar.ImageActive = null;
            this.btnregresar.Location = new System.Drawing.Point(18, 609);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(106, 94);
            this.btnregresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnregresar.TabIndex = 9;
            this.btnregresar.TabStop = false;
            this.btnregresar.Zoom = 10;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnexport, BunifuAnimatorNS.DecorationType.None);
            this.btnexport.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.Image")));
            this.btnexport.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnexport.ImageActive")));
            this.btnexport.Location = new System.Drawing.Point(921, 609);
            this.btnexport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(84, 80);
            this.btnexport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnexport.TabIndex = 10;
            this.btnexport.TabStop = false;
            this.btnexport.Zoom = 10;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // txtip
            // 
            this.txtip.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtip.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtip.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtip.BorderThickness = 3;
            this.txtip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtip, BunifuAnimatorNS.DecorationType.None);
            this.txtip.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtip.isPassword = false;
            this.txtip.Location = new System.Drawing.Point(572, 584);
            this.txtip.Margin = new System.Windows.Forms.Padding(6);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(309, 51);
            this.txtip.TabIndex = 11;
            this.txtip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtpath
            // 
            this.txtpath.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtpath.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpath.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtpath.BorderThickness = 3;
            this.txtpath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtpath, BunifuAnimatorNS.DecorationType.None);
            this.txtpath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpath.isPassword = false;
            this.txtpath.Location = new System.Drawing.Point(572, 668);
            this.txtpath.Margin = new System.Windows.Forms.Padding(6);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(309, 51);
            this.txtpath.TabIndex = 12;
            this.txtpath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cdlistas
            // 
            this.cdlistas.BackColor = System.Drawing.Color.Azure;
            this.cdlistas.BorderRadius = 1;
            this.bunifuTransition1.SetDecoration(this.cdlistas, BunifuAnimatorNS.DecorationType.None);
            this.cdlistas.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cdlistas.DisabledColor = System.Drawing.Color.Gray;
            this.cdlistas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cdlistas.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cdlistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdlistas.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cdlistas.FillDropDown = false;
            this.cdlistas.FillIndicator = false;
            this.cdlistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdlistas.ForeColor = System.Drawing.Color.Purple;
            this.cdlistas.FormattingEnabled = true;
            this.cdlistas.Icon = null;
            this.cdlistas.IndicatorColor = System.Drawing.Color.Purple;
            this.cdlistas.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cdlistas.ItemBackColor = System.Drawing.Color.White;
            this.cdlistas.ItemBorderColor = System.Drawing.Color.White;
            this.cdlistas.ItemForeColor = System.Drawing.Color.Purple;
            this.cdlistas.ItemHeight = 26;
            this.cdlistas.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.cdlistas.Location = new System.Drawing.Point(234, 595);
            this.cdlistas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cdlistas.Name = "cdlistas";
            this.cdlistas.Size = new System.Drawing.Size(250, 32);
            this.cdlistas.TabIndex = 13;
            this.cdlistas.Text = null;
            this.cdlistas.SelectedIndexChanged += new System.EventHandler(this.cdlistas_SelectedIndexChanged);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.LightGray;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(18, 94);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(987, 448);
            this.bunifuCustomDataGrid1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(335, 558);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Lista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Location = new System.Drawing.Point(726, 558);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Location = new System.Drawing.Point(699, 641);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ubicacion";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::MasterCheck2._0.Properties.Resources._45390856_1951129024967123_5506682406058328064_n;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(942, 18);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(63, 66);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 18;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1023, 752);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.cdlistas);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3);
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnregresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnregresar;
        private Bunifu.Framework.UI.BunifuImageButton btnexport;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtip;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtpath;
        private Bunifu.UI.WinForms.BunifuDropdown cdlistas;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}