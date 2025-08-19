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
            lsbIncidentes = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lsbIncidentes
            // 
            lsbIncidentes.FormattingEnabled = true;
            lsbIncidentes.ItemHeight = 15;
            lsbIncidentes.Location = new Point(12, 12);
            lsbIncidentes.Name = "lsbIncidentes";
            lsbIncidentes.Size = new Size(387, 394);
            lsbIncidentes.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(164, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FVerIncidentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 450);
            Controls.Add(button1);
            Controls.Add(lsbIncidentes);
            Name = "FVerIncidentes";
            Text = "Ver incidentes";
            ResumeLayout(false);
        }

        #endregion

        public ListBox lsbIncidentes;
        private Button button1;
    }
}