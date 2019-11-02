namespace WindowsFormsApplication1.Formularios
{
    partial class Dificil
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblMensajeIncorrectos = new System.Windows.Forms.Label();
            this.lblMensajeCorrectos = new System.Windows.Forms.Label();
            this.btnProbar = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.txtIntentos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Maroon;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(26, 11);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(326, 41);
            this.txtUsuario.TabIndex = 51;
            // 
            // lblMensajeIncorrectos
            // 
            this.lblMensajeIncorrectos.AutoSize = true;
            this.lblMensajeIncorrectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeIncorrectos.ForeColor = System.Drawing.Color.White;
            this.lblMensajeIncorrectos.Location = new System.Drawing.Point(8, 340);
            this.lblMensajeIncorrectos.Name = "lblMensajeIncorrectos";
            this.lblMensajeIncorrectos.Size = new System.Drawing.Size(361, 24);
            this.lblMensajeIncorrectos.TabIndex = 50;
            this.lblMensajeIncorrectos.Text = "Felicitaciones has ganado en 150 intentos";
            this.lblMensajeIncorrectos.Visible = false;
            // 
            // lblMensajeCorrectos
            // 
            this.lblMensajeCorrectos.AutoSize = true;
            this.lblMensajeCorrectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeCorrectos.ForeColor = System.Drawing.Color.White;
            this.lblMensajeCorrectos.Location = new System.Drawing.Point(9, 300);
            this.lblMensajeCorrectos.Name = "lblMensajeCorrectos";
            this.lblMensajeCorrectos.Size = new System.Drawing.Size(361, 24);
            this.lblMensajeCorrectos.TabIndex = 49;
            this.lblMensajeCorrectos.Text = "Felicitaciones has ganado en 150 intentos";
            this.lblMensajeCorrectos.Visible = false;
            // 
            // btnProbar
            // 
            this.btnProbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbar.Location = new System.Drawing.Point(267, 251);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(85, 44);
            this.btnProbar.TabIndex = 48;
            this.btnProbar.Text = "Probar";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Visible = false;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            this.btnProbar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnProbar_MouseClick);
            // 
            // txt4
            // 
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt4.Location = new System.Drawing.Point(293, 194);
            this.txt4.MaxLength = 1;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(59, 44);
            this.txt4.TabIndex = 47;
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4.Visible = false;
            this.txt4.TextChanged += new System.EventHandler(this.txt4_TextChanged);
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(204, 194);
            this.txt3.MaxLength = 1;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(59, 44);
            this.txt3.TabIndex = 46;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt3.Visible = false;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(115, 194);
            this.txt2.MaxLength = 1;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(59, 44);
            this.txt2.TabIndex = 45;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt2.Visible = false;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(26, 194);
            this.txt1.MaxLength = 1;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(59, 44);
            this.txt1.TabIndex = 44;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt1.Visible = false;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // btnIniciar
            // 
            this.btnIniciar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(87, 383);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(197, 42);
            this.btnIniciar.TabIndex = 43;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtNum4
            // 
            this.txtNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum4.Location = new System.Drawing.Point(292, 58);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(59, 116);
            this.txtNum4.TabIndex = 42;
            this.txtNum4.Visible = false;
            // 
            // txtNum3
            // 
            this.txtNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum3.Location = new System.Drawing.Point(203, 58);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(59, 116);
            this.txtNum3.TabIndex = 41;
            this.txtNum3.Visible = false;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(114, 58);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(59, 116);
            this.txtNum2.TabIndex = 40;
            this.txtNum2.Visible = false;
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(25, 58);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(59, 116);
            this.txtNum1.TabIndex = 39;
            this.txtNum1.Visible = false;
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.ForeColor = System.Drawing.Color.White;
            this.lblIntentos.Location = new System.Drawing.Point(120, 261);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(94, 25);
            this.lblIntentos.TabIndex = 52;
            this.lblIntentos.Text = "Intentos:";
            this.lblIntentos.Visible = false;
            // 
            // txtIntentos
            // 
            this.txtIntentos.BackColor = System.Drawing.Color.Maroon;
            this.txtIntentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntentos.ForeColor = System.Drawing.Color.White;
            this.txtIntentos.Location = new System.Drawing.Point(218, 262);
            this.txtIntentos.Multiline = true;
            this.txtIntentos.Name = "txtIntentos";
            this.txtIntentos.Size = new System.Drawing.Size(43, 21);
            this.txtIntentos.TabIndex = 53;
            this.txtIntentos.Text = "10";
            this.txtIntentos.Visible = false;
            // 
            // Dificil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(379, 437);
            this.Controls.Add(this.txtIntentos);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblMensajeIncorrectos);
            this.Controls.Add(this.lblMensajeCorrectos);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dificil";
            this.ShowIcon = false;
            this.Text = "Dificil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dificil_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblMensajeIncorrectos;
        private System.Windows.Forms.Label lblMensajeCorrectos;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblIntentos;
        public System.Windows.Forms.TextBox txtIntentos;
    }
}