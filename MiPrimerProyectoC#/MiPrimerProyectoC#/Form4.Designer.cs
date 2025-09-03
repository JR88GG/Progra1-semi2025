namespace MiPrimerProyectoC_
{
    partial class Form4
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMedidaOrigen = new System.Windows.Forms.ComboBox();
            this.txtCantidadConversor = new System.Windows.Forms.TextBox();
            this.lblMedidaOrigen = new System.Windows.Forms.Label();
            this.lblMedidaAObtener = new System.Windows.Forms.Label();
            this.cboMedidaAObtener = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConversion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(437, 126);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(107, 65);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad:";
            // 
            // cboMedidaOrigen
            // 
            this.cboMedidaOrigen.FormattingEnabled = true;
            this.cboMedidaOrigen.Items.AddRange(new object[] {
            "Metro Cuadrado",
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Tareas",
            "Manzanas",
            "Hectareas"});
            this.cboMedidaOrigen.Location = new System.Drawing.Point(224, 178);
            this.cboMedidaOrigen.Name = "cboMedidaOrigen";
            this.cboMedidaOrigen.Size = new System.Drawing.Size(154, 24);
            this.cboMedidaOrigen.TabIndex = 2;
            // 
            // txtCantidadConversor
            // 
            this.txtCantidadConversor.Location = new System.Drawing.Point(224, 126);
            this.txtCantidadConversor.Name = "txtCantidadConversor";
            this.txtCantidadConversor.Size = new System.Drawing.Size(154, 22);
            this.txtCantidadConversor.TabIndex = 3;
            // 
            // lblMedidaOrigen
            // 
            this.lblMedidaOrigen.AutoSize = true;
            this.lblMedidaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedidaOrigen.Location = new System.Drawing.Point(76, 176);
            this.lblMedidaOrigen.Name = "lblMedidaOrigen";
            this.lblMedidaOrigen.Size = new System.Drawing.Size(142, 22);
            this.lblMedidaOrigen.TabIndex = 4;
            this.lblMedidaOrigen.Text = "Medida origen:";
            // 
            // lblMedidaAObtener
            // 
            this.lblMedidaAObtener.AutoSize = true;
            this.lblMedidaAObtener.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedidaAObtener.Location = new System.Drawing.Point(47, 229);
            this.lblMedidaAObtener.Name = "lblMedidaAObtener";
            this.lblMedidaAObtener.Size = new System.Drawing.Size(171, 22);
            this.lblMedidaAObtener.TabIndex = 6;
            this.lblMedidaAObtener.Text = "Medida a obtener:";
            // 
            // cboMedidaAObtener
            // 
            this.cboMedidaAObtener.FormattingEnabled = true;
            this.cboMedidaAObtener.Items.AddRange(new object[] {
            "Metro Cuadrado",
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Tareas",
            "Manzanas",
            "Hectareas"});
            this.cboMedidaAObtener.Location = new System.Drawing.Point(224, 231);
            this.cboMedidaAObtener.Name = "cboMedidaAObtener";
            this.cboMedidaAObtener.Size = new System.Drawing.Size(154, 24);
            this.cboMedidaAObtener.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 64);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conversor de medidas(salvadoreñas)\r\n de área.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConversion
            // 
            this.lblConversion.AutoSize = true;
            this.lblConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversion.Location = new System.Drawing.Point(90, 277);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.Size = new System.Drawing.Size(128, 22);
            this.lblConversion.TabIndex = 8;
            this.lblConversion.Text = "Conversion:?";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 349);
            this.Controls.Add(this.lblConversion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMedidaAObtener);
            this.Controls.Add(this.cboMedidaAObtener);
            this.Controls.Add(this.lblMedidaOrigen);
            this.Controls.Add(this.txtCantidadConversor);
            this.Controls.Add(this.cboMedidaOrigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertir);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMedidaOrigen;
        private System.Windows.Forms.TextBox txtCantidadConversor;
        private System.Windows.Forms.Label lblMedidaOrigen;
        private System.Windows.Forms.Label lblMedidaAObtener;
        private System.Windows.Forms.ComboBox cboMedidaAObtener;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConversion;
    }
}