namespace MasterCheck2._0
{
    partial class Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblApellido = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnreturn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnErase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtApellido2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtNombre2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtedad2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.cbid2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cbpuesto2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cbdepartamento2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.entrada = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Salida = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Puesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Departamento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Location = new System.Drawing.Point(532, 9);
            this.lbltiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(35, 13);
            this.lbltiempo.TabIndex = 10;
            this.lbltiempo.Text = "label5";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(532, 31);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(35, 13);
            this.lbltime.TabIndex = 15;
            this.lbltime.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(164, 18);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 18;
            this.lblApellido.Text = "Apellido";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(176, 102);
            this.lbledad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(32, 13);
            this.lbledad.TabIndex = 21;
            this.lbledad.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Guardar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Eliminar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 103);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Regresar";
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
            this.btnreturn.Location = new System.Drawing.Point(12, 240);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnreturn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnreturn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnreturn.selected = false;
            this.btnreturn.Size = new System.Drawing.Size(63, 56);
            this.btnreturn.TabIndex = 28;
            this.btnreturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreturn.Textcolor = System.Drawing.Color.White;
            this.btnreturn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnsave
            // 
            this.btnsave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.BorderRadius = 0;
            this.btnsave.ButtonText = "";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.DisabledColor = System.Drawing.Color.Gray;
            this.btnsave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsave.Iconimage")));
            this.btnsave.Iconimage_right = null;
            this.btnsave.Iconimage_right_Selected = null;
            this.btnsave.Iconimage_Selected = null;
            this.btnsave.IconMarginLeft = 0;
            this.btnsave.IconMarginRight = 0;
            this.btnsave.IconRightVisible = true;
            this.btnsave.IconRightZoom = 0D;
            this.btnsave.IconVisible = true;
            this.btnsave.IconZoom = 90D;
            this.btnsave.IsTab = false;
            this.btnsave.Location = new System.Drawing.Point(217, 239);
            this.btnsave.Name = "btnsave";
            this.btnsave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnsave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnsave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsave.selected = false;
            this.btnsave.Size = new System.Drawing.Size(57, 57);
            this.btnsave.TabIndex = 29;
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsave.Textcolor = System.Drawing.Color.White;
            this.btnsave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnErase
            // 
            this.btnErase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnErase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnErase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnErase.BorderRadius = 0;
            this.btnErase.ButtonText = "";
            this.btnErase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnErase.DisabledColor = System.Drawing.Color.Gray;
            this.btnErase.Iconcolor = System.Drawing.Color.Transparent;
            this.btnErase.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnErase.Iconimage")));
            this.btnErase.Iconimage_right = null;
            this.btnErase.Iconimage_right_Selected = null;
            this.btnErase.Iconimage_Selected = null;
            this.btnErase.IconMarginLeft = 0;
            this.btnErase.IconMarginRight = 0;
            this.btnErase.IconRightVisible = true;
            this.btnErase.IconRightZoom = 0D;
            this.btnErase.IconVisible = true;
            this.btnErase.IconZoom = 90D;
            this.btnErase.IsTab = false;
            this.btnErase.Location = new System.Drawing.Point(283, 238);
            this.btnErase.Name = "btnErase";
            this.btnErase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnErase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnErase.OnHoverTextColor = System.Drawing.Color.White;
            this.btnErase.selected = false;
            this.btnErase.Size = new System.Drawing.Size(58, 58);
            this.btnErase.TabIndex = 30;
            this.btnErase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErase.Textcolor = System.Drawing.Color.White;
            this.btnErase.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // txtApellido2
            // 
            this.txtApellido2.AcceptsReturn = false;
            this.txtApellido2.AcceptsTab = false;
            this.txtApellido2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtApellido2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtApellido2.BackColor = System.Drawing.Color.Transparent;
            this.txtApellido2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtApellido2.BackgroundImage")));
            this.txtApellido2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtApellido2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtApellido2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtApellido2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtApellido2.BorderRadius = 1;
            this.txtApellido2.BorderThickness = 2;
            this.txtApellido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtApellido2.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.DefaultText = "";
            this.txtApellido2.FillColor = System.Drawing.Color.White;
            this.txtApellido2.HideSelection = true;
            this.txtApellido2.IconLeft = null;
            this.txtApellido2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtApellido2.IconPadding = 10;
            this.txtApellido2.IconRight = null;
            this.txtApellido2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtApellido2.Location = new System.Drawing.Point(220, 18);
            this.txtApellido2.MaxLength = 32767;
            this.txtApellido2.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtApellido2.Modified = false;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.PasswordChar = '\0';
            this.txtApellido2.ReadOnly = false;
            this.txtApellido2.SelectedText = "";
            this.txtApellido2.SelectionLength = 0;
            this.txtApellido2.SelectionStart = 0;
            this.txtApellido2.ShortcutsEnabled = true;
            this.txtApellido2.Size = new System.Drawing.Size(100, 35);
            this.txtApellido2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtApellido2.TabIndex = 31;
            this.txtApellido2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellido2.TextMarginLeft = 5;
            this.txtApellido2.TextPlaceholder = "";
            this.txtApellido2.UseSystemPasswordChar = false;
            // 
            // txtNombre2
            // 
            this.txtNombre2.AcceptsReturn = false;
            this.txtNombre2.AcceptsTab = false;
            this.txtNombre2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombre2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombre2.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombre2.BackgroundImage")));
            this.txtNombre2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtNombre2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtNombre2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtNombre2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtNombre2.BorderRadius = 1;
            this.txtNombre2.BorderThickness = 2;
            this.txtNombre2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre2.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre2.DefaultText = "";
            this.txtNombre2.FillColor = System.Drawing.Color.White;
            this.txtNombre2.HideSelection = true;
            this.txtNombre2.IconLeft = null;
            this.txtNombre2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtNombre2.IconPadding = 10;
            this.txtNombre2.IconRight = null;
            this.txtNombre2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtNombre2.Location = new System.Drawing.Point(217, 59);
            this.txtNombre2.MaxLength = 32767;
            this.txtNombre2.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtNombre2.Modified = false;
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.PasswordChar = '\0';
            this.txtNombre2.ReadOnly = false;
            this.txtNombre2.SelectedText = "";
            this.txtNombre2.SelectionLength = 0;
            this.txtNombre2.SelectionStart = 0;
            this.txtNombre2.ShortcutsEnabled = true;
            this.txtNombre2.Size = new System.Drawing.Size(103, 35);
            this.txtNombre2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtNombre2.TabIndex = 32;
            this.txtNombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre2.TextMarginLeft = 5;
            this.txtNombre2.TextPlaceholder = "";
            this.txtNombre2.UseSystemPasswordChar = false;
            // 
            // txtedad2
            // 
            this.txtedad2.AcceptsReturn = false;
            this.txtedad2.AcceptsTab = false;
            this.txtedad2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtedad2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtedad2.BackColor = System.Drawing.Color.Transparent;
            this.txtedad2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtedad2.BackgroundImage")));
            this.txtedad2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtedad2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtedad2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtedad2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtedad2.BorderRadius = 1;
            this.txtedad2.BorderThickness = 2;
            this.txtedad2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtedad2.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedad2.DefaultText = "";
            this.txtedad2.FillColor = System.Drawing.Color.White;
            this.txtedad2.HideSelection = true;
            this.txtedad2.IconLeft = null;
            this.txtedad2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtedad2.IconPadding = 10;
            this.txtedad2.IconRight = null;
            this.txtedad2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtedad2.Location = new System.Drawing.Point(217, 102);
            this.txtedad2.MaxLength = 32767;
            this.txtedad2.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtedad2.Modified = false;
            this.txtedad2.Name = "txtedad2";
            this.txtedad2.PasswordChar = '\0';
            this.txtedad2.ReadOnly = false;
            this.txtedad2.SelectedText = "";
            this.txtedad2.SelectionLength = 0;
            this.txtedad2.SelectionStart = 0;
            this.txtedad2.ShortcutsEnabled = true;
            this.txtedad2.Size = new System.Drawing.Size(103, 35);
            this.txtedad2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtedad2.TabIndex = 33;
            this.txtedad2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtedad2.TextMarginLeft = 5;
            this.txtedad2.TextPlaceholder = "";
            this.txtedad2.UseSystemPasswordChar = false;
            // 
            // cbid2
            // 
            this.cbid2.BackColor = System.Drawing.Color.DodgerBlue;
            this.cbid2.BorderRadius = 1;
            this.cbid2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbid2.DisabledColor = System.Drawing.Color.Gray;
            this.cbid2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbid2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cbid2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbid2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbid2.FillDropDown = false;
            this.cbid2.FillIndicator = false;
            this.cbid2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbid2.ForeColor = System.Drawing.Color.Purple;
            this.cbid2.FormattingEnabled = true;
            this.cbid2.Icon = null;
            this.cbid2.IndicatorColor = System.Drawing.Color.Purple;
            this.cbid2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbid2.ItemBackColor = System.Drawing.Color.White;
            this.cbid2.ItemBorderColor = System.Drawing.Color.White;
            this.cbid2.ItemForeColor = System.Drawing.Color.Purple;
            this.cbid2.ItemHeight = 26;
            this.cbid2.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.cbid2.Location = new System.Drawing.Point(49, 143);
            this.cbid2.Name = "cbid2";
            this.cbid2.Size = new System.Drawing.Size(50, 32);
            this.cbid2.TabIndex = 34;
            this.cbid2.SelectedIndexChanged += new System.EventHandler(this.cbid2_SelectedIndexChanged);
            this.cbid2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbid2_KeyPress);
            // 
            // cbpuesto2
            // 
            this.cbpuesto2.BackColor = System.Drawing.Color.DodgerBlue;
            this.cbpuesto2.BorderRadius = 1;
            this.cbpuesto2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbpuesto2.DisabledColor = System.Drawing.Color.Gray;
            this.cbpuesto2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbpuesto2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cbpuesto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpuesto2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbpuesto2.FillDropDown = false;
            this.cbpuesto2.FillIndicator = false;
            this.cbpuesto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbpuesto2.ForeColor = System.Drawing.Color.Purple;
            this.cbpuesto2.FormattingEnabled = true;
            this.cbpuesto2.Icon = null;
            this.cbpuesto2.IndicatorColor = System.Drawing.Color.Purple;
            this.cbpuesto2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbpuesto2.ItemBackColor = System.Drawing.Color.White;
            this.cbpuesto2.ItemBorderColor = System.Drawing.Color.White;
            this.cbpuesto2.ItemForeColor = System.Drawing.Color.Purple;
            this.cbpuesto2.ItemHeight = 26;
            this.cbpuesto2.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.cbpuesto2.Location = new System.Drawing.Point(220, 143);
            this.cbpuesto2.Name = "cbpuesto2";
            this.cbpuesto2.Size = new System.Drawing.Size(122, 32);
            this.cbpuesto2.TabIndex = 35;
            // 
            // cbdepartamento2
            // 
            this.cbdepartamento2.BackColor = System.Drawing.Color.DodgerBlue;
            this.cbdepartamento2.BorderRadius = 1;
            this.cbdepartamento2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbdepartamento2.DisabledColor = System.Drawing.Color.Gray;
            this.cbdepartamento2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbdepartamento2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cbdepartamento2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdepartamento2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbdepartamento2.FillDropDown = false;
            this.cbdepartamento2.FillIndicator = false;
            this.cbdepartamento2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbdepartamento2.ForeColor = System.Drawing.Color.Purple;
            this.cbdepartamento2.FormattingEnabled = true;
            this.cbdepartamento2.Icon = null;
            this.cbdepartamento2.IndicatorColor = System.Drawing.Color.Purple;
            this.cbdepartamento2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbdepartamento2.ItemBackColor = System.Drawing.Color.White;
            this.cbdepartamento2.ItemBorderColor = System.Drawing.Color.White;
            this.cbdepartamento2.ItemForeColor = System.Drawing.Color.Purple;
            this.cbdepartamento2.ItemHeight = 26;
            this.cbdepartamento2.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.cbdepartamento2.Location = new System.Drawing.Point(220, 185);
            this.cbdepartamento2.Name = "cbdepartamento2";
            this.cbdepartamento2.Size = new System.Drawing.Size(122, 32);
            this.cbdepartamento2.TabIndex = 36;
            // 
            // entrada
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.entrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.entrada.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.entrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.entrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.entrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entrada.DoubleBuffered = true;
            this.entrada.EnableHeadersVisualStyles = false;
            this.entrada.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.entrada.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.entrada.Location = new System.Drawing.Point(374, 52);
            this.entrada.Name = "entrada";
            this.entrada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.entrada.Size = new System.Drawing.Size(178, 165);
            this.entrada.TabIndex = 37;
            // 
            // Salida
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Salida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Salida.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Salida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Salida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Salida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Salida.DoubleBuffered = true;
            this.Salida.EnableHeadersVisualStyles = false;
            this.Salida.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.Salida.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.Salida.Location = new System.Drawing.Point(558, 52);
            this.Salida.Name = "Salida";
            this.Salida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Salida.Size = new System.Drawing.Size(185, 165);
            this.Salida.TabIndex = 38;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(797, 330);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.cbdepartamento2);
            this.Controls.Add(this.cbpuesto2);
            this.Controls.Add(this.cbid2);
            this.Controls.Add(this.txtedad2);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btnreturn;
        private Bunifu.Framework.UI.BunifuFlatButton btnsave;
        private Bunifu.Framework.UI.BunifuFlatButton btnErase;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtApellido2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtNombre2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtedad2;
        private Bunifu.UI.WinForms.BunifuDropdown cbid2;
        private Bunifu.UI.WinForms.BunifuDropdown cbpuesto2;
        private Bunifu.UI.WinForms.BunifuDropdown cbdepartamento2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid entrada;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Salida;
    }
}