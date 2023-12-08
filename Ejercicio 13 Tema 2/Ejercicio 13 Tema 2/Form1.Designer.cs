namespace Ejercicio_13_Tema_2
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
            this.txtHorasMes = new System.Windows.Forms.TextBox();
            this.txtHorasExtraMes = new System.Windows.Forms.TextBox();
            this.txtPagaPorHora = new System.Windows.Forms.TextBox();
            this.BotonNomina = new System.Windows.Forms.Button();
            this.HorasTrabajadasLabel = new System.Windows.Forms.Label();
            this.HorasExtrasLabel = new System.Windows.Forms.Label();
            this.PagaPorHoraLabel = new System.Windows.Forms.Label();
            this.NominaLabel = new System.Windows.Forms.Label();
            this.RetencionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHorasMes
            // 
            this.txtHorasMes.Location = new System.Drawing.Point(394, 59);
            this.txtHorasMes.Name = "txtHorasMes";
            this.txtHorasMes.Size = new System.Drawing.Size(150, 31);
            this.txtHorasMes.TabIndex = 0;
            // 
            // txtHorasExtraMes
            // 
            this.txtHorasExtraMes.Location = new System.Drawing.Point(394, 134);
            this.txtHorasExtraMes.Name = "txtHorasExtraMes";
            this.txtHorasExtraMes.Size = new System.Drawing.Size(150, 31);
            this.txtHorasExtraMes.TabIndex = 1;
            // 
            // txtPagaPorHora
            // 
            this.txtPagaPorHora.Location = new System.Drawing.Point(394, 207);
            this.txtPagaPorHora.Name = "txtPagaPorHora";
            this.txtPagaPorHora.Size = new System.Drawing.Size(150, 31);
            this.txtPagaPorHora.TabIndex = 2;
            // 
            // BotonNomina
            // 
            this.BotonNomina.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotonNomina.Location = new System.Drawing.Point(607, 134);
            this.BotonNomina.Name = "BotonNomina";
            this.BotonNomina.Size = new System.Drawing.Size(170, 74);
            this.BotonNomina.TabIndex = 3;
            this.BotonNomina.Text = "Calcular Nomina";
            this.BotonNomina.UseVisualStyleBackColor = true;
            this.BotonNomina.Click += new System.EventHandler(this.BotonNomina_Click);
            // 
            // HorasTrabajadasLabel
            // 
            this.HorasTrabajadasLabel.AutoSize = true;
            this.HorasTrabajadasLabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HorasTrabajadasLabel.Location = new System.Drawing.Point(30, 65);
            this.HorasTrabajadasLabel.Name = "HorasTrabajadasLabel";
            this.HorasTrabajadasLabel.Size = new System.Drawing.Size(313, 21);
            this.HorasTrabajadasLabel.TabIndex = 4;
            this.HorasTrabajadasLabel.Text = "Numero Horas Trabajadas al Mes: ";
            // 
            // HorasExtrasLabel
            // 
            this.HorasExtrasLabel.AutoSize = true;
            this.HorasExtrasLabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HorasExtrasLabel.Location = new System.Drawing.Point(30, 136);
            this.HorasExtrasLabel.Name = "HorasExtrasLabel";
            this.HorasExtrasLabel.Size = new System.Drawing.Size(358, 21);
            this.HorasExtrasLabel.TabIndex = 5;
            this.HorasExtrasLabel.Text = "Numero Horas Extra Trabajadas al Mes:";
            // 
            // PagaPorHoraLabel
            // 
            this.PagaPorHoraLabel.AutoSize = true;
            this.PagaPorHoraLabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PagaPorHoraLabel.Location = new System.Drawing.Point(30, 207);
            this.PagaPorHoraLabel.Name = "PagaPorHoraLabel";
            this.PagaPorHoraLabel.Size = new System.Drawing.Size(210, 21);
            this.PagaPorHoraLabel.TabIndex = 6;
            this.PagaPorHoraLabel.Text = "Paga por Hora Normal:";
            // 
            // NominaLabel
            // 
            this.NominaLabel.AutoSize = true;
            this.NominaLabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NominaLabel.Location = new System.Drawing.Point(266, 342);
            this.NominaLabel.Name = "NominaLabel";
            this.NominaLabel.Size = new System.Drawing.Size(0, 21);
            this.NominaLabel.TabIndex = 8;
            // 
            // RetencionLabel
            // 
            this.RetencionLabel.AutoSize = true;
            this.RetencionLabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RetencionLabel.Location = new System.Drawing.Point(266, 270);
            this.RetencionLabel.Name = "RetencionLabel";
            this.RetencionLabel.Size = new System.Drawing.Size(0, 21);
            this.RetencionLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RetencionLabel);
            this.Controls.Add(this.NominaLabel);
            this.Controls.Add(this.PagaPorHoraLabel);
            this.Controls.Add(this.HorasExtrasLabel);
            this.Controls.Add(this.HorasTrabajadasLabel);
            this.Controls.Add(this.BotonNomina);
            this.Controls.Add(this.txtPagaPorHora);
            this.Controls.Add(this.txtHorasExtraMes);
            this.Controls.Add(this.txtHorasMes);
            this.Name = "Form1";
            this.Text = "Ejercicio 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtHorasMes;
        private TextBox txtHorasExtraMes;
        private TextBox txtPagaPorHora;
        private Button BotonNomina;
        private Label HorasTrabajadasLabel;
        private Label HorasExtrasLabel;
        private Label PagaPorHoraLabel;
        private Label NominaLabel;
        private Label RetencionLabel;
    }
}