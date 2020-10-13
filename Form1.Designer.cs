namespace MiniProjeto2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmd_executar1 = new System.Windows.Forms.Button();
            this.cmd_executar2 = new System.Windows.Forms.Button();
            this.btn_mais5 = new System.Windows.Forms.RadioButton();
            this.btn_menos5 = new System.Windows.Forms.RadioButton();
            this.caixa_texto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cmd_executar1
            // 
            this.cmd_executar1.Location = new System.Drawing.Point(51, 182);
            this.cmd_executar1.Name = "cmd_executar1";
            this.cmd_executar1.Size = new System.Drawing.Size(75, 23);
            this.cmd_executar1.TabIndex = 3;
            this.cmd_executar1.Text = "Executar";
            this.cmd_executar1.UseVisualStyleBackColor = true;
            this.cmd_executar1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd_executar2
            // 
            this.cmd_executar2.Location = new System.Drawing.Point(242, 182);
            this.cmd_executar2.Name = "cmd_executar2";
            this.cmd_executar2.Size = new System.Drawing.Size(75, 23);
            this.cmd_executar2.TabIndex = 4;
            this.cmd_executar2.Text = "Executar";
            this.cmd_executar2.UseVisualStyleBackColor = true;
            this.cmd_executar2.Click += new System.EventHandler(this.cmd_executar2_Click);
            // 
            // btn_mais5
            // 
            this.btn_mais5.AutoSize = true;
            this.btn_mais5.Checked = true;
            this.btn_mais5.Location = new System.Drawing.Point(62, 159);
            this.btn_mais5.Name = "btn_mais5";
            this.btn_mais5.Size = new System.Drawing.Size(64, 17);
            this.btn_mais5.TabIndex = 5;
            this.btn_mais5.TabStop = true;
            this.btn_mais5.Text = "Mais 5%";
            this.btn_mais5.UseVisualStyleBackColor = true;
            // 
            // btn_menos5
            // 
            this.btn_menos5.AutoSize = true;
            this.btn_menos5.Location = new System.Drawing.Point(242, 159);
            this.btn_menos5.Name = "btn_menos5";
            this.btn_menos5.Size = new System.Drawing.Size(74, 17);
            this.btn_menos5.TabIndex = 6;
            this.btn_menos5.Text = "Menos 5%";
            this.btn_menos5.UseVisualStyleBackColor = true;
            // 
            // caixa_texto
            // 
            this.caixa_texto.Location = new System.Drawing.Point(136, 204);
            this.caixa_texto.Name = "caixa_texto";
            this.caixa_texto.Size = new System.Drawing.Size(100, 20);
            this.caixa_texto.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 236);
            this.Controls.Add(this.caixa_texto);
            this.Controls.Add(this.btn_menos5);
            this.Controls.Add(this.btn_mais5);
            this.Controls.Add(this.cmd_executar2);
            this.Controls.Add(this.cmd_executar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmd_executar1;
        private System.Windows.Forms.Button cmd_executar2;
        private System.Windows.Forms.RadioButton btn_mais5;
        private System.Windows.Forms.RadioButton btn_menos5;
        private System.Windows.Forms.TextBox caixa_texto;
    }
}

