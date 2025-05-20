namespace TicTacToe
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
            this.PicbTicTacToe = new System.Windows.Forms.PictureBox();
            this.PicbReset = new System.Windows.Forms.PictureBox();
            this.PicbSair = new System.Windows.Forms.PictureBox();
            this.PicbLogo = new System.Windows.Forms.PictureBox();
            this.Btn11 = new System.Windows.Forms.Button();
            this.Btn12 = new System.Windows.Forms.Button();
            this.Btn13 = new System.Windows.Forms.Button();
            this.Btn22 = new System.Windows.Forms.Button();
            this.Btn21 = new System.Windows.Forms.Button();
            this.Btn23 = new System.Windows.Forms.Button();
            this.Btn31 = new System.Windows.Forms.Button();
            this.Btn32 = new System.Windows.Forms.Button();
            this.Btn33 = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicbTicTacToe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicbReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PicbTicTacToe
            // 
            this.PicbTicTacToe.BackColor = System.Drawing.Color.Transparent;
            this.PicbTicTacToe.Image = global::TicTacToe.Properties.Resources._tictactoe;
            this.PicbTicTacToe.Location = new System.Drawing.Point(51, 77);
            this.PicbTicTacToe.Name = "PicbTicTacToe";
            this.PicbTicTacToe.Size = new System.Drawing.Size(600, 465);
            this.PicbTicTacToe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicbTicTacToe.TabIndex = 20;
            this.PicbTicTacToe.TabStop = false;
            // 
            // PicbReset
            // 
            this.PicbReset.BackColor = System.Drawing.Color.Transparent;
            this.PicbReset.Image = global::TicTacToe.Properties.Resources.Reset__1_;
            this.PicbReset.Location = new System.Drawing.Point(586, 4);
            this.PicbReset.Name = "PicbReset";
            this.PicbReset.Size = new System.Drawing.Size(48, 41);
            this.PicbReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicbReset.TabIndex = 19;
            this.PicbReset.TabStop = false;
            this.PicbReset.Click += new System.EventHandler(this.PicbReset_Click);
            // 
            // PicbSair
            // 
            this.PicbSair.BackColor = System.Drawing.Color.Transparent;
            this.PicbSair.Image = global::TicTacToe.Properties.Resources.sair1;
            this.PicbSair.Location = new System.Drawing.Point(640, 4);
            this.PicbSair.Name = "PicbSair";
            this.PicbSair.Size = new System.Drawing.Size(52, 41);
            this.PicbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicbSair.TabIndex = 18;
            this.PicbSair.TabStop = false;
            this.PicbSair.Click += new System.EventHandler(this.PicbSair_Click);
            // 
            // PicbLogo
            // 
            this.PicbLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicbLogo.Image = global::TicTacToe.Properties.Resources.tttmarqlrg1;
            this.PicbLogo.Location = new System.Drawing.Point(218, 13);
            this.PicbLogo.Name = "PicbLogo";
            this.PicbLogo.Size = new System.Drawing.Size(240, 58);
            this.PicbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicbLogo.TabIndex = 17;
            this.PicbLogo.TabStop = false;
            // 
            // Btn11
            // 
            this.Btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn11.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn11.Location = new System.Drawing.Point(156, 127);
            this.Btn11.Name = "Btn11";
            this.Btn11.Size = new System.Drawing.Size(111, 92);
            this.Btn11.TabIndex = 21;
            this.Btn11.UseVisualStyleBackColor = true;
            this.Btn11.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // Btn12
            // 
            this.Btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn12.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn12.Location = new System.Drawing.Point(295, 127);
            this.Btn12.Name = "Btn12";
            this.Btn12.Size = new System.Drawing.Size(111, 92);
            this.Btn12.TabIndex = 22;
            this.Btn12.UseVisualStyleBackColor = true;
            this.Btn12.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // Btn13
            // 
            this.Btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn13.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn13.Location = new System.Drawing.Point(434, 127);
            this.Btn13.Name = "Btn13";
            this.Btn13.Size = new System.Drawing.Size(111, 92);
            this.Btn13.TabIndex = 23;
            this.Btn13.UseVisualStyleBackColor = true;
            this.Btn13.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // Btn22
            // 
            this.Btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn22.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn22.Location = new System.Drawing.Point(295, 267);
            this.Btn22.Name = "Btn22";
            this.Btn22.Size = new System.Drawing.Size(111, 92);
            this.Btn22.TabIndex = 24;
            this.Btn22.UseVisualStyleBackColor = true;
            this.Btn22.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // Btn21
            // 
            this.Btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn21.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn21.Location = new System.Drawing.Point(156, 267);
            this.Btn21.Name = "Btn21";
            this.Btn21.Size = new System.Drawing.Size(111, 92);
            this.Btn21.TabIndex = 25;
            this.Btn21.UseVisualStyleBackColor = true;
            this.Btn21.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // Btn23
            // 
            this.Btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn23.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn23.Location = new System.Drawing.Point(434, 267);
            this.Btn23.Name = "Btn23";
            this.Btn23.Size = new System.Drawing.Size(111, 92);
            this.Btn23.TabIndex = 26;
            this.Btn23.UseVisualStyleBackColor = true;
            this.Btn23.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // Btn31
            // 
            this.Btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn31.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn31.Location = new System.Drawing.Point(154, 401);
            this.Btn31.Name = "Btn31";
            this.Btn31.Size = new System.Drawing.Size(111, 92);
            this.Btn31.TabIndex = 27;
            this.Btn31.UseVisualStyleBackColor = true;
            this.Btn31.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // Btn32
            // 
            this.Btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn32.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn32.Location = new System.Drawing.Point(293, 401);
            this.Btn32.Name = "Btn32";
            this.Btn32.Size = new System.Drawing.Size(111, 92);
            this.Btn32.TabIndex = 28;
            this.Btn32.UseVisualStyleBackColor = true;
            this.Btn32.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // Btn33
            // 
            this.Btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn33.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn33.Location = new System.Drawing.Point(432, 401);
            this.Btn33.Name = "Btn33";
            this.Btn33.Size = new System.Drawing.Size(111, 92);
            this.Btn33.TabIndex = 29;
            this.Btn33.UseVisualStyleBackColor = true;
            this.Btn33.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.ForeColor = System.Drawing.Color.Red;
            this.LblInfo.Location = new System.Drawing.Point(18, 22);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(159, 31);
            this.LblInfo.TabIndex = 30;
            this.LblInfo.Text = "É a vez do X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 564);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.Btn33);
            this.Controls.Add(this.Btn32);
            this.Controls.Add(this.Btn31);
            this.Controls.Add(this.Btn23);
            this.Controls.Add(this.Btn21);
            this.Controls.Add(this.Btn22);
            this.Controls.Add(this.Btn13);
            this.Controls.Add(this.Btn12);
            this.Controls.Add(this.Btn11);
            this.Controls.Add(this.PicbTicTacToe);
            this.Controls.Add(this.PicbReset);
            this.Controls.Add(this.PicbSair);
            this.Controls.Add(this.PicbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicbTicTacToe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicbReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PicbLogo;
        private System.Windows.Forms.PictureBox PicbSair;
        private System.Windows.Forms.PictureBox PicbReset;
        private System.Windows.Forms.PictureBox PicbTicTacToe;
        private System.Windows.Forms.Button Btn11;
        private System.Windows.Forms.Button Btn12;
        private System.Windows.Forms.Button Btn13;
        private System.Windows.Forms.Button Btn22;
        private System.Windows.Forms.Button Btn21;
        private System.Windows.Forms.Button Btn23;
        private System.Windows.Forms.Button Btn31;
        private System.Windows.Forms.Button Btn32;
        private System.Windows.Forms.Button Btn33;
        private System.Windows.Forms.Label LblInfo;
    }
}

