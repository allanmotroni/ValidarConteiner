namespace ValidarConteiner
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.buttonValidar = new System.Windows.Forms.Button();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.buttonGerarDigito = new System.Windows.Forms.Button();
            this.textBoxNumeroSemDigito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConteinerComDigitoGerado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNumero.Location = new System.Drawing.Point(111, 22);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNumero.MaxLength = 11;
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(139, 29);
            this.textBoxNumero.TabIndex = 1;
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(262, 18);
            this.buttonValidar.Margin = new System.Windows.Forms.Padding(6);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(94, 34);
            this.buttonValidar.TabIndex = 2;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // labelMensagem
            // 
            this.labelMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMensagem.Location = new System.Drawing.Point(8, 67);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(383, 25);
            this.labelMensagem.TabIndex = 3;
            this.labelMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGerarDigito
            // 
            this.buttonGerarDigito.Location = new System.Drawing.Point(263, 104);
            this.buttonGerarDigito.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGerarDigito.Name = "buttonGerarDigito";
            this.buttonGerarDigito.Size = new System.Drawing.Size(121, 34);
            this.buttonGerarDigito.TabIndex = 6;
            this.buttonGerarDigito.Text = "Gerar Dígito";
            this.buttonGerarDigito.UseVisualStyleBackColor = true;
            this.buttonGerarDigito.Click += new System.EventHandler(this.buttonGerarDigito_Click);
            // 
            // textBoxNumeroSemDigito
            // 
            this.textBoxNumeroSemDigito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNumeroSemDigito.Location = new System.Drawing.Point(112, 108);
            this.textBoxNumeroSemDigito.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNumeroSemDigito.MaxLength = 10;
            this.textBoxNumeroSemDigito.Name = "textBoxNumeroSemDigito";
            this.textBoxNumeroSemDigito.Size = new System.Drawing.Size(139, 29);
            this.textBoxNumeroSemDigito.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número:";
            // 
            // textBoxConteinerComDigitoGerado
            // 
            this.textBoxConteinerComDigitoGerado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxConteinerComDigitoGerado.Location = new System.Drawing.Point(112, 142);
            this.textBoxConteinerComDigitoGerado.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxConteinerComDigitoGerado.MaxLength = 11;
            this.textBoxConteinerComDigitoGerado.Name = "textBoxConteinerComDigitoGerado";
            this.textBoxConteinerComDigitoGerado.ReadOnly = true;
            this.textBoxConteinerComDigitoGerado.Size = new System.Drawing.Size(139, 29);
            this.textBoxConteinerComDigitoGerado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonValidar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 186);
            this.Controls.Add(this.textBoxConteinerComDigitoGerado);
            this.Controls.Add(this.buttonGerarDigito);
            this.Controls.Add(this.textBoxNumeroSemDigito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.buttonValidar);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validar contêiner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Button buttonValidar;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.Button buttonGerarDigito;
        private System.Windows.Forms.TextBox textBoxNumeroSemDigito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConteinerComDigitoGerado;
    }
}

