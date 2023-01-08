
namespace MediaAlunoOOP
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPortugues = new System.Windows.Forms.Label();
            this.lblMatematica = new System.Windows.Forms.Label();
            this.lblCiencia = new System.Windows.Forms.Label();
            this.textBoxPortugues = new System.Windows.Forms.TextBox();
            this.textBoxMatematica = new System.Windows.Forms.TextBox();
            this.textBoxCiencia = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClique = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(86, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(248, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcule Média do Aluno";
            // 
            // lblPortugues
            // 
            this.lblPortugues.AutoSize = true;
            this.lblPortugues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPortugues.Location = new System.Drawing.Point(28, 110);
            this.lblPortugues.Name = "lblPortugues";
            this.lblPortugues.Size = new System.Drawing.Size(88, 21);
            this.lblPortugues.TabIndex = 1;
            this.lblPortugues.Text = "Portugues: ";
            // 
            // lblMatematica
            // 
            this.lblMatematica.AutoSize = true;
            this.lblMatematica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMatematica.Location = new System.Drawing.Point(22, 187);
            this.lblMatematica.Name = "lblMatematica";
            this.lblMatematica.Size = new System.Drawing.Size(94, 21);
            this.lblMatematica.TabIndex = 2;
            this.lblMatematica.Text = "Matemática:";
            // 
            // lblCiencia
            // 
            this.lblCiencia.AutoSize = true;
            this.lblCiencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCiencia.Location = new System.Drawing.Point(22, 261);
            this.lblCiencia.Name = "lblCiencia";
            this.lblCiencia.Size = new System.Drawing.Size(63, 21);
            this.lblCiencia.TabIndex = 3;
            this.lblCiencia.Text = "Ciência:";
            // 
            // textBoxPortugues
            // 
            this.textBoxPortugues.Location = new System.Drawing.Point(30, 134);
            this.textBoxPortugues.Name = "textBoxPortugues";
            this.textBoxPortugues.Size = new System.Drawing.Size(135, 23);
            this.textBoxPortugues.TabIndex = 4;
            // 
            // textBoxMatematica
            // 
            this.textBoxMatematica.Location = new System.Drawing.Point(28, 211);
            this.textBoxMatematica.Name = "textBoxMatematica";
            this.textBoxMatematica.Size = new System.Drawing.Size(137, 23);
            this.textBoxMatematica.TabIndex = 5;
            // 
            // textBoxCiencia
            // 
            this.textBoxCiencia.Location = new System.Drawing.Point(28, 285);
            this.textBoxCiencia.Name = "textBoxCiencia";
            this.textBoxCiencia.Size = new System.Drawing.Size(137, 23);
            this.textBoxCiencia.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnClique
            // 
            this.btnClique.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClique.Location = new System.Drawing.Point(47, 385);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(97, 37);
            this.btnClique.TabIndex = 8;
            this.btnClique.Text = "Clique";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(158, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(270, 385);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(97, 37);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnClique);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxCiencia);
            this.Controls.Add(this.textBoxMatematica);
            this.Controls.Add(this.textBoxPortugues);
            this.Controls.Add(this.lblCiencia);
            this.Controls.Add(this.lblMatematica);
            this.Controls.Add(this.lblPortugues);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Média Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPortugues;
        private System.Windows.Forms.Label lblMatematica;
        private System.Windows.Forms.Label lblCiencia;
        private System.Windows.Forms.TextBox textBoxPortugues;
        private System.Windows.Forms.TextBox textBoxMatematica;
        private System.Windows.Forms.TextBox textBoxCiencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClique;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
    }
}