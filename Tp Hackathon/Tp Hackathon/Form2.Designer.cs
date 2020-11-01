namespace Tp_Hackathon
{
    partial class VentanaING
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.cmbBox1 = new System.Windows.Forms.ComboBox();
            this.lblTit = new System.Windows.Forms.Label();
            this.DGVventa = new System.Windows.Forms.DataGridView();
            this.btnGrabar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVventa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Enabled = false;
            this.btnComprar.Location = new System.Drawing.Point(12, 97);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(90, 22);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "Registrar venta";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(150, 52);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(244, 20);
            this.txtCompra.TabIndex = 1;
            this.txtCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompra_KeyPress);
            // 
            // cmbBox1
            // 
            this.cmbBox1.FormattingEnabled = true;
            this.cmbBox1.Items.AddRange(new object[] {
            "Ibuprofeno",
            "Paracetamol"});
            this.cmbBox1.Location = new System.Drawing.Point(12, 52);
            this.cmbBox1.Name = "cmbBox1";
            this.cmbBox1.Size = new System.Drawing.Size(121, 21);
            this.cmbBox1.TabIndex = 2;
            // 
            // lblTit
            // 
            this.lblTit.AutoSize = true;
            this.lblTit.Location = new System.Drawing.Point(9, 24);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(93, 13);
            this.lblTit.TabIndex = 3;
            this.lblTit.Text = "Reportar producto\r\n";
            // 
            // DGVventa
            // 
            this.DGVventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVventa.Location = new System.Drawing.Point(12, 156);
            this.DGVventa.Name = "DGVventa";
            this.DGVventa.Size = new System.Drawing.Size(607, 199);
            this.DGVventa.TabIndex = 5;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(531, 24);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(88, 39);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar Tabla";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // VentanaING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 379);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.DGVventa);
            this.Controls.Add(this.lblTit);
            this.Controls.Add(this.cmbBox1);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.btnComprar);
            this.Name = "VentanaING";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.VentanaING_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.ComboBox cmbBox1;
        private System.Windows.Forms.Label lblTit;
        private System.Windows.Forms.DataGridView DGVventa;
        private System.Windows.Forms.Button btnGrabar;
    }
}