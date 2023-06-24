namespace Proyecto2
{
    partial class MasViejo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasViejo));
            label1 = new Label();
            mas_viejo_duenio = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 38);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "El Tesla mas viejo es: ";
            // 
            // mas_viejo_duenio
            // 
            mas_viejo_duenio.AutoSize = true;
            mas_viejo_duenio.Location = new Point(83, 62);
            mas_viejo_duenio.Name = "mas_viejo_duenio";
            mas_viejo_duenio.Size = new Size(38, 15);
            mas_viejo_duenio.TabIndex = 1;
            mas_viejo_duenio.Text = "label2";
            // 
            // MasViejo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 146);
            Controls.Add(mas_viejo_duenio);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MasViejo";
            Text = "Mas Viejo";
            Load += MasViejo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        // compnentes de la ventana mas viejo

        private Label label1;
        private Label mas_viejo_duenio;
    }
}