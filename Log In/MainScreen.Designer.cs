namespace Log_In
{
    partial class MainScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.signButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(422, 425);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(49, 36);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.IndianRed;
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.Location = new System.Drawing.Point(171, 267);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(116, 36);
            this.infoButton.TabIndex = 6;
            this.infoButton.Text = "About Us";
            this.infoButton.UseVisualStyleBackColor = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe WP Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(30, 40);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(413, 37);
            this.welcomeLabel.TabIndex = 5;
            this.welcomeLabel.Text = "Welcome to Far Far Away Dating";
            // 
            // signButton
            // 
            this.signButton.BackColor = System.Drawing.Color.IndianRed;
            this.signButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signButton.ForeColor = System.Drawing.Color.White;
            this.signButton.Location = new System.Drawing.Point(171, 177);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(116, 36);
            this.signButton.TabIndex = 4;
            this.signButton.Text = "Sign In";
            this.signButton.UseVisualStyleBackColor = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.signButton);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button signButton;
    }
}
