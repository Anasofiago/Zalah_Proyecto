namespace Proyecto_Zalah
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.CodAcc = new System.Windows.Forms.TextBox();
            this.btnform2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblMarca.Location = new System.Drawing.Point(268, 70);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(172, 41);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Z  A  L  A  H";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(272, 124);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(166, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "R e g i s t r o   d e   c l i e n t e s";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblCodigo.Location = new System.Drawing.Point(299, 177);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(98, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código de acceso";
            // 
            // CodAcc
            // 
            this.CodAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(243)))));
            this.CodAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodAcc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CodAcc.Location = new System.Drawing.Point(249, 212);
            this.CodAcc.Name = "CodAcc";
            this.CodAcc.PasswordChar = '*';
            this.CodAcc.Size = new System.Drawing.Size(208, 25);
            this.CodAcc.TabIndex = 3;
            this.CodAcc.TextChanged += new System.EventHandler(this.CodAcc_TextChanged);
            // 
            // btnform2
            // 
            this.btnform2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnform2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnform2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnform2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnform2.ForeColor = System.Drawing.Color.White;
            this.btnform2.Location = new System.Drawing.Point(293, 257);
            this.btnform2.Name = "btnform2";
            this.btnform2.Size = new System.Drawing.Size(121, 30);
            this.btnform2.TabIndex = 4;
            this.btnform2.Text = "Ingresar";
            this.btnform2.UseVisualStyleBackColor = false;
            this.btnform2.Click += new System.EventHandler(this.btnform2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnform2);
            this.Controls.Add(this.CodAcc);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblMarca);
            this.Name = "Form1";
            this.Text = "Zalah — Acceso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>


        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox CodAcc;
        private System.Windows.Forms.Button btnform2;
        private System.Windows.Forms.Label lblSubtitulo;
    }
}

