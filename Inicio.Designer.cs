namespace Proyecto2
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            pageSetupDialog1 = new PageSetupDialog();
            pageSetupDialog2 = new PageSetupDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(286, 277);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(217, 53);
            button1.TabIndex = 0;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 212);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(706, 33);
            comboBox1.TabIndex = 1;
            comboBox1.Click += Form1_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 61);
            label1.Name = "label1";
            label1.Size = new Size(465, 25);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido al sistema de registro de Vehiculos de SpaceX";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 131);
            label2.Name = "label2";
            label2.Size = new Size(256, 25);
            label2.TabIndex = 3;
            label2.Text = "Para comenzar elija una opción";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 360);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "SpaceX";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private PageSetupDialog pageSetupDialog1;
        private PageSetupDialog pageSetupDialog2;
    }
}