namespace SecureNotepad
{
    partial class FindReplaceFrm
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
            this.actionLabel = new System.Windows.Forms.Label();
            this.actionTxt = new System.Windows.Forms.TextBox();
            this.actionBtn = new System.Windows.Forms.Button();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(12, 23);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(75, 13);
            this.actionLabel.TabIndex = 0;
            this.actionLabel.Text = "Text to search";
            // 
            // actionTxt
            // 
            this.actionTxt.Location = new System.Drawing.Point(98, 23);
            this.actionTxt.Name = "actionTxt";
            this.actionTxt.Size = new System.Drawing.Size(175, 20);
            this.actionTxt.TabIndex = 1;
            // 
            // actionBtn
            // 
            this.actionBtn.Location = new System.Drawing.Point(305, 23);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(75, 23);
            this.actionBtn.TabIndex = 2;
            this.actionBtn.Text = "Search";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.AutoSize = true;
            this.matchCaseCheckBox.Location = new System.Drawing.Point(15, 65);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(86, 17);
            this.matchCaseCheckBox.TabIndex = 3;
            this.matchCaseCheckBox.Text = "Exact Match";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceAllBtn
            // 
            this.replaceAllBtn.Location = new System.Drawing.Point(305, 56);
            this.replaceAllBtn.Name = "replaceAllBtn";
            this.replaceAllBtn.Size = new System.Drawing.Size(75, 23);
            this.replaceAllBtn.TabIndex = 4;
            this.replaceAllBtn.Text = "Replace All";
            this.replaceAllBtn.UseVisualStyleBackColor = true;
            this.replaceAllBtn.Click += new System.EventHandler(this.ReplaceAllBtn_Click);
            // 
            // FindReplaceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 91);
            this.Controls.Add(this.replaceAllBtn);
            this.Controls.Add(this.matchCaseCheckBox);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.actionTxt);
            this.Controls.Add(this.actionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FindReplaceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindReplaceFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.TextBox actionTxt;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
        private System.Windows.Forms.Button replaceAllBtn;
    }
}