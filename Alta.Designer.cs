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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta));
            tipo_vehiculo = new Label();
            textBox1 = new TextBox();
            anio = new Label();
            textBox2 = new TextBox();
            selector_tipo = new ComboBox();
            kilometraje_horas = new Label();
            boton_seleccionar = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            color = new Label();
            duenio_empresa = new Label();
            boton_alta = new Button();
            boton_limpiar = new Button();
            selector_modelo = new ComboBox();
            modelo = new Label();
            SuspendLayout();
            // 
            // tipo_vehiculo
            // 
            tipo_vehiculo.AutoSize = true;
            tipo_vehiculo.Location = new Point(212, 9);
            tipo_vehiculo.Margin = new Padding(2, 0, 2, 0);
            tipo_vehiculo.Name = "tipo_vehiculo";
            tipo_vehiculo.Size = new Size(128, 15);
            tipo_vehiculo.TabIndex = 0;
            tipo_vehiculo.Text = "Elija el tipo de vehiculo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 183);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese año del vehiculo";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 3;
            // 
            // anio
            // 
            anio.AutoSize = true;
            anio.Location = new Point(141, 183);
            anio.Margin = new Padding(2, 0, 2, 0);
            anio.Name = "anio";
            anio.Size = new Size(29, 15);
            anio.TabIndex = 2;
            anio.Text = "Año";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 222);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ingrese kilometraje";
            textBox2.Size = new Size(145, 23);
            textBox2.TabIndex = 4;
            // 
            // selector_tipo
            // 
            selector_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            selector_tipo.FormattingEnabled = true;
            selector_tipo.Location = new Point(212, 39);
            selector_tipo.Margin = new Padding(2, 2, 2, 2);
            selector_tipo.Name = "selector_tipo";
            selector_tipo.Size = new Size(134, 23);
            selector_tipo.TabIndex = 1;
            selector_tipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // kilometraje_horas
            // 
            kilometraje_horas.AutoSize = true;
            kilometraje_horas.Location = new Point(115, 225);
            kilometraje_horas.Margin = new Padding(2, 0, 2, 0);
            kilometraje_horas.Name = "kilometraje_horas";
            kilometraje_horas.Size = new Size(102, 15);
            kilometraje_horas.TabIndex = 5;
            kilometraje_horas.Text = "Kilometraje actual";
            // 
            // boton_seleccionar
            // 
            boton_seleccionar.Location = new Point(239, 147);
            boton_seleccionar.Margin = new Padding(2, 2, 2, 2);
            boton_seleccionar.Name = "boton_seleccionar";
            boton_seleccionar.Size = new Size(77, 22);
            boton_seleccionar.TabIndex = 6;
            boton_seleccionar.Text = "Seleccionar";
            boton_seleccionar.UseVisualStyleBackColor = true;
            boton_seleccionar.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(264, 261);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Ingrese color";
            textBox3.Size = new Size(145, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(264, 297);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Ingrese dueño";
            textBox4.Size = new Size(145, 23);
            textBox4.TabIndex = 6;
            // 
            // color
            // 
            color.AutoSize = true;
            color.Location = new Point(141, 264);
            color.Margin = new Padding(2, 0, 2, 0);
            color.Name = "color";
            color.Size = new Size(36, 15);
            color.TabIndex = 9;
            color.Text = "Color";
            // 
            // duenio_empresa
            // 
            duenio_empresa.AutoSize = true;
            duenio_empresa.Location = new Point(141, 300);
            duenio_empresa.Margin = new Padding(2, 0, 2, 0);
            duenio_empresa.Name = "duenio_empresa";
            duenio_empresa.Size = new Size(42, 15);
            duenio_empresa.TabIndex = 10;
            duenio_empresa.Text = "Dueño";
            // 
            // boton_alta
            // 
            boton_alta.Location = new Point(190, 336);
            boton_alta.Name = "boton_alta";
            boton_alta.Size = new Size(75, 23);
            boton_alta.TabIndex = 7;
            boton_alta.Text = "Dar de alta";
            boton_alta.UseVisualStyleBackColor = true;
            boton_alta.Click += boton_alta_Click;
            // 
            // boton_limpiar
            // 
            boton_limpiar.Location = new Point(271, 336);
            boton_limpiar.Name = "boton_limpiar";
            boton_limpiar.Size = new Size(75, 23);
            boton_limpiar.TabIndex = 8;
            boton_limpiar.Text = "Limpiar";
            boton_limpiar.UseVisualStyleBackColor = true;
            boton_limpiar.Click += button3_Click;
            // 
            // selector_modelo
            // 
            selector_modelo.DropDownStyle = ComboBoxStyle.DropDownList;
            selector_modelo.FormattingEnabled = true;
            selector_modelo.Location = new Point(212, 111);
            selector_modelo.Margin = new Padding(2, 2, 2, 2);
            selector_modelo.Name = "selector_modelo";
            selector_modelo.Size = new Size(134, 23);
            selector_modelo.TabIndex = 2;
            selector_modelo.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // modelo
            // 
            modelo.AutoSize = true;
            modelo.Location = new Point(232, 81);
            modelo.Margin = new Padding(2, 0, 2, 0);
            modelo.Name = "modelo";
            modelo.Size = new Size(84, 15);
            modelo.TabIndex = 14;
            modelo.Text = "Elija el modelo";
            // 
            // Alta
            // 
            AcceptButton = boton_alta;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 371);
            Controls.Add(modelo);
            Controls.Add(selector_modelo);
            Controls.Add(boton_limpiar);
            Controls.Add(boton_alta);
            Controls.Add(duenio_empresa);
            Controls.Add(color);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(boton_seleccionar);
            Controls.Add(kilometraje_horas);
            Controls.Add(selector_tipo);
            Controls.Add(textBox2);
            Controls.Add(anio);
            Controls.Add(textBox1);
            Controls.Add(tipo_vehiculo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "Alta";
            Text = "Alta de Vehiculo";
            Load += Alta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tipo_vehiculo;
        private TextBox textBox1;
        private Label anio;
        private TextBox textBox2;
        private ComboBox selector_tipo;
        private Label kilometraje_horas;
        private Button boton_seleccionar;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label color;
        private Label duenio_empresa;
        private Button boton_alta;
        private Button boton_limpiar;
        private ComboBox selector_modelo;
        private Label modelo;
    }
}