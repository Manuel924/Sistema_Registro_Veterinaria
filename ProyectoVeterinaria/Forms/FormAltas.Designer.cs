
namespace ProyectoVeterinaria.Forms
{
    partial class FormAltas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltas));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbTamanio = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtNombreD = new System.Windows.Forms.TextBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btGenerarID = new System.Windows.Forms.Button();
            this.DTPfecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblDuenio = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.ofdSeleccionar = new System.Windows.Forms.OpenFileDialog();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mostrarRFC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(545, 382);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(202, 30);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbTamanio
            // 
            this.cbTamanio.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTamanio.Items.AddRange(new object[] {
            "CHICO",
            "MEDIANO",
            "GRANDE"});
            this.cbTamanio.Location = new System.Drawing.Point(190, 231);
            this.cbTamanio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTamanio.Name = "cbTamanio";
            this.cbTamanio.Size = new System.Drawing.Size(304, 27);
            this.cbTamanio.TabIndex = 22;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(190, 390);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(237, 27);
            this.txtFecha.TabIndex = 29;
            this.txtFecha.Text = "Seleccione la fecha de registro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cargue una imagen de su mascota";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.DimGray;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(545, 341);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(202, 30);
            this.btnSeleccionar.TabIndex = 30;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTratamiento.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTratamiento.Location = new System.Drawing.Point(190, 305);
            this.txtTratamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTratamiento.MaxLength = 100;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(304, 27);
            this.txtTratamiento.TabIndex = 26;
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnfermedad.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnfermedad.Location = new System.Drawing.Point(190, 268);
            this.txtEnfermedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnfermedad.MaxLength = 100;
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(304, 27);
            this.txtEnfermedad.TabIndex = 24;
            this.txtEnfermedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnfermedad_KeyPress);
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(190, 196);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeso.MaxLength = 10;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(304, 27);
            this.txtPeso.TabIndex = 20;
            this.txtPeso.Text = "Ingrese el peso en KG";
            this.txtPeso.Enter += new System.EventHandler(this.txtPeso_Enter);
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtRaza
            // 
            this.txtRaza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRaza.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaza.Location = new System.Drawing.Point(190, 160);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRaza.MaxLength = 20;
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(304, 27);
            this.txtRaza.TabIndex = 18;
            this.txtRaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRaza_KeyPress);
            // 
            // txtNombreD
            // 
            this.txtNombreD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreD.Location = new System.Drawing.Point(190, 123);
            this.txtNombreD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreD.MaxLength = 50;
            this.txtNombreD.Name = "txtNombreD";
            this.txtNombreD.Size = new System.Drawing.Size(304, 27);
            this.txtNombreD.TabIndex = 16;
            this.txtNombreD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreD_KeyPress);
            // 
            // txtNombreM
            // 
            this.txtNombreM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreM.Location = new System.Drawing.Point(190, 82);
            this.txtNombreM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreM.MaxLength = 20;
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(304, 27);
            this.txtNombreM.TabIndex = 14;
            this.txtNombreM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreM_KeyPress);
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(227, 15);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(267, 27);
            this.txtID.TabIndex = 12;
            this.txtID.Visible = false;
            // 
            // btGenerarID
            // 
            this.btGenerarID.BackColor = System.Drawing.Color.DimGray;
            this.btGenerarID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGenerarID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerarID.Location = new System.Drawing.Point(12, 11);
            this.btGenerarID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGenerarID.Name = "btGenerarID";
            this.btGenerarID.Size = new System.Drawing.Size(120, 27);
            this.btGenerarID.TabIndex = 10;
            this.btGenerarID.Text = "GENERAR ID";
            this.btGenerarID.UseVisualStyleBackColor = false;
            this.btGenerarID.Click += new System.EventHandler(this.btGenerarID_Click);
            // 
            // DTPfecha
            // 
            this.DTPfecha.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPfecha.Location = new System.Drawing.Point(190, 342);
            this.DTPfecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTPfecha.Name = "DTPfecha";
            this.DTPfecha.Size = new System.Drawing.Size(304, 27);
            this.DTPfecha.TabIndex = 28;
            this.DTPfecha.ValueChanged += new System.EventHandler(this.DTPfecha_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fecha de registro:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tratamiento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Enfermedad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tamaño:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Peso:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaza.Location = new System.Drawing.Point(40, 168);
            this.lblRaza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(142, 19);
            this.lblRaza.TabIndex = 17;
            this.lblRaza.Text = "Raza de la mascota:";
            this.lblRaza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuenio
            // 
            this.lblDuenio.AutoSize = true;
            this.lblDuenio.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuenio.Location = new System.Drawing.Point(42, 126);
            this.lblDuenio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuenio.Name = "lblDuenio";
            this.lblDuenio.Size = new System.Drawing.Size(140, 19);
            this.lblDuenio.TabIndex = 15;
            this.lblDuenio.Text = "Nombre del dueño:";
            this.lblDuenio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(16, 90);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(166, 19);
            this.lblNom.TabIndex = 13;
            this.lblNom.Text = "Nombre de la mascota:";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(151, 19);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 19);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID:";
            // 
            // ofdSeleccionar
            // 
            this.ofdSeleccionar.FileName = "openFileDialog1";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(502, 39);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(259, 292);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 43;
            this.pbImagen.TabStop = false;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(12, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 26);
            this.label13.TabIndex = 46;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(188, 47);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 26);
            this.progressBar1.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(134, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 19);
            this.label11.TabIndex = 44;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mostrarRFC
            // 
            this.mostrarRFC.AutoSize = true;
            this.mostrarRFC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarRFC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mostrarRFC.Location = new System.Drawing.Point(87, 398);
            this.mostrarRFC.Name = "mostrarRFC";
            this.mostrarRFC.Size = new System.Drawing.Size(0, 19);
            this.mostrarRFC.TabIndex = 47;
            this.mostrarRFC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 426);
            this.Controls.Add(this.mostrarRFC);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.cbTamanio);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtNombreD);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btGenerarID);
            this.Controls.Add(this.DTPfecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblDuenio);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAltas";
            this.Text = "ALTAS";
            this.Load += new System.EventHandler(this.FormAltas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.ComboBox cbTamanio;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.TextBox txtEnfermedad;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtNombreD;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btGenerarID;
        private System.Windows.Forms.DateTimePicker DTPfecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblDuenio;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.OpenFileDialog ofdSeleccionar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label mostrarRFC;
    }
}