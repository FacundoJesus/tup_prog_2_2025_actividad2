namespace Actividad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnListarIncidentes = new Button();
            btnCreacionComisaria = new Button();
            gbOperacionSobreAgente = new GroupBox();
            cmbPlacaAgente = new ComboBox();
            groupBox3 = new GroupBox();
            nudDuracionEnM = new NumericUpDown();
            nudMinutoDesde = new NumericUpDown();
            nudHoraDesde = new NumericUpDown();
            nudNroGuardia = new NumericUpDown();
            btnAsignacionGuardias = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbAdministracion = new GroupBox();
            cmbTipoIncidente = new ComboBox();
            btnRegistrarIncidente = new Button();
            tbMotivo = new TextBox();
            label9 = new Label();
            tbDNIPersona = new TextBox();
            label8 = new Label();
            tbNombrePersona = new TextBox();
            label7 = new Label();
            nudMinutoIncidente = new NumericUpDown();
            label6 = new Label();
            nudHoraIncidente = new NumericUpDown();
            label5 = new Label();
            btnCerrar = new Button();
            groupBox1.SuspendLayout();
            gbOperacionSobreAgente.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracionEnM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutoDesde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHoraDesde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNroGuardia).BeginInit();
            gbAdministracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinutoIncidente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHoraIncidente).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnListarIncidentes);
            groupBox1.Controls.Add(btnCreacionComisaria);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administración comisaría";
            // 
            // btnListarIncidentes
            // 
            btnListarIncidentes.Location = new Point(326, 22);
            btnListarIncidentes.Name = "btnListarIncidentes";
            btnListarIncidentes.Size = new Size(75, 55);
            btnListarIncidentes.TabIndex = 1;
            btnListarIncidentes.Text = "Listar incidentes";
            btnListarIncidentes.UseVisualStyleBackColor = true;
            // 
            // btnCreacionComisaria
            // 
            btnCreacionComisaria.Location = new Point(226, 22);
            btnCreacionComisaria.Name = "btnCreacionComisaria";
            btnCreacionComisaria.Size = new Size(75, 55);
            btnCreacionComisaria.TabIndex = 0;
            btnCreacionComisaria.Text = "Creación comisaría";
            btnCreacionComisaria.UseVisualStyleBackColor = true;
            btnCreacionComisaria.Click += btnCreacionComisaria_Click;
            // 
            // gbOperacionSobreAgente
            // 
            gbOperacionSobreAgente.Controls.Add(cmbPlacaAgente);
            gbOperacionSobreAgente.Controls.Add(groupBox3);
            gbOperacionSobreAgente.Controls.Add(label1);
            gbOperacionSobreAgente.Location = new Point(12, 118);
            gbOperacionSobreAgente.Name = "gbOperacionSobreAgente";
            gbOperacionSobreAgente.Size = new Size(428, 251);
            gbOperacionSobreAgente.TabIndex = 1;
            gbOperacionSobreAgente.TabStop = false;
            gbOperacionSobreAgente.Text = "Operaciones sobre el agente";
            // 
            // cmbPlacaAgente
            // 
            cmbPlacaAgente.FormattingEnabled = true;
            cmbPlacaAgente.Items.AddRange(new object[] { "Denuncia", "Arresto" });
            cmbPlacaAgente.Location = new Point(104, 41);
            cmbPlacaAgente.Name = "cmbPlacaAgente";
            cmbPlacaAgente.Size = new Size(121, 23);
            cmbPlacaAgente.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nudDuracionEnM);
            groupBox3.Controls.Add(nudMinutoDesde);
            groupBox3.Controls.Add(nudHoraDesde);
            groupBox3.Controls.Add(nudNroGuardia);
            groupBox3.Controls.Add(btnAsignacionGuardias);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(22, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(379, 143);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Administración de guardias";
            // 
            // nudDuracionEnM
            // 
            nudDuracionEnM.Location = new Point(129, 100);
            nudDuracionEnM.Name = "nudDuracionEnM";
            nudDuracionEnM.Size = new Size(100, 23);
            nudDuracionEnM.TabIndex = 8;
            // 
            // nudMinutoDesde
            // 
            nudMinutoDesde.Location = new Point(185, 60);
            nudMinutoDesde.Name = "nudMinutoDesde";
            nudMinutoDesde.Size = new Size(44, 23);
            nudMinutoDesde.TabIndex = 7;
            // 
            // nudHoraDesde
            // 
            nudHoraDesde.Location = new Point(129, 60);
            nudHoraDesde.Name = "nudHoraDesde";
            nudHoraDesde.Size = new Size(44, 23);
            nudHoraDesde.TabIndex = 6;
            // 
            // nudNroGuardia
            // 
            nudNroGuardia.Location = new Point(129, 26);
            nudNroGuardia.Name = "nudNroGuardia";
            nudNroGuardia.Size = new Size(100, 23);
            nudNroGuardia.TabIndex = 3;
            // 
            // btnAsignacionGuardias
            // 
            btnAsignacionGuardias.Location = new Point(265, 42);
            btnAsignacionGuardias.Name = "btnAsignacionGuardias";
            btnAsignacionGuardias.Size = new Size(94, 55);
            btnAsignacionGuardias.TabIndex = 2;
            btnAsignacionGuardias.Text = "Asignación de las guardias";
            btnAsignacionGuardias.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 102);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 5;
            label4.Text = "Duracion en M";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 62);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 28);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Nro Guardia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Placa de Agente";
            // 
            // gbAdministracion
            // 
            gbAdministracion.Controls.Add(cmbTipoIncidente);
            gbAdministracion.Controls.Add(btnRegistrarIncidente);
            gbAdministracion.Controls.Add(tbMotivo);
            gbAdministracion.Controls.Add(label9);
            gbAdministracion.Controls.Add(tbDNIPersona);
            gbAdministracion.Controls.Add(label8);
            gbAdministracion.Controls.Add(tbNombrePersona);
            gbAdministracion.Controls.Add(label7);
            gbAdministracion.Controls.Add(nudMinutoIncidente);
            gbAdministracion.Controls.Add(label6);
            gbAdministracion.Controls.Add(nudHoraIncidente);
            gbAdministracion.Controls.Add(label5);
            gbAdministracion.Location = new Point(12, 375);
            gbAdministracion.Name = "gbAdministracion";
            gbAdministracion.Size = new Size(428, 241);
            gbAdministracion.TabIndex = 2;
            gbAdministracion.TabStop = false;
            gbAdministracion.Text = "Administración de Incidentes";
            // 
            // cmbTipoIncidente
            // 
            cmbTipoIncidente.FormattingEnabled = true;
            cmbTipoIncidente.Items.AddRange(new object[] { "Denuncia", "Arresto" });
            cmbTipoIncidente.Location = new Point(130, 26);
            cmbTipoIncidente.Name = "cmbTipoIncidente";
            cmbTipoIncidente.Size = new Size(121, 23);
            cmbTipoIncidente.TabIndex = 18;
            // 
            // btnRegistrarIncidente
            // 
            btnRegistrarIncidente.Location = new Point(6, 176);
            btnRegistrarIncidente.Name = "btnRegistrarIncidente";
            btnRegistrarIncidente.Size = new Size(75, 55);
            btnRegistrarIncidente.TabIndex = 17;
            btnRegistrarIncidente.Text = "Registrar Incidente";
            btnRegistrarIncidente.UseVisualStyleBackColor = true;
            btnRegistrarIncidente.Click += btnRegistrarIncidente_Click;
            // 
            // tbMotivo
            // 
            tbMotivo.Location = new Point(130, 159);
            tbMotivo.Multiline = true;
            tbMotivo.Name = "tbMotivo";
            tbMotivo.Size = new Size(290, 72);
            tbMotivo.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(68, 159);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 15;
            label9.Text = "Motivo";
            // 
            // tbDNIPersona
            // 
            tbDNIPersona.Location = new Point(320, 108);
            tbDNIPersona.Name = "tbDNIPersona";
            tbDNIPersona.Size = new Size(100, 23);
            tbDNIPersona.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 111);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 13;
            label8.Text = "DNI";
            // 
            // tbNombrePersona
            // 
            tbNombrePersona.Location = new Point(130, 108);
            tbNombrePersona.Name = "tbNombrePersona";
            tbNombrePersona.Size = new Size(121, 23);
            tbNombrePersona.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 111);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 11;
            label7.Text = "Persona";
            // 
            // nudMinutoIncidente
            // 
            nudMinutoIncidente.Location = new Point(207, 65);
            nudMinutoIncidente.Name = "nudMinutoIncidente";
            nudMinutoIncidente.Size = new Size(44, 23);
            nudMinutoIncidente.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 67);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 10;
            label6.Text = "Hora";
            // 
            // nudHoraIncidente
            // 
            nudHoraIncidente.Location = new Point(151, 65);
            nudHoraIncidente.Name = "nudHoraIncidente";
            nudHoraIncidente.Size = new Size(44, 23);
            nudHoraIncidente.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 34);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 9;
            label5.Text = "Tipo Incidente";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(188, 622);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 31);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 663);
            Controls.Add(btnCerrar);
            Controls.Add(gbAdministracion);
            Controls.Add(gbOperacionSobreAgente);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Actividad 2";
            groupBox1.ResumeLayout(false);
            gbOperacionSobreAgente.ResumeLayout(false);
            gbOperacionSobreAgente.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracionEnM).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutoDesde).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHoraDesde).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNroGuardia).EndInit();
            gbAdministracion.ResumeLayout(false);
            gbAdministracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinutoIncidente).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHoraIncidente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnListarIncidentes;
        private Button btnCreacionComisaria;
        private GroupBox gbOperacionSobreAgente;
        private Label label1;
        private GroupBox groupBox3;
        private NumericUpDown nudDuracionEnM;
        private NumericUpDown nudMinutoDesde;
        private NumericUpDown nudHoraDesde;
        private NumericUpDown nudNroGuardia;
        private Button btnAsignacionGuardias;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox gbAdministracion;
        private Label label5;
        private Label label7;
        private NumericUpDown nudMinutoIncidente;
        private Label label6;
        private NumericUpDown nudHoraIncidente;
        private TextBox tbDNIPersona;
        private Label label8;
        private TextBox tbNombrePersona;
        private TextBox tbMotivo;
        private Label label9;
        private Button btnCerrar;
        private Button btnRegistrarIncidente;
        private ComboBox cmbPlacaAgente;
        private ComboBox cmbTipoIncidente;
    }
}
