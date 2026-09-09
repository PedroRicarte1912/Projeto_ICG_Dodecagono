namespace Projeto3_TESTE_ICG
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.btn_cor_1 = new System.Windows.Forms.Button();
            this.btn_cor_2 = new System.Windows.Forms.Button();
            this.btn_cor_3 = new System.Windows.Forms.Button();
            this.btn_cor_rosa = new System.Windows.Forms.Button();
            this.btn_cor_5 = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lbl_translacaoX = new System.Windows.Forms.Label();
            this.trkTranslacaoX = new System.Windows.Forms.TrackBar();
            this.lbl_translacaoY = new System.Windows.Forms.Label();
            this.trkTranslacaoY = new System.Windows.Forms.TrackBar();
            this.lbl_escala = new System.Windows.Forms.Label();
            this.trkEscala = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trkTranslacaoX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTranslacaoY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEscala)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cor_1
            // 
            this.btn_cor_1.BackColor = System.Drawing.Color.Red;
            this.btn_cor_1.Location = new System.Drawing.Point(23, 21);
            this.btn_cor_1.Name = "btn_cor_1";
            this.btn_cor_1.Size = new System.Drawing.Size(92, 43);
            this.btn_cor_1.TabIndex = 0;
            this.btn_cor_1.Text = "Vermelho";
            this.btn_cor_1.UseVisualStyleBackColor = false;
            this.btn_cor_1.Click += new System.EventHandler(this.btn_cor_1_Click);
            // 
            // btn_cor_2
            // 
            this.btn_cor_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_cor_2.Location = new System.Drawing.Point(23, 75);
            this.btn_cor_2.Name = "btn_cor_2";
            this.btn_cor_2.Size = new System.Drawing.Size(92, 43);
            this.btn_cor_2.TabIndex = 1;
            this.btn_cor_2.Text = "Verde";
            this.btn_cor_2.UseVisualStyleBackColor = false;
            this.btn_cor_2.Click += new System.EventHandler(this.btn_cor_2_Click);
            // 
            // btn_cor_3
            // 
            this.btn_cor_3.BackColor = System.Drawing.Color.Blue;
            this.btn_cor_3.Location = new System.Drawing.Point(23, 128);
            this.btn_cor_3.Name = "btn_cor_3";
            this.btn_cor_3.Size = new System.Drawing.Size(92, 43);
            this.btn_cor_3.TabIndex = 2;
            this.btn_cor_3.Text = "Azul";
            this.btn_cor_3.UseVisualStyleBackColor = false;
            this.btn_cor_3.Click += new System.EventHandler(this.btn_cor_3_Click);
            // 
            // btn_cor_rosa
            // 
            this.btn_cor_rosa.BackColor = System.Drawing.Color.Pink;
            this.btn_cor_rosa.Location = new System.Drawing.Point(23, 181);
            this.btn_cor_rosa.Name = "btn_cor_rosa";
            this.btn_cor_rosa.Size = new System.Drawing.Size(92, 43);
            this.btn_cor_rosa.TabIndex = 3;
            this.btn_cor_rosa.Text = "Rosa";
            this.btn_cor_rosa.UseVisualStyleBackColor = false;
            this.btn_cor_rosa.Click += new System.EventHandler(this.btn_cor_rosa_Click);
            // 
            // btn_cor_5
            // 
            this.btn_cor_5.BackColor = System.Drawing.Color.Yellow;
            this.btn_cor_5.Location = new System.Drawing.Point(23, 235);
            this.btn_cor_5.Name = "btn_cor_5";
            this.btn_cor_5.Size = new System.Drawing.Size(92, 43);
            this.btn_cor_5.TabIndex = 4;
            this.btn_cor_5.Text = "Amarelo";
            this.btn_cor_5.UseVisualStyleBackColor = false;
            this.btn_cor_5.Click += new System.EventHandler(this.btn_cor_5_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_limpar.Location = new System.Drawing.Point(23, 288);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(92, 43);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lbl_translacaoX
            // 
            this.lbl_translacaoX.AutoSize = true;
            this.lbl_translacaoX.Location = new System.Drawing.Point(23, 434);
            this.lbl_translacaoX.Name = "lbl_translacaoX";
            this.lbl_translacaoX.Size = new System.Drawing.Size(92, 17);
            this.lbl_translacaoX.TabIndex = 5;
            this.lbl_translacaoX.Text = "Translação X";
            // 
            // trkTranslacaoX
            // 
            this.trkTranslacaoX.Location = new System.Drawing.Point(23, 455);
            this.trkTranslacaoX.Maximum = 200;
            this.trkTranslacaoX.Minimum = -200;
            this.trkTranslacaoX.Name = "trkTranslacaoX";
            this.trkTranslacaoX.Size = new System.Drawing.Size(368, 56);
            this.trkTranslacaoX.TabIndex = 6;
            this.trkTranslacaoX.TickFrequency = 50;
            this.trkTranslacaoX.Scroll += new System.EventHandler(this.trkTranslacaoX_Scroll);
            // 
            // lbl_translacaoY
            // 
            this.lbl_translacaoY.AutoSize = true;
            this.lbl_translacaoY.Location = new System.Drawing.Point(23, 508);
            this.lbl_translacaoY.Name = "lbl_translacaoY";
            this.lbl_translacaoY.Size = new System.Drawing.Size(92, 17);
            this.lbl_translacaoY.TabIndex = 7;
            this.lbl_translacaoY.Text = "Translação Y";
            // 
            // trkTranslacaoY
            // 
            this.trkTranslacaoY.Location = new System.Drawing.Point(23, 530);
            this.trkTranslacaoY.Maximum = 200;
            this.trkTranslacaoY.Minimum = -200;
            this.trkTranslacaoY.Name = "trkTranslacaoY";
            this.trkTranslacaoY.Size = new System.Drawing.Size(368, 56);
            this.trkTranslacaoY.TabIndex = 8;
            this.trkTranslacaoY.TickFrequency = 50;
            this.trkTranslacaoY.Scroll += new System.EventHandler(this.trkTranslacaoY_Scroll);
            // 
            // lbl_escala
            // 
            this.lbl_escala.AutoSize = true;
            this.lbl_escala.Location = new System.Drawing.Point(23, 583);
            this.lbl_escala.Name = "lbl_escala";
            this.lbl_escala.Size = new System.Drawing.Size(50, 17);
            this.lbl_escala.TabIndex = 9;
            this.lbl_escala.Text = "Escala";
            // 
            // trkEscala
            // 
            this.trkEscala.Location = new System.Drawing.Point(23, 604);
            this.trkEscala.Maximum = 200;
            this.trkEscala.Minimum = 50;
            this.trkEscala.Name = "trkEscala";
            this.trkEscala.Size = new System.Drawing.Size(368, 56);
            this.trkEscala.TabIndex = 10;
            this.trkEscala.TickFrequency = 25;
            this.trkEscala.Value = 100;
            this.trkEscala.Scroll += new System.EventHandler(this.trkEscala_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 693);
            this.Controls.Add(this.btn_cor_1);
            this.Controls.Add(this.btn_cor_2);
            this.Controls.Add(this.btn_cor_3);
            this.Controls.Add(this.btn_cor_rosa);
            this.Controls.Add(this.btn_cor_5);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_translacaoX);
            this.Controls.Add(this.trkTranslacaoX);
            this.Controls.Add(this.lbl_translacaoY);
            this.Controls.Add(this.trkTranslacaoY);
            this.Controls.Add(this.lbl_escala);
            this.Controls.Add(this.trkEscala);
            this.Name = "Form1";
            this.Text = "Icosaedro 2D - Projeto3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkTranslacaoX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTranslacaoY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEscala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cor_1;
        private System.Windows.Forms.Button btn_cor_2;
        private System.Windows.Forms.Button btn_cor_3;
        private System.Windows.Forms.Button btn_cor_rosa;
        private System.Windows.Forms.Button btn_cor_5;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_translacaoX;
        private System.Windows.Forms.TrackBar trkTranslacaoX;
        private System.Windows.Forms.Label lbl_translacaoY;
        private System.Windows.Forms.TrackBar trkTranslacaoY;
        private System.Windows.Forms.Label lbl_escala;
        private System.Windows.Forms.TrackBar trkEscala;
    }
}