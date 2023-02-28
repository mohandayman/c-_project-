namespace Connect_4_Project
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
            this.send_button = new System.Windows.Forms.Button();
            this.New_tab = new System.Windows.Forms.Button();
            this.massegeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(528, 349);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(153, 63);
            this.send_button.TabIndex = 1;
            this.send_button.Text = "send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // New_tab
            // 
            this.New_tab.Location = new System.Drawing.Point(89, 358);
            this.New_tab.Name = "New_tab";
            this.New_tab.Size = new System.Drawing.Size(153, 54);
            this.New_tab.TabIndex = 2;
            this.New_tab.Text = "new Tab";
            this.New_tab.UseVisualStyleBackColor = true;
            this.New_tab.Click += new System.EventHandler(this.New_tab_Click);
            // 
            // massegeBox
            // 
            this.massegeBox.Location = new System.Drawing.Point(289, 180);
            this.massegeBox.Multiline = true;
            this.massegeBox.Name = "massegeBox";
            this.massegeBox.Size = new System.Drawing.Size(188, 144);
            this.massegeBox.TabIndex = 3;
            this.massegeBox.TextChanged += new System.EventHandler(this.massegeBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.massegeBox);
            this.Controls.Add(this.New_tab);
            this.Controls.Add(this.send_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button New_tab;
        private System.Windows.Forms.TextBox massegeBox;
    }
}

