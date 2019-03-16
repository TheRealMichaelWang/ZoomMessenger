namespace ZoomMessenger
{
    partial class ComplexMessageComposer
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
            this.ToGroupBox = new System.Windows.Forms.GroupBox();
            this.ToInput = new System.Windows.Forms.TextBox();
            this.FromGroupBox = new System.Windows.Forms.GroupBox();
            this.FromInput = new System.Windows.Forms.TextBox();
            this.SubjectGroupBox = new System.Windows.Forms.GroupBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.BodyGroupBox = new System.Windows.Forms.GroupBox();
            this.Body = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ToGroupBox.SuspendLayout();
            this.FromGroupBox.SuspendLayout();
            this.SubjectGroupBox.SuspendLayout();
            this.BodyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToGroupBox
            // 
            this.ToGroupBox.Controls.Add(this.ToInput);
            this.ToGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ToGroupBox.Name = "ToGroupBox";
            this.ToGroupBox.Size = new System.Drawing.Size(790, 45);
            this.ToGroupBox.TabIndex = 0;
            this.ToGroupBox.TabStop = false;
            this.ToGroupBox.Text = "To";
            // 
            // ToInput
            // 
            this.ToInput.Location = new System.Drawing.Point(6, 19);
            this.ToInput.Name = "ToInput";
            this.ToInput.Size = new System.Drawing.Size(778, 20);
            this.ToInput.TabIndex = 0;
            // 
            // FromGroupBox
            // 
            this.FromGroupBox.Controls.Add(this.FromInput);
            this.FromGroupBox.Location = new System.Drawing.Point(12, 63);
            this.FromGroupBox.Name = "FromGroupBox";
            this.FromGroupBox.Size = new System.Drawing.Size(790, 45);
            this.FromGroupBox.TabIndex = 1;
            this.FromGroupBox.TabStop = false;
            this.FromGroupBox.Text = "From";
            // 
            // FromInput
            // 
            this.FromInput.Location = new System.Drawing.Point(6, 19);
            this.FromInput.Name = "FromInput";
            this.FromInput.Size = new System.Drawing.Size(778, 20);
            this.FromInput.TabIndex = 1;
            // 
            // SubjectGroupBox
            // 
            this.SubjectGroupBox.Controls.Add(this.Subject);
            this.SubjectGroupBox.Location = new System.Drawing.Point(12, 114);
            this.SubjectGroupBox.Name = "SubjectGroupBox";
            this.SubjectGroupBox.Size = new System.Drawing.Size(790, 45);
            this.SubjectGroupBox.TabIndex = 2;
            this.SubjectGroupBox.TabStop = false;
            this.SubjectGroupBox.Text = "Subject";
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(6, 19);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(778, 20);
            this.Subject.TabIndex = 2;
            // 
            // BodyGroupBox
            // 
            this.BodyGroupBox.Controls.Add(this.Body);
            this.BodyGroupBox.Location = new System.Drawing.Point(12, 166);
            this.BodyGroupBox.Name = "BodyGroupBox";
            this.BodyGroupBox.Size = new System.Drawing.Size(790, 181);
            this.BodyGroupBox.TabIndex = 3;
            this.BodyGroupBox.TabStop = false;
            this.BodyGroupBox.Text = "Body";
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(7, 20);
            this.Body.Multiline = true;
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(777, 151);
            this.Body.TabIndex = 3;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(727, 353);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(646, 353);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ComplexMessageComposer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 380);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.BodyGroupBox);
            this.Controls.Add(this.SubjectGroupBox);
            this.Controls.Add(this.FromGroupBox);
            this.Controls.Add(this.ToGroupBox);
            this.Name = "ComplexMessageComposer";
            this.Text = "ComplexMessageComposer";
            this.ToGroupBox.ResumeLayout(false);
            this.ToGroupBox.PerformLayout();
            this.FromGroupBox.ResumeLayout(false);
            this.FromGroupBox.PerformLayout();
            this.SubjectGroupBox.ResumeLayout(false);
            this.SubjectGroupBox.PerformLayout();
            this.BodyGroupBox.ResumeLayout(false);
            this.BodyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ToGroupBox;
        private System.Windows.Forms.TextBox ToInput;
        private System.Windows.Forms.GroupBox FromGroupBox;
        private System.Windows.Forms.TextBox FromInput;
        private System.Windows.Forms.GroupBox SubjectGroupBox;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.GroupBox BodyGroupBox;
        private System.Windows.Forms.TextBox Body;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
    }
}