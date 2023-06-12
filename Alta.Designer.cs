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
            tipo_vehiculo.Location = new Point(303, 15);
            tipo_vehiculo.Name = "tipo_vehiculo";
            tipo_vehiculo.Size = new Size(192, 25);
            tipo_vehiculo.TabIndex = 0;
            tipo_vehiculo.Text = "Elija el tipo de vehiculo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(377, 305);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese año del vehiculo";
            textBox1.Size = new Size(205, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // anio
            // 
            anio.AutoSize = true;
            anio.Location = new Point(201, 305);
            anio.Name = "anio";
            anio.Size = new Size(45, 25);
            anio.TabIndex = 2;
            anio.Text = "Año";
            anio.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(377, 370);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ingrese kilometraje";
            textBox2.Size = new Size(205, 31);
            textBox2.TabIndex = 4;
            // 
            // selector_tipo
            // 
            selector_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            selector_tipo.FormattingEnabled = true;
            selector_tipo.Location = new Point(303, 65);
            selector_tipo.Name = "selector_tipo";
            selector_tipo.Size = new Size(190, 33);
            selector_tipo.TabIndex = 1;
            selector_tipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // kilometraje_horas
            // 
            kilometraje_horas.AutoSize = true;
            kilometraje_horas.Location = new Point(164, 375);
            kilometraje_horas.Name = "kilometraje_horas";
            kilometraje_horas.Size = new Size(151, 25);
            kilometraje_horas.TabIndex = 5;
            kilometraje_horas.Text = "Kilometraje actual";
            // 
            // boton_seleccionar
            // 
            boton_seleccionar.Location = new Point(341, 245);
            boton_seleccionar.Name = "boton_seleccionar";
            boton_seleccionar.Size = new Size(110, 37);
            boton_seleccionar.TabIndex = 6;
            boton_seleccionar.Text = "Seleccionar";
            boton_seleccionar.UseVisualStyleBackColor = true;
            boton_seleccionar.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(377, 435);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Ingrese color";
            textBox3.Size = new Size(205, 31);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(377, 495);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Ingrese dueño";
            textBox4.Size = new Size(205, 31);
            textBox4.TabIndex = 6;
            // 
            // color
            // 
            color.AutoSize = true;
            color.Location = new Point(201, 440);
            color.Name = "color";
            color.Size = new Size(55, 25);
            color.TabIndex = 9;
            color.Text = "Color";
            color.Click += label4_Click;
            // 
            // duenio_empresa
            // 
            duenio_empresa.AutoSize = true;
            duenio_empresa.Location = new Point(201, 500);
            duenio_empresa.Name = "duenio_empresa";
            duenio_empresa.Size = new Size(65, 25);
            duenio_empresa.TabIndex = 10;
            duenio_empresa.Text = "Dueño";
            duenio_empresa.Click += label5_Click;
            // 
            // boton_alta
            // 
            boton_alta.Location = new Point(271, 560);
            boton_alta.Margin = new Padding(4, 5, 4, 5);
            boton_alta.Name = "boton_alta";
            boton_alta.Size = new Size(107, 38);
            boton_alta.TabIndex = 7;
            boton_alta.Text = "Dar de alta";
            boton_alta.UseVisualStyleBackColor = true;
            boton_alta.Click += boton_alta_Click;
            // 
            // boton_limpiar
            // 
            boton_limpiar.Location = new Point(387, 560);
            boton_limpiar.Margin = new Padding(4, 5, 4, 5);
            boton_limpiar.Name = "boton_limpiar";
            boton_limpiar.Size = new Size(107, 38);
            boton_limpiar.TabIndex = 8;
            boton_limpiar.Text = "Limpiar";
            boton_limpiar.UseVisualStyleBackColor = true;
            boton_limpiar.Click += button3_Click;
            // 
            // selector_modelo
            // 
            selector_modelo.DropDownStyle = ComboBoxStyle.DropDownList;
            selector_modelo.FormattingEnabled = true;
            selector_modelo.Location = new Point(303, 185);
            selector_modelo.Name = "selector_modelo";
            selector_modelo.Size = new Size(190, 33);
            selector_modelo.TabIndex = 2;
            selector_modelo.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // modelo
            // 
            modelo.AutoSize = true;
            modelo.Location = new Point(331, 135);
            modelo.Name = "modelo";
            modelo.Size = new Size(127, 25);
            modelo.TabIndex = 14;
            modelo.Text = "Elija el modelo";
            // 
            // Alta
            // 
            AcceptButton = boton_alta;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 618);
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