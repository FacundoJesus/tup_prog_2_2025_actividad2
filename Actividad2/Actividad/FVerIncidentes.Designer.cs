namespace Actividad
{
    partial class FVerIncidentes
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
            btnCerrar = new Button();
            tbResultado = new TextBox();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.DialogResult = DialogResult.OK;
            btnCerrar.Location = new Point(165, 415);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(12, 12);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(391, 397);
            tbResultado.TabIndex = 2;
            // 
            // FVerIncidentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 450);
            Controls.Add(tbResultado);
            Controls.Add(btnCerrar);
            Name = "FVerIncidentes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver incidentes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListBox lsbIncidentes;
        private Button btnCerrar;
        public TextBox tbResultado;
    }
}