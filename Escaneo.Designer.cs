﻿namespace Proyecto2
{
    partial class Escaneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escaneo));
            tipo = new Label();
            selector_tipo = new ComboBox();
            boton_seleccionar = new Button();
            tabla = new DataGridView();
            boton_a_escanear = new Button();
            a_escanear = new Label();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // tipo
            // 
            tipo.AutoSize = true;
            tipo.Location = new Point(229, 9);
            tipo.Name = "tipo";
            tipo.Size = new Size(128, 15);
            tipo.TabIndex = 0;
            tipo.Text = "Elija el tipo de vehiculo";
            // 
            // selector_tipo
            // 
            selector_tipo.FormattingEnabled = true;
            selector_tipo.Location = new Point(229, 36);
            selector_tipo.Name = "selector_tipo";
            selector_tipo.Size = new Size(121, 23);
            selector_tipo.TabIndex = 7;
            // 
            // boton_seleccionar
            // 
            boton_seleccionar.Location = new Point(251, 65);
            boton_seleccionar.Name = "boton_seleccionar";
            boton_seleccionar.Size = new Size(75, 23);
            boton_seleccionar.TabIndex = 8;
            boton_seleccionar.Text = "Seleccionar";
            boton_seleccionar.UseVisualStyleBackColor = true;
            boton_seleccionar.Click += boton_seleccionar_Click;
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Location = new Point(173, 143);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(240, 150);
            tabla.TabIndex = 9;
            // 
            // boton_a_escanear
            // 
            boton_a_escanear.Location = new Point(251, 309);
            boton_a_escanear.Name = "boton_a_escanear";
            boton_a_escanear.Size = new Size(75, 23);
            boton_a_escanear.TabIndex = 10;
            boton_a_escanear.Text = "Escanear";
            boton_a_escanear.UseVisualStyleBackColor = true;
            boton_a_escanear.Click += boton_a_escanear_Click;
            // 
            // a_escanear
            // 
            a_escanear.AutoSize = true;
            a_escanear.Location = new Point(220, 113);
            a_escanear.Name = "a_escanear";
            a_escanear.Size = new Size(146, 15);
            a_escanear.TabIndex = 11;
            a_escanear.Text = "Elija el vehiculo a escanear";
            // 
            // Escaneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 344);
            Controls.Add(a_escanear);
            Controls.Add(boton_a_escanear);
            Controls.Add(tabla);
            Controls.Add(boton_seleccionar);
            Controls.Add(selector_tipo);
            Controls.Add(tipo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Escaneo";
            Text = "Form1";
            Load += Escaneo_Load;
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tipo;
        private ComboBox selector_tipo;
        private Button boton_seleccionar;
        private DataGridView tabla;
        private Button boton_a_escanear;
        private Label a_escanear;
    }
}