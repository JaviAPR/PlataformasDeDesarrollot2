namespace T2PlataformasDeDesarrollo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nombreMedicamento = new TextBox();
            tipoMedicamento = new ComboBox();
            label2 = new Label();
            cantidad = new TextBox();
            label3 = new Label();
            distribuidor = new GroupBox();
            cemefar = new RadioButton();
            empsephar = new RadioButton();
            cofarma = new RadioButton();
            sucursal = new GroupBox();
            secundaria = new CheckBox();
            principal = new CheckBox();
            bBorrar = new Button();
            bConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            distribuidor.SuspendLayout();
            sucursal.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-6, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(892, 196);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 228);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre de Medicamento:";
            // 
            // nombreMedicamento
            // 
            nombreMedicamento.Location = new Point(85, 251);
            nombreMedicamento.Name = "nombreMedicamento";
            nombreMedicamento.Size = new Size(446, 27);
            nombreMedicamento.TabIndex = 3;
            // 
            // tipoMedicamento
            // 
            tipoMedicamento.FormattingEnabled = true;
            tipoMedicamento.Items.AddRange(new object[] { "Analgesico", "Analeptico", "Anestesico", "Antiacido", "Antidepresivo", "Antibioticos" });
            tipoMedicamento.Location = new Point(644, 251);
            tipoMedicamento.Name = "tipoMedicamento";
            tipoMedicamento.Size = new Size(151, 28);
            tipoMedicamento.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(644, 228);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 5;
            label2.Text = "Tipo:";
            // 
            // cantidad
            // 
            cantidad.Location = new Point(85, 348);
            cantidad.Name = "cantidad";
            cantidad.Size = new Size(57, 27);
            cantidad.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 325);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Cantidad:";
            // 
            // distribuidor
            // 
            distribuidor.Controls.Add(cemefar);
            distribuidor.Controls.Add(empsephar);
            distribuidor.Controls.Add(cofarma);
            distribuidor.Location = new Point(644, 325);
            distribuidor.Name = "distribuidor";
            distribuidor.Size = new Size(168, 195);
            distribuidor.TabIndex = 8;
            distribuidor.TabStop = false;
            distribuidor.Text = "Distribuidor:";
            // 
            // cemefar
            // 
            cemefar.AutoSize = true;
            cemefar.Location = new Point(6, 119);
            cemefar.Name = "cemefar";
            cemefar.Size = new Size(86, 24);
            cemefar.TabIndex = 2;
            cemefar.TabStop = true;
            cemefar.Text = "Cemefar";
            cemefar.UseVisualStyleBackColor = true;
            // 
            // empsephar
            // 
            empsephar.AutoSize = true;
            empsephar.Location = new Point(6, 74);
            empsephar.Name = "empsephar";
            empsephar.Size = new Size(104, 24);
            empsephar.TabIndex = 1;
            empsephar.TabStop = true;
            empsephar.Text = "Empsephar";
            empsephar.UseVisualStyleBackColor = true;
            // 
            // cofarma
            // 
            cofarma.AutoSize = true;
            cofarma.Location = new Point(6, 35);
            cofarma.Name = "cofarma";
            cofarma.Size = new Size(87, 24);
            cofarma.TabIndex = 0;
            cofarma.TabStop = true;
            cofarma.Text = "Cofarma";
            cofarma.TextAlign = ContentAlignment.MiddleCenter;
            cofarma.UseVisualStyleBackColor = true;
            // 
            // sucursal
            // 
            sucursal.Controls.Add(secundaria);
            sucursal.Controls.Add(principal);
            sucursal.Location = new Point(85, 462);
            sucursal.Name = "sucursal";
            sucursal.Size = new Size(314, 125);
            sucursal.TabIndex = 10;
            sucursal.TabStop = false;
            sucursal.Text = "Sucursal para el pedido:";
            // 
            // secundaria
            // 
            secundaria.AutoSize = true;
            secundaria.Location = new Point(192, 54);
            secundaria.Name = "secundaria";
            secundaria.Size = new Size(104, 24);
            secundaria.TabIndex = 1;
            secundaria.Text = "Secundaria";
            secundaria.UseVisualStyleBackColor = true;
            // 
            // principal
            // 
            principal.AutoSize = true;
            principal.Location = new Point(26, 54);
            principal.Name = "principal";
            principal.Size = new Size(88, 24);
            principal.TabIndex = 0;
            principal.Text = "Principal";
            principal.UseVisualStyleBackColor = true;
            // 
            // bBorrar
            // 
            bBorrar.BackColor = Color.Red;
            bBorrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bBorrar.ForeColor = SystemColors.InactiveCaptionText;
            bBorrar.Location = new Point(562, 648);
            bBorrar.Name = "bBorrar";
            bBorrar.Size = new Size(94, 29);
            bBorrar.TabIndex = 11;
            bBorrar.Text = "Borrar";
            bBorrar.UseVisualStyleBackColor = false;
            bBorrar.Click += borrar;
            // 
            // bConfirmar
            // 
            bConfirmar.BackColor = Color.FromArgb(128, 255, 128);
            bConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bConfirmar.Location = new Point(718, 648);
            bConfirmar.Name = "bConfirmar";
            bConfirmar.Size = new Size(94, 29);
            bConfirmar.TabIndex = 12;
            bConfirmar.Text = "Confirmar";
            bConfirmar.UseVisualStyleBackColor = false;
            bConfirmar.Click += confirmar;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(886, 766);
            Controls.Add(bConfirmar);
            Controls.Add(bBorrar);
            Controls.Add(sucursal);
            Controls.Add(distribuidor);
            Controls.Add(label3);
            Controls.Add(cantidad);
            Controls.Add(label2);
            Controls.Add(tipoMedicamento);
            Controls.Add(nombreMedicamento);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "JP Farmacia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            distribuidor.ResumeLayout(false);
            distribuidor.PerformLayout();
            sucursal.ResumeLayout(false);
            sucursal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox nombreMedicamento;
        private ComboBox tipoMedicamento;
        private Label label2;
        private TextBox cantidad;
        private Label label3;
        private GroupBox distribuidor;
        private RadioButton cemefar;
        private RadioButton empsephar;
        private RadioButton cofarma;
        private GroupBox sucursal;
        private CheckBox secundaria;
        private CheckBox principal;
        private Button bBorrar;
        private Button bConfirmar;
    }
}
