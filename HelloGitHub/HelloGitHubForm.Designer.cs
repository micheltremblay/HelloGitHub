namespace HelloGitHub
{
    partial class HelloGitHubForm
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
            this.helloButton = new System.Windows.Forms.Button();
            this.modifierButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.helloButton.Location = new System.Drawing.Point(101, 72);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(158, 54);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "Hello GitHub";
            this.helloButton.UseVisualStyleBackColor = false;
            this.helloButton.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // modifierButton
            // 
            this.modifierButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.modifierButton.Location = new System.Drawing.Point(101, 133);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.Size = new System.Drawing.Size(158, 81);
            this.modifierButton.TabIndex = 1;
            this.modifierButton.Text = "Modifier la couleur de l\'arrière-plan du formulaire";
            this.modifierButton.UseVisualStyleBackColor = false;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // HelloGitHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 226);
            this.Controls.Add(this.modifierButton);
            this.Controls.Add(this.helloButton);
            this.Name = "HelloGitHubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello GitHub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Button modifierButton;
    }
}

