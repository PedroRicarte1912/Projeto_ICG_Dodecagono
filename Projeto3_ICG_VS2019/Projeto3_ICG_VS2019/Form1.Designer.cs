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
            this.btn_cor_6 = new System.Windows.Forms.Button();
            this.btn_cor_7 = new System.Windows.Forms.Button();
            this.btn_cor_8 = new System.Windows.Forms.Button();
            this.btn_cor_9 = new System.Windows.Forms.Button();
            this.btn_cor_10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trkTranslacaoX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTranslacaoY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEscala)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cor_1
            // 
            this.btn_cor_1.BackColor = System.Drawing.Color.Red;
            this.btn_cor_1.Location = new System.Drawing.Point(17, 17);
            this.btn_cor_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cor_1.Name = "btn_cor_1";
            this.btn_cor_1.Size = new System.Drawing.Size(69, 35);
            this.btn_cor_1.TabIndex = 0;
            this.btn_cor_1.Text = "Vermelho";
            this.btn_cor_1.UseVisualStyleBackColor = false;
            this.btn_cor_1.Click += new System.EventHandler(this.btn_cor_1_Click);
            // 
            // btn_cor_2
            // 
            this.btn_cor_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btn_cor_2.Location = new System.Drawing.Point(17, 61);
            this.btn_cor_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cor_2.Name = "btn_cor_2";
            this.btn_cor_2.Size = new System.Drawing.Size(69, 35);
            this.btn_cor_2.TabIndex = 1;
            this.btn_cor_2.Text = "Verde";
            this.btn_cor_2.UseVisualStyleBackColor = false;
            this.btn_cor_2.Click += new System.EventHandler(this.btn_cor_2_Click);
            // 
            // btn_cor_3
            // 
            this.btn_cor_3.BackColor = System.Drawing.Color.Blue;
            this.btn_cor_3.Location = new System.Drawing.Point(17, 104);
            this.btn_cor_3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cor_3.Name = "btn_cor_3";
            this.btn_cor_3.Size = new System.Drawing.Size(69, 35);
            this.btn_cor_3.TabIndex = 2;
            this.btn_cor_3.Text = "Azul";
            this.btn_cor_3.UseVisualStyleBackColor = false;
            this.btn_cor_3.Click += new System.EventHandler(this.btn_cor_3_Click);
            // 
            // btn_cor_rosa
            // 
            this.btn_cor_rosa.BackColor = System.Drawing.Color.Pink;
            this.btn_cor_rosa.Location = new System.Drawing.Point(17, 147);
            this.btn_cor_rosa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cor_rosa.Name = "btn_cor_rosa";
            this.btn_cor_rosa.Size = new System.Drawing.Size(69, 35);
            this.btn_cor_rosa.TabIndex = 3;
            this.btn_cor_rosa.Text = "Rosa";
            this.btn_cor_rosa.UseVisualStyleBackColor = false;
            this.btn_cor_rosa.Click += new System.EventHandler(this.btn_cor_rosa_Click);
            // 
            // btn_cor_5
            // 
            this.btn_cor_5.BackColor = System.Drawing.Color.Yellow;
            this.btn_cor_5.Location = new System.Drawing.Point(17, 191);
            this.btn_cor_5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cor_5.Name = "btn_cor_5";
            this.btn_cor_5.Size = new System.Drawing.Size(69, 35);
            this.btn_cor_5.TabIndex = 4;
            this.btn_cor_5.Text = "Amarelo";
            this.btn_cor_5.UseVisualStyleBackColor = false;
            this.btn_cor_5.Click += new System.EventHandler(this.btn_cor_5_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_limpar.Location = new System.Drawing.Point(61, 242);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(69, 35);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lbl_translacaoX
            // 
            this.lbl_translacaoX.AutoSize = true;
            this.lbl_translacaoX.Location = new System.Drawing.Point(17, 353);
            this.lbl_translacaoX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_translacaoX.Name = "lbl_translacaoX";
            this.lbl_translacaoX.Size = new System.Drawing.Size(70, 13);
            this.lbl_translacaoX.TabIndex = 5;
            this.lbl_translacaoX.Text = "Translação X";
            // 
            // trkTranslacaoX
            // 
            this.trkTranslacaoX.Location = new System.Drawing.Point(17, 370);
            this.trkTranslacaoX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trkTranslacaoX.Maximum = 200;
            this.trkTranslacaoX.Minimum = -200;
            this.trkTranslacaoX.Name = "trkTranslacaoX";
            this.trkTranslacaoX.Size = new System.Drawing.Size(276, 45);
            this.trkTranslacaoX.TabIndex = 6;
            this.trkTranslacaoX.TickFrequency = 50;
            this.trkTranslacaoX.Scroll += new System.EventHandler(this.trkTranslacaoX_Scroll);
            // 
            // lbl_translacaoY
            // 
            this.lbl_translacaoY.AutoSize = true;
            this.lbl_translacaoY.Location = new System.Drawing.Point(17, 413);
            this.lbl_translacaoY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_translacaoY.Name = "lbl_translacaoY";
            this.lbl_translacaoY.Size = new System.Drawing.Size(70, 13);
            this.lbl_translacaoY.TabIndex = 7;
            this.lbl_translacaoY.Text = "Translação Y";
            // 
            // trkTranslacaoY
            // 
            this.trkTranslacaoY.Location = new System.Drawing.Point(17, 431);
            this.trkTranslacaoY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trkTranslacaoY.Maximum = 200;
            this.trkTranslacaoY.Minimum = -200;
            this.trkTranslacaoY.Name = "trkTranslacaoY";
            this.trkTranslacaoY.Size = new System.Drawing.Size(276, 45);
            this.trkTranslacaoY.TabIndex = 8;
            this.trkTranslacaoY.TickFrequency = 50;
            this.trkTranslacaoY.Scroll += new System.EventHandler(this.trkTranslacaoY_Scroll);
            // 
            // lbl_escala
            // 
            this.lbl_escala.AutoSize = true;
            this.lbl_escala.Location = new System.Drawing.Point(17, 474);
            this.lbl_escala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_escala.Name = "lbl_escala";
            this.lbl_escala.Size = new System.Drawing.Size(39, 13);
            this.lbl_escala.TabIndex = 9;
            this.lbl_escala.Text = "Escala";
            // 
            // trkEscala
            // 
            this.trkEscala.Location = new System.Drawing.Point(17, 491);
            this.trkEscala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trkEscala.Maximum = 200;
            this.trkEscala.Minimum = 50;
            this.trkEscala.Name = "trkEscala";
            this.trkEscala.Size = new System.Drawing.Size(276, 45);
            this.trkEscala.TabIndex = 10;
            this.trkEscala.TickFrequency = 25;
            this.trkEscala.Value = 100;
            this.trkEscala.Scroll += new System.EventHandler(this.trkEscala_Scroll);
            // 
            // btn_cor_6
            // 
            this.btn_cor_6.BackColor = System.Drawing.Color.Purple;
            this.btn_cor_6.Location = new System.Drawing.Point(109, 17);
            this.btn_cor_6.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cor_6.Name = "btn_cor_6";
            this.btn_cor_6.Size = new System.Drawing.Size(69, 35);
            this.btn_cor_6.TabIndex = 12;
            this.btn_cor_6.Text = "Roxo";
            this.btn_cor_6.UseVisualStyleBackColor = false;
            this.btn_cor_6.Click += new System.EventHandler(this.btn_cor_6_Click_1);
            // 
            // btn_cor_7
            // 
            this.btn_cor_7.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_cor_7.Location = new System.Drawing.Point(109, 61);
            this.btn_cor_7.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cor_7.Name = "btn_cor_7";
            this.btn_cor_7.Size = new System.Drawing.Size(69, 35);
            this.btn_cor_7.TabIndex = 13;
            this.btn_cor_7.Text = "Verde Água";
            this.btn_cor_7.UseVisualStyleBackColor = false;
            this.btn_cor_7.Click += new System.EventHandler(this.btn_cor_7_Click_1);
            // 
            // btn_cor_8
            // 
            this.btn_cor_8.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_cor_8.Location = new System.Drawing.Point(109, 104);
            this.btn_cor_8.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cor_8.Name = "btn_cor_8";
            this.btn_cor_8.Size = new System.Drawing.Size(69, 35);
            this.btn_cor_8.TabIndex = 14;
            this.btn_cor_8.Text = "Laranja";
            this.btn_cor_8.UseVisualStyleBackColor = false;
            this.btn_cor_8.Click += new System.EventHandler(this.btn_cor_8_Click_1);
            // 
            // btn_cor_9
            // 
            this.btn_cor_9.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_cor_9.Location = new System.Drawing.Point(109, 147);
            this.btn_cor_9.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cor_9.Name = "btn_cor_9";
            this.btn_cor_9.Size = new System.Drawing.Size(69, 35);
            this.btn_cor_9.TabIndex = 15;
            this.btn_cor_9.Text = "Marrom";
            this.btn_cor_9.UseVisualStyleBackColor = false;
            this.btn_cor_9.Click += new System.EventHandler(this.btn_cor_9_Click_1);
            // 
            // btn_cor_10
            // 
            this.btn_cor_10.BackColor = System.Drawing.Color.HotPink;
            this.btn_cor_10.Location = new System.Drawing.Point(109, 191);
            this.btn_cor_10.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cor_10.Name = "btn_cor_10";
            this.btn_cor_10.Size = new System.Drawing.Size(78, 35);
            this.btn_cor_10.TabIndex = 16;
            this.btn_cor_10.Text = "Rosa Menos Claro";
            this.btn_cor_10.UseVisualStyleBackColor = false;
            this.btn_cor_10.Click += new System.EventHandler(this.btn_cor_10_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 563);
            this.Controls.Add(this.btn_cor_10);
            this.Controls.Add(this.btn_cor_9);
            this.Controls.Add(this.btn_cor_8);
            this.Controls.Add(this.btn_cor_7);
            this.Controls.Add(this.btn_cor_6);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btn_cor_6;
        private System.Windows.Forms.Button btn_cor_7;
        private System.Windows.Forms.Button btn_cor_8;
        private System.Windows.Forms.Button btn_cor_9;
        private System.Windows.Forms.Button btn_cor_10;
    }
}