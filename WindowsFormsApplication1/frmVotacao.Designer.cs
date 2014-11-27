namespace Votacao_
{
    partial class frmvotacao
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
            this.btnc1 = new System.Windows.Forms.Button();
            this.btnc2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbc1 = new System.Windows.Forms.Label();
            this.lbc2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votação";
            // 
            // btnc1
            // 
            this.btnc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc1.Location = new System.Drawing.Point(68, 96);
            this.btnc1.Name = "btnc1";
            this.btnc1.Size = new System.Drawing.Size(166, 98);
            this.btnc1.TabIndex = 1;
            this.btnc1.Text = "Candidato 1";
            this.btnc1.UseVisualStyleBackColor = true;
            this.btnc1.Click += new System.EventHandler(this.btnc1_Click);
            // 
            // btnc2
            // 
            this.btnc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc2.Location = new System.Drawing.Point(288, 96);
            this.btnc2.Name = "btnc2";
            this.btnc2.Size = new System.Drawing.Size(163, 98);
            this.btnc2.TabIndex = 2;
            this.btnc2.Text = "Candidato 2";
            this.btnc2.UseVisualStyleBackColor = true;
            this.btnc2.Click += new System.EventHandler(this.btnc2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Candidato 1 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Candidato 2 :";
            // 
            // lbc1
            // 
            this.lbc1.AutoSize = true;
            this.lbc1.Location = new System.Drawing.Point(144, 221);
            this.lbc1.Name = "lbc1";
            this.lbc1.Size = new System.Drawing.Size(43, 13);
            this.lbc1.TabIndex = 5;
            this.lbc1.Text = "0 Votos";
            // 
            // lbc2
            // 
            this.lbc2.AutoSize = true;
            this.lbc2.Location = new System.Drawing.Point(377, 221);
            this.lbc2.Name = "lbc2";
            this.lbc2.Size = new System.Drawing.Size(43, 13);
            this.lbc2.TabIndex = 6;
            this.lbc2.Text = "0 Votos";
            // 
            // frmvotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 295);
            this.Controls.Add(this.lbc2);
            this.Controls.Add(this.lbc1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnc2);
            this.Controls.Add(this.btnc1);
            this.Controls.Add(this.label1);
            this.Name = "frmvotacao";
            this.Text = "Votação";
            this.Load += new System.EventHandler(this.frmvotacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnc1;
        private System.Windows.Forms.Button btnc2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbc1;
        private System.Windows.Forms.Label lbc2;
    }
}

