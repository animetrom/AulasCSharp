namespace GeradorSenhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listaSenhas = new System.Windows.Forms.ListBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.count_chars = new System.Windows.Forms.NumericUpDown();
            this.chbMaiusculas = new System.Windows.Forms.CheckBox();
            this.chbNumeros = new System.Windows.Forms.CheckBox();
            this.chbSimbolos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.count_chars)).BeginInit();
            this.SuspendLayout();
            // 
            // listaSenhas
            // 
            this.listaSenhas.FormattingEnabled = true;
            this.listaSenhas.Location = new System.Drawing.Point(1, 0);
            this.listaSenhas.Name = "listaSenhas";
            this.listaSenhas.Size = new System.Drawing.Size(248, 329);
            this.listaSenhas.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(255, 278);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(133, 39);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "GERAR SENHAS";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N° de Caracteres";
            // 
            // count_chars
            // 
            this.count_chars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_chars.Location = new System.Drawing.Point(255, 25);
            this.count_chars.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.count_chars.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.count_chars.Name = "count_chars";
            this.count_chars.Size = new System.Drawing.Size(93, 26);
            this.count_chars.TabIndex = 3;
            this.count_chars.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // chbMaiusculas
            // 
            this.chbMaiusculas.AutoSize = true;
            this.chbMaiusculas.Location = new System.Drawing.Point(255, 57);
            this.chbMaiusculas.Name = "chbMaiusculas";
            this.chbMaiusculas.Size = new System.Drawing.Size(120, 17);
            this.chbMaiusculas.TabIndex = 4;
            this.chbMaiusculas.Text = "Usar MAIÚSCULAS";
            this.chbMaiusculas.UseVisualStyleBackColor = true;
            // 
            // chbNumeros
            // 
            this.chbNumeros.AutoSize = true;
            this.chbNumeros.Location = new System.Drawing.Point(255, 80);
            this.chbNumeros.Name = "chbNumeros";
            this.chbNumeros.Size = new System.Drawing.Size(106, 17);
            this.chbNumeros.TabIndex = 5;
            this.chbNumeros.Text = "Usar NÚMEROS";
            this.chbNumeros.UseVisualStyleBackColor = true;
            // 
            // chbSimbolos
            // 
            this.chbSimbolos.AutoSize = true;
            this.chbSimbolos.Location = new System.Drawing.Point(255, 103);
            this.chbSimbolos.Name = "chbSimbolos";
            this.chbSimbolos.Size = new System.Drawing.Size(106, 17);
            this.chbSimbolos.TabIndex = 6;
            this.chbSimbolos.Text = "Usar SÍMBOLOS";
            this.chbSimbolos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 329);
            this.Controls.Add(this.chbSimbolos);
            this.Controls.Add(this.chbNumeros);
            this.Controls.Add(this.chbMaiusculas);
            this.Controls.Add(this.count_chars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.listaSenhas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Senhas";
            ((System.ComponentModel.ISupportInitialize)(this.count_chars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaSenhas;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown count_chars;
        private System.Windows.Forms.CheckBox chbMaiusculas;
        private System.Windows.Forms.CheckBox chbNumeros;
        private System.Windows.Forms.CheckBox chbSimbolos;
    }
}

