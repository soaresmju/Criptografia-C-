namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCriptografa = new System.Windows.Forms.Label();
            this.lblDescriptografa = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtDescriptografada = new System.Windows.Forms.TextBox();
            this.txtCriptografada = new System.Windows.Forms.TextBox();
            this.btnCriptografa = new System.Windows.Forms.Button();
            this.btnDescriptografa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(43, 31);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            // 
            // lblCriptografa
            // 
            this.lblCriptografa.AutoSize = true;
            this.lblCriptografa.Location = new System.Drawing.Point(14, 69);
            this.lblCriptografa.Name = "lblCriptografa";
            this.lblCriptografa.Size = new System.Drawing.Size(70, 13);
            this.lblCriptografa.TabIndex = 1;
            this.lblCriptografa.Text = "Criptografada";
            // 
            // lblDescriptografa
            // 
            this.lblDescriptografa.AutoSize = true;
            this.lblDescriptografa.Location = new System.Drawing.Point(-4, 95);
            this.lblDescriptografa.Name = "lblDescriptografa";
            this.lblDescriptografa.Size = new System.Drawing.Size(88, 13);
            this.lblDescriptografa.TabIndex = 2;
            this.lblDescriptografa.Text = "Descriptografada";
            this.lblDescriptografa.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(90, 28);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(190, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtDescriptografada
            // 
            this.txtDescriptografada.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescriptografada.Location = new System.Drawing.Point(90, 92);
            this.txtDescriptografada.Name = "txtDescriptografada";
            this.txtDescriptografada.Size = new System.Drawing.Size(190, 20);
            this.txtDescriptografada.TabIndex = 4;
            // 
            // txtCriptografada
            // 
            this.txtCriptografada.Location = new System.Drawing.Point(90, 62);
            this.txtCriptografada.Name = "txtCriptografada";
            this.txtCriptografada.Size = new System.Drawing.Size(190, 20);
            this.txtCriptografada.TabIndex = 5;
            // 
            // btnCriptografa
            // 
            this.btnCriptografa.Location = new System.Drawing.Point(90, 130);
            this.btnCriptografa.Name = "btnCriptografa";
            this.btnCriptografa.Size = new System.Drawing.Size(75, 23);
            this.btnCriptografa.TabIndex = 6;
            this.btnCriptografa.Text = "Criptografar";
            this.btnCriptografa.UseVisualStyleBackColor = true;
            this.btnCriptografa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDescriptografa
            // 
            this.btnDescriptografa.Location = new System.Drawing.Point(181, 130);
            this.btnDescriptografa.Name = "btnDescriptografa";
            this.btnDescriptografa.Size = new System.Drawing.Size(99, 23);
            this.btnDescriptografa.TabIndex = 7;
            this.btnDescriptografa.Text = "Descriptografar";
            this.btnDescriptografa.UseVisualStyleBackColor = true;
            this.btnDescriptografa.Click += new System.EventHandler(this.btnDescriptografa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 192);
            this.Controls.Add(this.btnDescriptografa);
            this.Controls.Add(this.btnCriptografa);
            this.Controls.Add(this.txtCriptografada);
            this.Controls.Add(this.txtDescriptografada);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblDescriptografa);
            this.Controls.Add(this.lblCriptografa);
            this.Controls.Add(this.lblSenha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCriptografa;
        private System.Windows.Forms.Label lblDescriptografa;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtDescriptografada;
        private System.Windows.Forms.TextBox txtCriptografada;
        private System.Windows.Forms.Button btnCriptografa;
        private System.Windows.Forms.Button btnDescriptografa;
    }
}

