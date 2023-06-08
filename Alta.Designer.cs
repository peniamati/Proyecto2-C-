namespace Proyecto2
{
    partial class Alta
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 199);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 0;
            label1.Text = "Año";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(377, 193);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese año del vehiculo";
            textBox1.Size = new Size(205, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 253);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 2;
            label2.Text = "Kilometraje actual";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(377, 250);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ingrese kilometraje";
            textBox2.Size = new Size(205, 31);
            textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(303, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 33);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 18);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 5;
            label3.Text = "Elija el tipo vehiculo";
            // 
            // button1
            // 
            button1.Location = new Point(344, 113);
            button1.Name = "button1";
            button1.Size = new Size(110, 36);
            button1.TabIndex = 6;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(377, 307);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Ingrese color";
            textBox3.Size = new Size(205, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(377, 368);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Ingrese dueño";
            textBox4.Size = new Size(205, 31);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 310);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 9;
            label4.Text = "Color";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 374);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 10;
            label5.Text = "Dueño";
            label5.Click += label5_Click;
            // 
            // Alta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Alta";
            Text = "Form2";
            Load += Alta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
    }
}