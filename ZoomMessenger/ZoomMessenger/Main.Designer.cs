namespace ZoomMessenger
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.MessageQueue = new System.Windows.Forms.ListBox();
            this.MessageInput = new System.Windows.Forms.TextBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.TalkGroupBox = new System.Windows.Forms.GroupBox();
            this.EndTalkButton = new System.Windows.Forms.Button();
            this.CreateTalkButton = new System.Windows.Forms.Button();
            this.QuitTalkButton = new System.Windows.Forms.Button();
            this.JoinTalkButton = new System.Windows.Forms.Button();
            this.MessagingGroupBox = new System.Windows.Forms.GroupBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ClearMessages = new System.Windows.Forms.Button();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.ChangeNameButton = new System.Windows.Forms.Button();
            this.ToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.GetTalkInfoButton = new System.Windows.Forms.Button();
            this.StartStopAutoRefreshButton = new System.Windows.Forms.Button();
            this.TalkGroupBox.SuspendLayout();
            this.MessagingGroupBox.SuspendLayout();
            this.ToolsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageQueue
            // 
            this.MessageQueue.FormattingEnabled = true;
            this.MessageQueue.Location = new System.Drawing.Point(3, 55);
            this.MessageQueue.Name = "MessageQueue";
            this.MessageQueue.ScrollAlwaysVisible = true;
            this.MessageQueue.Size = new System.Drawing.Size(1000, 394);
            this.MessageQueue.TabIndex = 0;
            this.MessageQueue.SelectedValueChanged += new System.EventHandler(this.MessageQueue_SelectedValueChanged);
            // 
            // MessageInput
            // 
            this.MessageInput.Location = new System.Drawing.Point(3, 457);
            this.MessageInput.Name = "MessageInput";
            this.MessageInput.Size = new System.Drawing.Size(907, 20);
            this.MessageInput.TabIndex = 1;
            this.MessageInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageInput_KeyDown);
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(916, 454);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.SendMessageButton.TabIndex = 2;
            this.SendMessageButton.Text = "Send";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // TalkGroupBox
            // 
            this.TalkGroupBox.Controls.Add(this.EndTalkButton);
            this.TalkGroupBox.Controls.Add(this.CreateTalkButton);
            this.TalkGroupBox.Controls.Add(this.QuitTalkButton);
            this.TalkGroupBox.Controls.Add(this.JoinTalkButton);
            this.TalkGroupBox.Location = new System.Drawing.Point(3, 1);
            this.TalkGroupBox.Name = "TalkGroupBox";
            this.TalkGroupBox.Size = new System.Drawing.Size(330, 45);
            this.TalkGroupBox.TabIndex = 4;
            this.TalkGroupBox.TabStop = false;
            this.TalkGroupBox.Text = "Talk";
            // 
            // EndTalkButton
            // 
            this.EndTalkButton.Location = new System.Drawing.Point(249, 16);
            this.EndTalkButton.Name = "EndTalkButton";
            this.EndTalkButton.Size = new System.Drawing.Size(75, 23);
            this.EndTalkButton.TabIndex = 3;
            this.EndTalkButton.Text = "EndTalk";
            this.EndTalkButton.UseVisualStyleBackColor = true;
            this.EndTalkButton.Click += new System.EventHandler(this.EndTalkButton_Click);
            // 
            // CreateTalkButton
            // 
            this.CreateTalkButton.Location = new System.Drawing.Point(168, 16);
            this.CreateTalkButton.Name = "CreateTalkButton";
            this.CreateTalkButton.Size = new System.Drawing.Size(75, 23);
            this.CreateTalkButton.TabIndex = 2;
            this.CreateTalkButton.Text = "CreateTalk";
            this.CreateTalkButton.UseVisualStyleBackColor = true;
            this.CreateTalkButton.Click += new System.EventHandler(this.CreateTalkButton_Click);
            // 
            // QuitTalkButton
            // 
            this.QuitTalkButton.Location = new System.Drawing.Point(87, 16);
            this.QuitTalkButton.Name = "QuitTalkButton";
            this.QuitTalkButton.Size = new System.Drawing.Size(75, 23);
            this.QuitTalkButton.TabIndex = 1;
            this.QuitTalkButton.Text = "QuitTalk";
            this.QuitTalkButton.UseVisualStyleBackColor = true;
            this.QuitTalkButton.Click += new System.EventHandler(this.QuitTalkButton_Click);
            // 
            // JoinTalkButton
            // 
            this.JoinTalkButton.Location = new System.Drawing.Point(6, 16);
            this.JoinTalkButton.Name = "JoinTalkButton";
            this.JoinTalkButton.Size = new System.Drawing.Size(75, 23);
            this.JoinTalkButton.TabIndex = 0;
            this.JoinTalkButton.Text = "JoinTalk";
            this.JoinTalkButton.UseVisualStyleBackColor = true;
            this.JoinTalkButton.Click += new System.EventHandler(this.JoinTalkButton_Click);
            // 
            // MessagingGroupBox
            // 
            this.MessagingGroupBox.Controls.Add(this.RefreshButton);
            this.MessagingGroupBox.Controls.Add(this.ClearMessages);
            this.MessagingGroupBox.Location = new System.Drawing.Point(340, 1);
            this.MessagingGroupBox.Name = "MessagingGroupBox";
            this.MessagingGroupBox.Size = new System.Drawing.Size(169, 45);
            this.MessagingGroupBox.TabIndex = 5;
            this.MessagingGroupBox.TabStop = false;
            this.MessagingGroupBox.Text = "Messaging";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(7, 16);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ClearMessages
            // 
            this.ClearMessages.Location = new System.Drawing.Point(88, 16);
            this.ClearMessages.Name = "ClearMessages";
            this.ClearMessages.Size = new System.Drawing.Size(75, 23);
            this.ClearMessages.TabIndex = 2;
            this.ClearMessages.Text = "Clear";
            this.ClearMessages.UseVisualStyleBackColor = true;
            this.ClearMessages.Click += new System.EventHandler(this.ClearMessages_Click);
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 60000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // ChangeNameButton
            // 
            this.ChangeNameButton.Location = new System.Drawing.Point(6, 16);
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.Size = new System.Drawing.Size(87, 23);
            this.ChangeNameButton.TabIndex = 0;
            this.ChangeNameButton.Text = "ChangeName";
            this.ChangeNameButton.UseVisualStyleBackColor = true;
            this.ChangeNameButton.Click += new System.EventHandler(this.ChangeNameButton_Click);
            // 
            // ToolsGroupBox
            // 
            this.ToolsGroupBox.Controls.Add(this.GetTalkInfoButton);
            this.ToolsGroupBox.Controls.Add(this.StartStopAutoRefreshButton);
            this.ToolsGroupBox.Controls.Add(this.ChangeNameButton);
            this.ToolsGroupBox.Location = new System.Drawing.Point(515, 1);
            this.ToolsGroupBox.Name = "ToolsGroupBox";
            this.ToolsGroupBox.Size = new System.Drawing.Size(476, 45);
            this.ToolsGroupBox.TabIndex = 7;
            this.ToolsGroupBox.TabStop = false;
            this.ToolsGroupBox.Text = "Tools";
            // 
            // GetTalkInfoButton
            // 
            this.GetTalkInfoButton.Location = new System.Drawing.Point(204, 16);
            this.GetTalkInfoButton.Name = "GetTalkInfoButton";
            this.GetTalkInfoButton.Size = new System.Drawing.Size(75, 23);
            this.GetTalkInfoButton.TabIndex = 2;
            this.GetTalkInfoButton.Text = "Info";
            this.GetTalkInfoButton.UseVisualStyleBackColor = true;
            this.GetTalkInfoButton.Click += new System.EventHandler(this.GetTalkInfoButton_Click);
            // 
            // StartStopAutoRefreshButton
            // 
            this.StartStopAutoRefreshButton.Location = new System.Drawing.Point(99, 16);
            this.StartStopAutoRefreshButton.Name = "StartStopAutoRefreshButton";
            this.StartStopAutoRefreshButton.Size = new System.Drawing.Size(99, 23);
            this.StartStopAutoRefreshButton.TabIndex = 1;
            this.StartStopAutoRefreshButton.Text = "StopAutoRefresh";
            this.StartStopAutoRefreshButton.UseVisualStyleBackColor = true;
            this.StartStopAutoRefreshButton.Click += new System.EventHandler(this.StartStopAutoRefreshButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 489);
            this.Controls.Add(this.ToolsGroupBox);
            this.Controls.Add(this.MessagingGroupBox);
            this.Controls.Add(this.TalkGroupBox);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.MessageInput);
            this.Controls.Add(this.MessageQueue);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Zoom Messenger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.TalkGroupBox.ResumeLayout(false);
            this.MessagingGroupBox.ResumeLayout(false);
            this.ToolsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MessageQueue;
        private System.Windows.Forms.TextBox MessageInput;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.GroupBox TalkGroupBox;
        private System.Windows.Forms.Button JoinTalkButton;
        private System.Windows.Forms.Button QuitTalkButton;
        private System.Windows.Forms.Button EndTalkButton;
        private System.Windows.Forms.Button CreateTalkButton;
        private System.Windows.Forms.GroupBox MessagingGroupBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Button ChangeNameButton;
        private System.Windows.Forms.Button ClearMessages;
        private System.Windows.Forms.GroupBox ToolsGroupBox;
        private System.Windows.Forms.Button StartStopAutoRefreshButton;
        private System.Windows.Forms.Button GetTalkInfoButton;
    }
}

