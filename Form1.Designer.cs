namespace MasterCheck2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblid = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblpuesto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Regresar = new System.Windows.Forms.Label();
            this.btnreturn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnrefrescar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtedad2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtapellido2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtnombre2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtid2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.cbPuesto2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cbDepartamento2 = new Bunifu.UI.WinForms.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(81, 51);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 20);
            this.lblid.TabIndex = 8;
            this.lblid.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(42, 158);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(60, 269);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(47, 20);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Edad";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(-5, 317);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(112, 20);
            this.lblDepartamento.TabIndex = 14;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblpuesto
            // 
            this.lblpuesto.AutoSize = true;
            this.lblpuesto.Location = new System.Drawing.Point(48, 207);
            this.lblpuesto.Name = "lblpuesto";
            this.lblpuesto.Size = new System.Drawing.Size(59, 20);
            this.lblpuesto.TabIndex = 19;
            this.lblpuesto.Text = "Puesto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(373, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(983, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Guardar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Refrescar";
            // 
            // Regresar
            // 
            this.Regresar.AutoSize = true;
            this.Regresar.Location = new System.Drawing.Point(122, 449);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(75, 20);
            this.Regresar.TabIndex = 26;
            this.Regresar.Text = "Regresar";
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
            this.btnreturn.Location = new System.Drawing.Point(28, 417);
            this.btnreturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnreturn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnreturn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnreturn.selected = false;
            this.btnreturn.Size = new System.Drawing.Size(87, 92);
            this.btnreturn.TabIndex = 27;
            this.btnreturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreturn.Textcolor = System.Drawing.Color.White;
            this.btnreturn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnrefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnrefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrefrescar.BorderRadius = 0;
            this.btnrefrescar.ButtonText = "";
            this.btnrefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefrescar.DisabledColor = System.Drawing.Color.Gray;
            this.btnrefrescar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnrefrescar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnrefrescar.Iconimage")));
            this.btnrefrescar.Iconimage_right = null;
            this.btnrefrescar.Iconimage_right_Selected = null;
            this.btnrefrescar.Iconimage_Selected = null;
            this.btnrefrescar.IconMarginLeft = 0;
            this.btnrefrescar.IconMarginRight = 0;
            this.btnrefrescar.IconRightVisible = true;
            this.btnrefrescar.IconRightZoom = 0D;
            this.btnrefrescar.IconVisible = true;
            this.btnrefrescar.IconZoom = 90D;
            this.btnrefrescar.IsTab = false;
            this.btnrefrescar.Location = new System.Drawing.Point(565, 345);
            this.btnrefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnrefrescar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnrefrescar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnrefrescar.selected = false;
            this.btnrefrescar.Size = new System.Drawing.Size(79, 80);
            this.btnrefrescar.TabIndex = 28;
            this.btnrefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefrescar.Textcolor = System.Drawing.Color.White;
            this.btnrefrescar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.BorderRadius = 0;
            this.btnguardar.ButtonText = "";
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnguardar.Enabled = false;
            this.btnguardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnguardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnguardar.Iconimage")));
            this.btnguardar.Iconimage_right = null;
            this.btnguardar.Iconimage_right_Selected = null;
            this.btnguardar.Iconimage_Selected = null;
            this.btnguardar.IconMarginLeft = 0;
            this.btnguardar.IconMarginRight = 0;
            this.btnguardar.IconRightVisible = true;
            this.btnguardar.IconRightZoom = 0D;
            this.btnguardar.IconVisible = true;
            this.btnguardar.IconZoom = 90D;
            this.btnguardar.IsTab = false;
            this.btnguardar.Location = new System.Drawing.Point(1058, 412);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnguardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardar.selected = false;
            this.btnguardar.Size = new System.Drawing.Size(99, 97);
            this.btnguardar.TabIndex = 29;
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Textcolor = System.Drawing.Color.White;
            this.btnguardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(565, 36);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 28;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(593, 301);
            this.bunifuCustomDataGrid1.TabIndex = 30;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(420, 270);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(81, 77);
            this.bunifuFlatButton1.TabIndex = 31;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
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
            this.txtedad2.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedad2.DefaultText = "";
            this.txtedad2.Enabled = false;
            this.txtedad2.FillColor = System.Drawing.Color.White;
            this.txtedad2.HideSelection = true;
            this.txtedad2.IconLeft = null;
            this.txtedad2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtedad2.IconPadding = 10;
            this.txtedad2.IconRight = null;
            this.txtedad2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtedad2.Location = new System.Drawing.Point(118, 254);
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
            this.txtedad2.Size = new System.Drawing.Size(100, 35);
            this.txtedad2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtedad2.TabIndex = 32;
            this.txtedad2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtedad2.TextMarginLeft = 5;
            this.txtedad2.TextPlaceholder = "";
            this.txtedad2.UseSystemPasswordChar = false;
            this.txtedad2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad2_KeyPress);
            // 
            // txtapellido2
            // 
            this.txtapellido2.AcceptsReturn = false;
            this.txtapellido2.AcceptsTab = false;
            this.txtapellido2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtapellido2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtapellido2.BackColor = System.Drawing.Color.Transparent;
            this.txtapellido2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtapellido2.BackgroundImage")));
            this.txtapellido2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtapellido2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtapellido2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtapellido2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtapellido2.BorderRadius = 1;
            this.txtapellido2.BorderThickness = 2;
            this.txtapellido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtapellido2.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido2.DefaultText = "";
            this.txtapellido2.Enabled = false;
            this.txtapellido2.FillColor = System.Drawing.Color.White;
            this.txtapellido2.HideSelection = true;
            this.txtapellido2.IconLeft = null;
            this.txtapellido2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtapellido2.IconPadding = 10;
            this.txtapellido2.IconRight = null;
            this.txtapellido2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtapellido2.Location = new System.Drawing.Point(116, 143);
            this.txtapellido2.MaxLength = 32767;
            this.txtapellido2.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtapellido2.Modified = false;
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.PasswordChar = '\0';
            this.txtapellido2.ReadOnly = false;
            this.txtapellido2.SelectedText = "";
            this.txtapellido2.SelectionLength = 0;
            this.txtapellido2.SelectionStart = 0;
            this.txtapellido2.ShortcutsEnabled = true;
            this.txtapellido2.Size = new System.Drawing.Size(102, 35);
            this.txtapellido2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtapellido2.TabIndex = 33;
            this.txtapellido2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtapellido2.TextMarginLeft = 5;
            this.txtapellido2.TextPlaceholder = "";
            this.txtapellido2.UseSystemPasswordChar = false;
            this.txtapellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido2_KeyPress);
            // 
            // txtnombre2
            // 
            this.txtnombre2.AcceptsReturn = false;
            this.txtnombre2.AcceptsTab = false;
            this.txtnombre2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtnombre2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtnombre2.BackColor = System.Drawing.Color.Transparent;
            this.txtnombre2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtnombre2.BackgroundImage")));
            this.txtnombre2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtnombre2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtnombre2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtnombre2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtnombre2.BorderRadius = 1;
            this.txtnombre2.BorderThickness = 2;
            this.txtnombre2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnombre2.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre2.DefaultText = "";
            this.txtnombre2.Enabled = false;
            this.txtnombre2.FillColor = System.Drawing.Color.White;
            this.txtnombre2.HideSelection = true;
            this.txtnombre2.IconLeft = null;
            this.txtnombre2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtnombre2.IconPadding = 10;
            this.txtnombre2.IconRight = null;
            this.txtnombre2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtnombre2.Location = new System.Drawing.Point(116, 85);
            this.txtnombre2.MaxLength = 32767;
            this.txtnombre2.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtnombre2.Modified = false;
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.PasswordChar = '\0';
            this.txtnombre2.ReadOnly = false;
            this.txtnombre2.SelectedText = "";
            this.txtnombre2.SelectionLength = 0;
            this.txtnombre2.SelectionStart = 0;
            this.txtnombre2.ShortcutsEnabled = true;
            this.txtnombre2.Size = new System.Drawing.Size(100, 35);
            this.txtnombre2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtnombre2.TabIndex = 34;
            this.txtnombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnombre2.TextMarginLeft = 5;
            this.txtnombre2.TextPlaceholder = "";
            this.txtnombre2.UseSystemPasswordChar = false;
            this.txtnombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre2_KeyPress);
            // 
            // txtid2
            // 
            this.txtid2.AcceptsReturn = false;
            this.txtid2.AcceptsTab = false;
            this.txtid2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtid2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtid2.BackColor = System.Drawing.Color.Transparent;
            this.txtid2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtid2.BackgroundImage")));
            this.txtid2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtid2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtid2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtid2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtid2.BorderRadius = 1;
            this.txtid2.BorderThickness = 2;
            this.txtid2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtid2.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid2.DefaultText = "";
            this.txtid2.FillColor = System.Drawing.Color.White;
            this.txtid2.HideSelection = true;
            this.txtid2.IconLeft = null;
            this.txtid2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtid2.IconPadding = 10;
            this.txtid2.IconRight = null;
            this.txtid2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtid2.Location = new System.Drawing.Point(116, 36);
            this.txtid2.MaxLength = 32767;
            this.txtid2.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtid2.Modified = false;
            this.txtid2.Name = "txtid2";
            this.txtid2.PasswordChar = '\0';
            this.txtid2.ReadOnly = false;
            this.txtid2.SelectedText = "";
            this.txtid2.SelectionLength = 0;
            this.txtid2.SelectionStart = 0;
            this.txtid2.ShortcutsEnabled = true;
            this.txtid2.Size = new System.Drawing.Size(200, 35);
            this.txtid2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtid2.TabIndex = 35;
            this.txtid2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtid2.TextMarginLeft = 5;
            this.txtid2.TextPlaceholder = "";
            this.txtid2.UseSystemPasswordChar = false;
            this.txtid2.TextChange += new System.EventHandler(this.txtid2_TextChange);
            this.txtid2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid2_KeyPress);
            // 
            // cbPuesto2
            // 
            this.cbPuesto2.BackColor = System.Drawing.SystemColors.Control;
            this.cbPuesto2.BorderRadius = 1;
            this.cbPuesto2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbPuesto2.DisabledColor = System.Drawing.Color.Gray;
            this.cbPuesto2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPuesto2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cbPuesto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuesto2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbPuesto2.FillDropDown = false;
            this.cbPuesto2.FillIndicator = false;
            this.cbPuesto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPuesto2.ForeColor = System.Drawing.Color.Purple;
            this.cbPuesto2.FormattingEnabled = true;
            this.cbPuesto2.Icon = null;
            this.cbPuesto2.IndicatorColor = System.Drawing.Color.Purple;
            this.cbPuesto2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbPuesto2.ItemBackColor = System.Drawing.Color.White;
            this.cbPuesto2.ItemBorderColor = System.Drawing.Color.White;
            this.cbPuesto2.ItemForeColor = System.Drawing.Color.Purple;
            this.cbPuesto2.ItemHeight = 26;
            this.cbPuesto2.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.cbPuesto2.Location = new System.Drawing.Point(116, 195);
            this.cbPuesto2.Name = "cbPuesto2";
            this.cbPuesto2.Size = new System.Drawing.Size(102, 32);
            this.cbPuesto2.TabIndex = 36;
            // 
            // cbDepartamento2
            // 
            this.cbDepartamento2.BackColor = System.Drawing.SystemColors.Control;
            this.cbDepartamento2.BorderRadius = 1;
            this.cbDepartamento2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbDepartamento2.DisabledColor = System.Drawing.Color.Gray;
            this.cbDepartamento2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDepartamento2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cbDepartamento2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbDepartamento2.FillDropDown = false;
            this.cbDepartamento2.FillIndicator = false;
            this.cbDepartamento2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDepartamento2.ForeColor = System.Drawing.Color.Purple;
            this.cbDepartamento2.FormattingEnabled = true;
            this.cbDepartamento2.Icon = null;
            this.cbDepartamento2.IndicatorColor = System.Drawing.Color.Purple;
            this.cbDepartamento2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbDepartamento2.ItemBackColor = System.Drawing.Color.White;
            this.cbDepartamento2.ItemBorderColor = System.Drawing.Color.White;
            this.cbDepartamento2.ItemForeColor = System.Drawing.Color.Purple;
            this.cbDepartamento2.ItemHeight = 26;
            this.cbDepartamento2.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.cbDepartamento2.Location = new System.Drawing.Point(118, 314);
            this.cbDepartamento2.Name = "cbDepartamento2";
            this.cbDepartamento2.Size = new System.Drawing.Size(217, 32);
            this.cbDepartamento2.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1170, 535);
            this.Controls.Add(this.cbDepartamento2);
            this.Controls.Add(this.cbPuesto2);
            this.Controls.Add(this.txtid2);
            this.Controls.Add(this.txtnombre2);
            this.Controls.Add(this.txtapellido2);
            this.Controls.Add(this.txtedad2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblpuesto);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblpuesto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Regresar;
        private Bunifu.Framework.UI.BunifuFlatButton btnreturn;
        private Bunifu.Framework.UI.BunifuFlatButton btnrefrescar;
        private Bunifu.Framework.UI.BunifuFlatButton btnguardar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtedad2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtapellido2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtnombre2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtid2;
        private Bunifu.UI.WinForms.BunifuDropdown cbPuesto2;
        private Bunifu.UI.WinForms.BunifuDropdown cbDepartamento2;
    }
}

