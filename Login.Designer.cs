namespace MasterCheck2._0
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlogin2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncontra2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cbusers2 = new Bunifu.UI.WinForms.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MasterCheck2._0.Properties.Resources._45390856_1951129024967123_5506682406058328064_n;
            this.pictureBox1.Location = new System.Drawing.Point(140, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnlogin2
            // 
            this.btnlogin2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnlogin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnlogin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogin2.BorderRadius = 0;
            this.btnlogin2.ButtonText = "Login";
            this.btnlogin2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin2.DisabledColor = System.Drawing.Color.Gray;
            this.btnlogin2.Enabled = false;
            this.btnlogin2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnlogin2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnlogin2.Iconimage")));
            this.btnlogin2.Iconimage_right = null;
            this.btnlogin2.Iconimage_right_Selected = null;
            this.btnlogin2.Iconimage_Selected = null;
            this.btnlogin2.IconMarginLeft = 0;
            this.btnlogin2.IconMarginRight = 0;
            this.btnlogin2.IconRightVisible = true;
            this.btnlogin2.IconRightZoom = 0D;
            this.btnlogin2.IconVisible = true;
            this.btnlogin2.IconZoom = 90D;
            this.btnlogin2.IsTab = false;
            this.btnlogin2.Location = new System.Drawing.Point(159, 393);
            this.btnlogin2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnlogin2.Name = "btnlogin2";
            this.btnlogin2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnlogin2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnlogin2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlogin2.selected = false;
            this.btnlogin2.Size = new System.Drawing.Size(184, 68);
            this.btnlogin2.TabIndex = 7;
            this.btnlogin2.Text = "Login";
            this.btnlogin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogin2.Textcolor = System.Drawing.Color.White;
            this.btnlogin2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin2.Click += new System.EventHandler(this.btnlogin2_Click);
            // 
            // btncontra2
            // 
            this.btncontra2.BorderColorFocused = System.Drawing.Color.Blue;
            this.btncontra2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncontra2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.btncontra2.BorderThickness = 3;
            this.btncontra2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btncontra2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btncontra2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncontra2.isPassword = true;
            this.btncontra2.Location = new System.Drawing.Point(184, 310);
            this.btncontra2.Margin = new System.Windows.Forms.Padding(6);
            this.btncontra2.Name = "btncontra2";
            this.btncontra2.Size = new System.Drawing.Size(135, 31);
            this.btncontra2.TabIndex = 10;
            this.btncontra2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncontra2.OnValueChanged += new System.EventHandler(this.btncontra2_OnValueChanged);
            // 
            // cbusers2
            // 
            this.cbusers2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbusers2.BorderRadius = 1;
            this.cbusers2.Color = System.Drawing.Color.DarkSlateBlue;
            this.cbusers2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbusers2.DisabledColor = System.Drawing.Color.Gray;
            this.cbusers2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbusers2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cbusers2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbusers2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbusers2.FillDropDown = false;
            this.cbusers2.FillIndicator = false;
            this.cbusers2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbusers2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbusers2.FormattingEnabled = true;
            this.cbusers2.Icon = null;
            this.cbusers2.IndicatorColor = System.Drawing.Color.DarkSlateBlue;
            this.cbusers2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbusers2.ItemBackColor = System.Drawing.Color.White;
            this.cbusers2.ItemBorderColor = System.Drawing.Color.White;
            this.cbusers2.ItemForeColor = System.Drawing.Color.Purple;
            this.cbusers2.ItemHeight = 26;
            this.cbusers2.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.cbusers2.Location = new System.Drawing.Point(184, 250);
            this.cbusers2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbusers2.Name = "cbusers2";
            this.cbusers2.Size = new System.Drawing.Size(148, 32);
            this.cbusers2.TabIndex = 13;
            this.cbusers2.Text = null;
            this.cbusers2.SelectedIndexChanged += new System.EventHandler(this.cbusers2_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(511, 506);
            this.Controls.Add(this.cbusers2);
            this.Controls.Add(this.btncontra2);
            this.Controls.Add(this.btnlogin2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnlogin2;
        private Bunifu.Framework.UI.BunifuMetroTextbox btncontra2;
        private Bunifu.UI.WinForms.BunifuDropdown cbusers2;
    }
}