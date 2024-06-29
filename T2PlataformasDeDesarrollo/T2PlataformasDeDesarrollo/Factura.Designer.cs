namespace T2PlataformasDeDesarrollo
{
    partial class Factura
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
            datosMedicamento = new Label();
            datosEnvio = new Label();
            cancel = new Button();
            enviar = new Button();
            SuspendLayout();
            // 
            // datosMedicamento
            // 
            datosMedicamento.AutoSize = true;
            datosMedicamento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datosMedicamento.Location = new Point(49, 85);
            datosMedicamento.Name = "datosMedicamento";
            datosMedicamento.Size = new Size(70, 28);
            datosMedicamento.TabIndex = 0;
            datosMedicamento.Text = "label1";
            // 
            // datosEnvio
            // 
            datosEnvio.AutoSize = true;
            datosEnvio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datosEnvio.Location = new Point(49, 215);
            datosEnvio.Name = "datosEnvio";
            datosEnvio.Size = new Size(70, 28);
            datosEnvio.TabIndex = 1;
            datosEnvio.Text = "label2";
            // 
            // cancel
            // 
            cancel.BackColor = Color.Red;
            cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel.Location = new Point(25, 376);
            cancel.Name = "cancel";
            cancel.Size = new Size(94, 29);
            cancel.TabIndex = 2;
            cancel.Text = "Cancelar";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // enviar
            // 
            enviar.BackColor = Color.FromArgb(128, 255, 128);
            enviar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enviar.Location = new Point(406, 376);
            enviar.Name = "enviar";
            enviar.Size = new Size(94, 29);
            enviar.TabIndex = 3;
            enviar.Text = "Enviar";
            enviar.UseVisualStyleBackColor = false;
            enviar.Click += enviar_Click;
            // 
            // Factura
            // 
            AccessibleName = "facturaVentana";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(563, 483);
            Controls.Add(enviar);
            Controls.Add(cancel);
            Controls.Add(datosEnvio);
            Controls.Add(datosMedicamento);
            Name = "Factura";
            Text = "Factura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label datosMedicamento;
        private Label datosEnvio;
        private Button cancel;
        private Button enviar;
    }
}