namespace Race_Cars
{
    partial class Loggin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loggin));
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.llblRegisto = new System.Windows.Forms.LinkLabel();
            this.btnJA = new System.Windows.Forms.Button();
            this.btnLoggin = new System.Windows.Forms.Button();
            this.lberro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbEmail
            // 
            resources.ApplyResources(this.tbEmail, "tbEmail");
            this.tbEmail.Name = "tbEmail";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbPass
            // 
            resources.ApplyResources(this.tbPass, "tbPass");
            this.tbPass.Name = "tbPass";
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // llblRegisto
            // 
            resources.ApplyResources(this.llblRegisto, "llblRegisto");
            this.llblRegisto.Name = "llblRegisto";
            this.llblRegisto.TabStop = true;
            this.llblRegisto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegisto_LinkClicked);
            // 
            // btnJA
            // 
            this.btnJA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnJA, "btnJA");
            this.btnJA.Name = "btnJA";
            this.btnJA.UseVisualStyleBackColor = true;
            this.btnJA.Click += new System.EventHandler(this.btnJA_Click);
            // 
            // btnLoggin
            // 
            resources.ApplyResources(this.btnLoggin, "btnLoggin");
            this.btnLoggin.Name = "btnLoggin";
            this.btnLoggin.UseVisualStyleBackColor = true;
            this.btnLoggin.Click += new System.EventHandler(this.btnLoggin_Click);
            // 
            // lberro
            // 
            resources.ApplyResources(this.lberro, "lberro");
            this.lberro.Name = "lberro";
            // 
            // Loggin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnJA;
            this.Controls.Add(this.lberro);
            this.Controls.Add(this.btnJA);
            this.Controls.Add(this.llblRegisto);
            this.Controls.Add(this.btnLoggin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Loggin";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.LinkLabel llblRegisto;
        private System.Windows.Forms.Button btnJA;
        private System.Windows.Forms.Button btnLoggin;
        private System.Windows.Forms.Label lberro;
    }
}