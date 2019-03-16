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
            this.WriteComplexMessageButton = new System.Windows.Forms.Button();
            this.ReadComplexMessageButton = new System.Windows.Forms.Button();
            this.GetTalkInfoButton = new System.Windows.Forms.Button();
            this.StartStopAutoRefreshButton = new System.Windows.Forms.Button();
            this.TalkGroupBox.SuspendLayout();
            this.MessagingGroupBox.SuspendLayout();
            this.ToolsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageQueue
            // 
            this.MessageQueue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MessageQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageQueue.Cursor = System.Windows.Forms.Cursors.Default;
            this.MessageQueue.FormattingEnabled = true;
            this.MessageQueue.Location = new System.Drawing.Point(3, 55);
            this.MessageQueue.Name = "MessageQueue";
            this.MessageQueue.ScrollAlwaysVisible = true;
            this.MessageQueue.Size = new System.Drawing.Size(1069, 390);
            this.MessageQueue.TabIndex = 0;
            this.MessageQueue.SelectedValueChanged += new System.EventHandler(this.MessageQueue_SelectedValueChanged);
            // 
            // MessageInput
            // 
            this.MessageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageInput.Location = new System.Drawing.Point(3, 457);
            this.MessageInput.Name = "MessageInput";
            this.MessageInput.Size = new System.Drawing.Size(984, 20);
            this.MessageInput.TabIndex = 1;
            this.MessageInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageInput_KeyDown);
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(993, 454);
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
            this.EndTalkButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EndTalkButton.Location = new System.Drawing.Point(249, 16);
            this.EndTalkButton.Name = "EndTalkButton";
            this.EndTalkButton.Size = new System.Drawing.Size(75, 23);
            this.EndTalkButton.TabIndex = 3;
            this.EndTalkButton.Text = "EndTalk";
            this.EndTalkButton.UseVisualStyleBackColor = false;
            this.EndTalkButton.Click += new System.EventHandler(this.EndTalkButton_Click);
            // 
            // CreateTalkButton
            // 
            this.CreateTalkButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CreateTalkButton.Location = new System.Drawing.Point(168, 16);
            this.CreateTalkButton.Name = "CreateTalkButton";
            this.CreateTalkButton.Size = new System.Drawing.Size(75, 23);
            this.CreateTalkButton.TabIndex = 2;
            this.CreateTalkButton.Text = "CreateTalk";
            this.CreateTalkButton.UseVisualStyleBackColor = false;
            this.CreateTalkButton.Click += new System.EventHandler(this.CreateTalkButton_Click);
            // 
            // QuitTalkButton
            // 
            this.QuitTalkButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.QuitTalkButton.Location = new System.Drawing.Point(87, 16);
            this.QuitTalkButton.Name = "QuitTalkButton";
            this.QuitTalkButton.Size = new System.Drawing.Size(75, 23);
            this.QuitTalkButton.TabIndex = 1;
            this.QuitTalkButton.Text = "QuitTalk";
            this.QuitTalkButton.UseVisualStyleBackColor = false;
            this.QuitTalkButton.Click += new System.EventHandler(this.QuitTalkButton_Click);
            // 
            // JoinTalkButton
            // 
            this.JoinTalkButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.JoinTalkButton.Location = new System.Drawing.Point(6, 16);
            this.JoinTalkButton.Name = "JoinTalkButton";
            this.JoinTalkButton.Size = new System.Drawing.Size(75, 23);
            this.JoinTalkButton.TabIndex = 0;
            this.JoinTalkButton.Text = "JoinTalk";
            this.JoinTalkButton.UseVisualStyleBackColor = false;
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
            this.RefreshButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RefreshButton.Location = new System.Drawing.Point(7, 16);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ClearMessages
            // 
            this.ClearMessages.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClearMessages.Location = new System.Drawing.Point(88, 16);
            this.ClearMessages.Name = "ClearMessages";
            this.ClearMessages.Size = new System.Drawing.Size(75, 23);
            this.ClearMessages.TabIndex = 1;
            this.ClearMessages.Text = "Clear";
            this.ClearMessages.UseVisualStyleBackColor = false;
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
            this.ChangeNameButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ChangeNameButton.Location = new System.Drawing.Point(6, 16);
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.Size = new System.Drawing.Size(87, 23);
            this.ChangeNameButton.TabIndex = 0;
            this.ChangeNameButton.Text = "ChangeName";
            this.ChangeNameButton.UseVisualStyleBackColor = false;
            this.ChangeNameButton.Click += new System.EventHandler(this.ChangeNameButton_Click);
            // 
            // ToolsGroupBox
            // 
            this.ToolsGroupBox.Controls.Add(this.WriteComplexMessageButton);
            this.ToolsGroupBox.Controls.Add(this.ReadComplexMessageButton);
            this.ToolsGroupBox.Controls.Add(this.GetTalkInfoButton);
            this.ToolsGroupBox.Controls.Add(this.StartStopAutoRefreshButton);
            this.ToolsGroupBox.Controls.Add(this.ChangeNameButton);
            this.ToolsGroupBox.Location = new System.Drawing.Point(515, 1);
            this.ToolsGroupBox.Name = "ToolsGroupBox";
            this.ToolsGroupBox.Size = new System.Drawing.Size(557, 45);
            this.ToolsGroupBox.TabIndex = 7;
            this.ToolsGroupBox.TabStop = false;
            this.ToolsGroupBox.Text = "Tools";
            // 
            // WriteComplexMessageButton
            // 
            this.WriteComplexMessageButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.WriteComplexMessageButton.Location = new System.Drawing.Point(422, 16);
            this.WriteComplexMessageButton.Name = "WriteComplexMessageButton";
            this.WriteComplexMessageButton.Size = new System.Drawing.Size(131, 23);
            this.WriteComplexMessageButton.TabIndex = 4;
            this.WriteComplexMessageButton.Text = "WriteComplexMessage";
            this.WriteComplexMessageButton.UseVisualStyleBackColor = false;
            this.WriteComplexMessageButton.Click += new System.EventHandler(this.WriteComplexMessageButton_Click);
            // 
            // ReadComplexMessageButton
            // 
            this.ReadComplexMessageButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ReadComplexMessageButton.Location = new System.Drawing.Point(286, 16);
            this.ReadComplexMessageButton.Name = "ReadComplexMessageButton";
            this.ReadComplexMessageButton.Size = new System.Drawing.Size(130, 23);
            this.ReadComplexMessageButton.TabIndex = 3;
            this.ReadComplexMessageButton.Text = "ReadComplexMessage";
            this.ReadComplexMessageButton.UseVisualStyleBackColor = false;
            this.ReadComplexMessageButton.Click += new System.EventHandler(this.ReadComplexMessageButton_Click);
            // 
            // GetTalkInfoButton
            // 
            this.GetTalkInfoButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.GetTalkInfoButton.Location = new System.Drawing.Point(204, 16);
            this.GetTalkInfoButton.Name = "GetTalkInfoButton";
            this.GetTalkInfoButton.Size = new System.Drawing.Size(75, 23);
            this.GetTalkInfoButton.TabIndex = 2;
            this.GetTalkInfoButton.Text = "Info";
            this.GetTalkInfoButton.UseVisualStyleBackColor = false;
            this.GetTalkInfoButton.Click += new System.EventHandler(this.GetTalkInfoButton_Click);
            // 
            // StartStopAutoRefreshButton
            // 
            this.StartStopAutoRefreshButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.StartStopAutoRefreshButton.Location = new System.Drawing.Point(99, 16);
            this.StartStopAutoRefreshButton.Name = "StartStopAutoRefreshButton";
            this.StartStopAutoRefreshButton.Size = new System.Drawing.Size(99, 23);
            this.StartStopAutoRefreshButton.TabIndex = 1;
            this.StartStopAutoRefreshButton.Text = "StopAutoRefresh";
            this.StartStopAutoRefreshButton.UseVisualStyleBackColor = false;
            this.StartStopAutoRefreshButton.Click += new System.EventHandler(this.StartStopAutoRefreshButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1073, 480);
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
        private System.Windows.Forms.Button ReadComplexMessageButton;
        private System.Windows.Forms.Button WriteComplexMessageButton;
    }
}

