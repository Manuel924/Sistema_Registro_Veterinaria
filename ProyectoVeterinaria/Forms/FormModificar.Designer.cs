
namespace ProyectoVeterinaria.Forms
{
    partial class FormModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tFecha = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pictboxImagen = new System.Windows.Forms.PictureBox();
            this.cbTam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tTratamiento = new System.Windows.Forms.TextBox();
            this.tEnfermedad = new System.Windows.Forms.TextBox();
            this.tPeso = new System.Windows.Forms.TextBox();
            this.tRaza = new System.Windows.Forms.TextBox();
            this.tNombreD = new System.Windows.Forms.TextBox();
            this.tNombreM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblDuenio = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.ofdSeleccionar = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tID);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tFecha);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictboxImagen);
            this.groupBox1.Controls.Add(this.cbTam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tTratamiento);
            this.groupBox1.Controls.Add(this.tEnfermedad);
            this.groupBox1.Controls.Add(this.tPeso);
            this.groupBox1.Controls.Add(this.tRaza);
            this.groupBox1.Controls.Add(this.tNombreD);
            this.groupBox1.Controls.Add(this.tNombreM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblRaza);
            this.groupBox1.Controls.Add(this.lblDuenio);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tID
            // 
            this.tID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tID.Enabled = false;
            this.tID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.Location = new System.Drawing.Point(200, 33);
            this.tID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(310, 27);
            this.tID.TabIndex = 37;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(142, 41);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 19);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(590, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 19);
            this.label7.TabIndex = 55;
            this.label7.Text = "Seleccione el registro que desee modificar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(517, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 283);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(450, 262);
            this.dataGridView2.TabIndex = 56;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tFecha
            // 
            this.tFecha.Enabled = false;
            this.tFecha.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFecha.Location = new System.Drawing.Point(200, 367);
            this.tFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tFecha.Name = "tFecha";
            this.tFecha.Size = new System.Drawing.Size(237, 27);
            this.tFecha.TabIndex = 54;
            this.tFecha.Text = "Seleccione la fecha de registro";
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(200, 330);
            this.fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(304, 27);
            this.fecha.TabIndex = 53;
            this.fecha.Visible = false;
            this.fecha.ValueChanged += new System.EventHandler(this.fecha_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "Fecha de registro:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictboxImagen
            // 
            this.pictboxImagen.Location = new System.Drawing.Point(517, 381);
            this.pictboxImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictboxImagen.Name = "pictboxImagen";
            this.pictboxImagen.Size = new System.Drawing.Size(456, 133);
            this.pictboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictboxImagen.TabIndex = 64;
            this.pictboxImagen.TabStop = false;
            // 
            // cbTam
            // 
            this.cbTam.Enabled = false;
            this.cbTam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTam.Items.AddRange(new object[] {
            "CHICO",
            "MEDIANO",
            "GRANDE"});
            this.cbTam.Location = new System.Drawing.Point(200, 219);
            this.cbTam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTam.Name = "cbTam";
            this.cbTam.Size = new System.Drawing.Size(309, 27);
            this.cbTam.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(616, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "Cargue la nueva imagen de su mascota";
            // 
            // tTratamiento
            // 
            this.tTratamiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tTratamiento.Enabled = false;
            this.tTratamiento.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTratamiento.Location = new System.Drawing.Point(200, 293);
            this.tTratamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tTratamiento.MaxLength = 100;
            this.tTratamiento.Name = "tTratamiento";
            this.tTratamiento.Size = new System.Drawing.Size(309, 27);
            this.tTratamiento.TabIndex = 51;
            this.tTratamiento.Enter += new System.EventHandler(this.tTratamiento_Enter);
            // 
            // tEnfermedad
            // 
            this.tEnfermedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tEnfermedad.Enabled = false;
            this.tEnfermedad.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEnfermedad.Location = new System.Drawing.Point(200, 256);
            this.tEnfermedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tEnfermedad.MaxLength = 100;
            this.tEnfermedad.Name = "tEnfermedad";
            this.tEnfermedad.Size = new System.Drawing.Size(309, 27);
            this.tEnfermedad.TabIndex = 49;
            this.tEnfermedad.Enter += new System.EventHandler(this.tEnfermedad_Enter);
            this.tEnfermedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tEnfermedad_KeyPress);
            // 
            // tPeso
            // 
            this.tPeso.Enabled = false;
            this.tPeso.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPeso.Location = new System.Drawing.Point(200, 184);
            this.tPeso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPeso.MaxLength = 10;
            this.tPeso.Name = "tPeso";
            this.tPeso.Size = new System.Drawing.Size(309, 27);
            this.tPeso.TabIndex = 45;
            this.tPeso.Text = "Ingrese el peso en KG";
            this.tPeso.Enter += new System.EventHandler(this.tPeso_Enter);
            this.tPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPeso_KeyPress);
            // 
            // tRaza
            // 
            this.tRaza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tRaza.Enabled = false;
            this.tRaza.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRaza.Location = new System.Drawing.Point(200, 148);
            this.tRaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tRaza.MaxLength = 20;
            this.tRaza.Name = "tRaza";
            this.tRaza.Size = new System.Drawing.Size(309, 27);
            this.tRaza.TabIndex = 43;
            this.tRaza.Enter += new System.EventHandler(this.tRaza_Enter);
            this.tRaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tRaza_KeyPress);
            // 
            // tNombreD
            // 
            this.tNombreD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tNombreD.Enabled = false;
            this.tNombreD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreD.Location = new System.Drawing.Point(200, 111);
            this.tNombreD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tNombreD.MaxLength = 50;
            this.tNombreD.Name = "tNombreD";
            this.tNombreD.Size = new System.Drawing.Size(309, 27);
            this.tNombreD.TabIndex = 41;
            this.tNombreD.Enter += new System.EventHandler(this.tNombreD_Enter);
            this.tNombreD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNombreD_KeyPress);
            // 
            // tNombreM
            // 
            this.tNombreM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tNombreM.Enabled = false;
            this.tNombreM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreM.Location = new System.Drawing.Point(200, 70);
            this.tNombreM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tNombreM.MaxLength = 20;
            this.tNombreM.Name = "tNombreM";
            this.tNombreM.Size = new System.Drawing.Size(309, 27);
            this.tNombreM.TabIndex = 39;
            this.tNombreM.Enter += new System.EventHandler(this.tNombreM_Enter);
            this.tNombreM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNombreM_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tratamiento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Enfermedad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tamaño:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Peso:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaza.Location = new System.Drawing.Point(31, 156);
            this.lblRaza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(142, 19);
            this.lblRaza.TabIndex = 42;
            this.lblRaza.Text = "Raza de la mascota:";
            this.lblRaza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuenio
            // 
            this.lblDuenio.AutoSize = true;
            this.lblDuenio.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuenio.Location = new System.Drawing.Point(33, 114);
            this.lblDuenio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuenio.Name = "lblDuenio";
            this.lblDuenio.Size = new System.Drawing.Size(140, 19);
            this.lblDuenio.TabIndex = 40;
            this.lblDuenio.Text = "Nombre del dueño:";
            this.lblDuenio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(7, 78);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(166, 19);
            this.lblNom.TabIndex = 38;
            this.lblNom.Text = "Nombre de la mascota:";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Location = new System.Drawing.Point(23, 542);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(202, 30);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "GUARDAR CAMBIOS";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(662, 542);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(202, 30);
            this.btnSeleccionar.TabIndex = 58;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // ofdSeleccionar
            // 
            this.ofdSeleccionar.FileName = "openFileDialog1";
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 546);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeleccionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificar";
            this.Text = "MODIFICAR";
            this.Load += new System.EventHandler(this.FormModificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictboxImagen;
        private System.Windows.Forms.ComboBox cbTam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox tTratamiento;
        private System.Windows.Forms.TextBox tEnfermedad;
        private System.Windows.Forms.TextBox tPeso;
        private System.Windows.Forms.TextBox tRaza;
        private System.Windows.Forms.TextBox tNombreD;
        private System.Windows.Forms.TextBox tNombreM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblDuenio;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.OpenFileDialog ofdSeleccionar;
        private System.Windows.Forms.TextBox tFecha;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Label lblID;
    }
}