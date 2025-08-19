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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            nudDuracionenM = new NumericUpDown();
            nudMinuto = new NumericUpDown();
            nudHora = new NumericUpDown();
            nudNroGuardia = new NumericUpDown();
            btnAsignaciondeGuardias = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            nudPlacaAgente = new NumericUpDown();
            label1 = new Label();
            groupBox4 = new GroupBox();
            btnRegistrarIncidente = new Button();
            tbMotivo = new TextBox();
            label9 = new Label();
            tbDNI = new TextBox();
            label8 = new Label();
            tbNombrePersona = new TextBox();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            btnCerrar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracionenM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNroGuardia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPlacaAgente).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(nudPlacaAgente);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 251);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operaciones sobre el agente";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nudDuracionenM);
            groupBox3.Controls.Add(nudMinuto);
            groupBox3.Controls.Add(nudHora);
            groupBox3.Controls.Add(nudNroGuardia);
            groupBox3.Controls.Add(btnAsignaciondeGuardias);
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
            // nudDuracionenM
            // 
            nudDuracionenM.Location = new Point(129, 100);
            nudDuracionenM.Name = "nudDuracionenM";
            nudDuracionenM.Size = new Size(100, 23);
            nudDuracionenM.TabIndex = 8;
            // 
            // nudMinuto
            // 
            nudMinuto.Location = new Point(185, 60);
            nudMinuto.Name = "nudMinuto";
            nudMinuto.Size = new Size(44, 23);
            nudMinuto.TabIndex = 7;
            // 
            // nudHora
            // 
            nudHora.Location = new Point(129, 60);
            nudHora.Name = "nudHora";
            nudHora.Size = new Size(44, 23);
            nudHora.TabIndex = 6;
            // 
            // nudNroGuardia
            // 
            nudNroGuardia.Location = new Point(129, 26);
            nudNroGuardia.Name = "nudNroGuardia";
            nudNroGuardia.Size = new Size(100, 23);
            nudNroGuardia.TabIndex = 3;
            // 
            // btnAsignaciondeGuardias
            // 
            btnAsignaciondeGuardias.Location = new Point(265, 42);
            btnAsignaciondeGuardias.Name = "btnAsignaciondeGuardias";
            btnAsignaciondeGuardias.Size = new Size(94, 55);
            btnAsignaciondeGuardias.TabIndex = 2;
            btnAsignaciondeGuardias.Text = "Asignación de las guardias";
            btnAsignaciondeGuardias.UseVisualStyleBackColor = true;
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
            // nudPlacaAgente
            // 
            nudPlacaAgente.Location = new Point(117, 42);
            nudPlacaAgente.Name = "nudPlacaAgente";
            nudPlacaAgente.Size = new Size(134, 23);
            nudPlacaAgente.TabIndex = 1;
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
            // groupBox4
            // 
            groupBox4.Controls.Add(btnRegistrarIncidente);
            groupBox4.Controls.Add(tbMotivo);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(tbDNI);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(tbNombrePersona);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(numericUpDown1);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(numericUpDown2);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(12, 375);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(428, 241);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Administración de Incidentes";
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
            // tbDNI
            // 
            tbDNI.Location = new Point(320, 108);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(100, 23);
            tbDNI.TabIndex = 14;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(207, 65);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(44, 23);
            numericUpDown1.TabIndex = 10;
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
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(151, 65);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(44, 23);
            numericUpDown2.TabIndex = 9;
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
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Actividad 2";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracionenM).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNroGuardia).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPlacaAgente).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnListarIncidentes;
        private Button btnCreacionComisaria;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private NumericUpDown nudPlacaAgente;
        private NumericUpDown nudDuracionenM;
        private NumericUpDown nudMinuto;
        private NumericUpDown nudHora;
        private NumericUpDown nudNroGuardia;
        private Button btnAsignaciondeGuardias;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox4;
        private Label label5;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private TextBox tbDNI;
        private Label label8;
        private TextBox tbNombrePersona;
        private TextBox tbMotivo;
        private Label label9;
        private Button btnCerrar;
        private Button btnRegistrarIncidente;
    }
}
