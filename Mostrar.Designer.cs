namespace Proyecto2
{
    partial class Mostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar));
            label1 = new Label();
            lista_mostrada = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 28);
            label1.Name = "label1";
            label1.Size = new Size(250, 15);
            label1.TabIndex = 1;
            label1.Text = "Cantidad de carga de baterias de los vehiculos";
            // 
            // lista_mostrada
            // 
            lista_mostrada.Location = new Point(207, 93);
            lista_mostrada.Name = "lista_mostrada";
            lista_mostrada.Size = new Size(121, 97);
            lista_mostrada.TabIndex = 2;
            lista_mostrada.UseCompatibleStateImageBehavior = false;
            // 
            // Mostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 288);
            Controls.Add(lista_mostrada);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Mostrar";
            Text = "Carga de baterias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListView lista_mostrada;
    }
}