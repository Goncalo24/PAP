namespace Race_Cars
{
    partial class Resultados
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
            this.lblPon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMoedas = new System.Windows.Forms.Label();
            this.btnCont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score: ";
            // 
            // lblPon
            // 
            this.lblPon.AutoSize = true;
            this.lblPon.Location = new System.Drawing.Point(122, 46);
            this.lblPon.Name = "lblPon";
            this.lblPon.Size = new System.Drawing.Size(0, 13);
            this.lblPon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moedas:";
            // 
            // lblMoedas
            // 
            this.lblMoedas.AutoSize = true;
            this.lblMoedas.Location = new System.Drawing.Point(122, 78);
            this.lblMoedas.Name = "lblMoedas";
            this.lblMoedas.Size = new System.Drawing.Size(0, 13);
            this.lblMoedas.TabIndex = 3;
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(71, 145);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(145, 23);
            this.btnCont.TabIndex = 4;
            this.btnCont.Text = "Continuar";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.lblMoedas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPon);
            this.Controls.Add(this.label1);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMoedas;
        private System.Windows.Forms.Button btnCont;
    }
}