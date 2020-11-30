namespace CajeroAutomatico
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.txtSaldoFinal = new System.Windows.Forms.TextBox();
            this.lblSaldoFinal = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txt500 = new System.Windows.Forms.TextBox();
            this.txt200 = new System.Windows.Forms.TextBox();
            this.txt100 = new System.Windows.Forms.TextBox();
            this.txt50 = new System.Windows.Forms.TextBox();
            this.txtRetiro = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl500 = new System.Windows.Forms.Label();
            this.lbl200 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Tiket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSaldoFinal
            // 
            this.txtSaldoFinal.Location = new System.Drawing.Point(320, 218);
            this.txtSaldoFinal.Name = "txtSaldoFinal";
            this.txtSaldoFinal.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoFinal.TabIndex = 40;
            // 
            // lblSaldoFinal
            // 
            this.lblSaldoFinal.AutoSize = true;
            this.lblSaldoFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoFinal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSaldoFinal.Location = new System.Drawing.Point(247, 219);
            this.lblSaldoFinal.Name = "lblSaldoFinal";
            this.lblSaldoFinal.Size = new System.Drawing.Size(67, 20);
            this.lblSaldoFinal.TabIndex = 39;
            this.lblSaldoFinal.Text = "Saldo: $";
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.lblEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEfectivo.Location = new System.Drawing.Point(121, 19);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(219, 29);
            this.lblEfectivo.TabIndex = 38;
            this.lblEfectivo.Text = "Retiro de efectivo";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(303, 62);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 37;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txt500
            // 
            this.txt500.Location = new System.Drawing.Point(100, 106);
            this.txt500.Name = "txt500";
            this.txt500.Size = new System.Drawing.Size(100, 20);
            this.txt500.TabIndex = 36;
            // 
            // txt200
            // 
            this.txt200.Location = new System.Drawing.Point(100, 146);
            this.txt200.Name = "txt200";
            this.txt200.Size = new System.Drawing.Size(100, 20);
            this.txt200.TabIndex = 35;
            // 
            // txt100
            // 
            this.txt100.Location = new System.Drawing.Point(100, 183);
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(100, 20);
            this.txt100.TabIndex = 34;
            // 
            // txt50
            // 
            this.txt50.Location = new System.Drawing.Point(100, 221);
            this.txt50.Name = "txt50";
            this.txt50.Size = new System.Drawing.Size(100, 20);
            this.txt50.TabIndex = 33;
            // 
            // txtRetiro
            // 
            this.txtRetiro.Location = new System.Drawing.Point(170, 64);
            this.txtRetiro.Name = "txtRetiro";
            this.txtRetiro.Size = new System.Drawing.Size(100, 20);
            this.txtRetiro.TabIndex = 32;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.Transparent;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMonto.Location = new System.Drawing.Point(25, 62);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(139, 20);
            this.lblMonto.TabIndex = 31;
            this.lblMonto.Text = "Monto a Retirar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(332, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "*saldo final";
            // 
            // lbl500
            // 
            this.lbl500.AutoSize = true;
            this.lbl500.BackColor = System.Drawing.Color.Transparent;
            this.lbl500.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl500.Location = new System.Drawing.Point(58, 110);
            this.lbl500.Name = "lbl500";
            this.lbl500.Size = new System.Drawing.Size(36, 16);
            this.lbl500.TabIndex = 46;
            this.lbl500.Text = "$500";
            // 
            // lbl200
            // 
            this.lbl200.AutoSize = true;
            this.lbl200.BackColor = System.Drawing.Color.Transparent;
            this.lbl200.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl200.Location = new System.Drawing.Point(58, 149);
            this.lbl200.Name = "lbl200";
            this.lbl200.Size = new System.Drawing.Size(36, 16);
            this.lbl200.TabIndex = 45;
            this.lbl200.Text = "$200";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.BackColor = System.Drawing.Color.Transparent;
            this.lbl100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl100.Location = new System.Drawing.Point(58, 187);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(36, 16);
            this.lbl100.TabIndex = 44;
            this.lbl100.Text = "$100";
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.BackColor = System.Drawing.Color.Transparent;
            this.lbl50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl50.Location = new System.Drawing.Point(58, 225);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(29, 16);
            this.lbl50.TabIndex = 43;
            this.lbl50.Text = "$50";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 353);
            this.Controls.Add(this.lbl500);
            this.Controls.Add(this.lbl200);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lbl50);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSaldoFinal);
            this.Controls.Add(this.lblSaldoFinal);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txt500);
            this.Controls.Add(this.txt200);
            this.Controls.Add(this.txt100);
            this.Controls.Add(this.txt50);
            this.Controls.Add(this.txtRetiro);
            this.Controls.Add(this.lblMonto);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSaldoFinal;
        private System.Windows.Forms.Label lblSaldoFinal;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txt500;
        private System.Windows.Forms.TextBox txt200;
        private System.Windows.Forms.TextBox txt100;
        private System.Windows.Forms.TextBox txt50;
        private System.Windows.Forms.TextBox txtRetiro;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl500;
        private System.Windows.Forms.Label lbl200;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl50;
    }
}