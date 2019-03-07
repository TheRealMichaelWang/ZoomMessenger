using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZoomMessenger
{
    public partial class Main : Form
    {
        public Messenger messenger;
        public string currenttalk = "";
        public string name = Environment.UserName;

        public Main()
        {
            InitializeComponent();
            messenger = new Messenger();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public void RefreshMessageQueue()
        {
            if (!string.IsNullOrEmpty(currenttalk))
            {
                MessageBox.Show("We are refreshing. This may take a little while.", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageQueue.Items.Clear();
                string[] messages = messenger.getMessages(currenttalk);
                foreach (string message in messages)
                {
                    MessageQueue.Items.Add(message);
                }
                MessageQueue.TopIndex = MessageQueue.Items.Count - 1;
                MessageBox.Show("Refresh completed.", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(currenttalk))
                {
                    MessageBox.Show("We are sending your message. This may take a little while.", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messenger.sendMessage(currenttalk, name + ": " + MessageInput.Text);
                    MessageInput.Text = "";
                    MessageBox.Show("Message sent", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshMessageQueue();
                }
                else
                {
                    MessageBox.Show("Please join a talk", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MessageInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessageButton_Click(null, null);
            }
        }

        private void JoinTalkButton_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt("Enter talk name", currenttalk);
            if (!string.IsNullOrEmpty(prompt.output))

                if (prompt.output == "general forum")
                {
                    MessageBox.Show("Please do not use inappropriate language or say bad things because this the general forum. Everyone can view it and it cannot be cleared", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            MessageBox.Show("We are joining the talk. This may take a little while.", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (messenger.talkExists(prompt.output))
            {
                MessageBox.Show("talk joined", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currenttalk = prompt.output;
                RefreshMessageQueue();
            }
            else
            {
                MessageBox.Show("That talk doesn't exist. The talk may have been ended.", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void QuitTalkButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currenttalk))
            {
                currenttalk = "";
                MessageQueue.Items.Clear();
            }
            else
            {
                MessageBox.Show("Please join a talk", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CreateTalkButton_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt("Enter talk name", "");
            if (!string.IsNullOrEmpty(prompt.output))
            {
                if (!messenger.talkExists(prompt.output))
                {
                    messenger.newTalk(prompt.output);
                    currenttalk = prompt.output;
                    RefreshMessageQueue();
                }
                else
                {
                    MessageBox.Show("That talk already exists", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void EndTalkButton_Click(object sender, EventArgs e)
        {
            if (currenttalk == "general forum")
            {
                MessageBox.Show("You cannot end this talk. This is the general forum, and cannot be ended.", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (MessageBox.Show("If you end this talk, it will no longer be joinable.", "Are you sure you want to end this talk?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(currenttalk))
                {
                    messenger.endTalk(currenttalk);
                    currenttalk = "";
                    MessageQueue.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Please join a talk", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshMessageQueue();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshMessageQueue();
        }

        private void MessageQueue_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (MessageQueue.SelectedItem != null)
                {
                    MessageInput.Text = (string)MessageQueue.SelectedItem;
                    MessageInput.Text = MessageInput.Text.Split(":".ToCharArray())[1];
                    MessageQueue.SelectedItem = null;
                }
            }
            catch
            {

            }
        }

        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt("Enter a new name/aliase", name);
            if (!string.IsNullOrEmpty(prompt.output))
            {
                name = prompt.output;
            }
        }

        private void ClearMessages_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currenttalk))
            {
                messenger.clearMessages(currenttalk);
                RefreshMessageQueue();
            }
            else
            {
                MessageBox.Show("Please join a talk", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StartStopAutoRefreshButton_Click(object sender, EventArgs e)
        {
            if (RefreshTimer.Enabled == true)
            {
                RefreshTimer.Enabled = false;
                StartStopAutoRefreshButton.Text = "StartAutoRefresh";
            }
            else
            {
                RefreshTimer.Enabled = true;
                StartStopAutoRefreshButton.Text = "StopAutoRefresh";
            }
        }

        private void GetTalkInfoButton_Click(object sender, EventArgs e)
        {
            string toshow = "Talkname: ";
            if (!string.IsNullOrEmpty(currenttalk))
            {
                toshow = toshow + currenttalk + "\nName: ";
                toshow = toshow + name + "\nMessage Count: " + MessageQueue.Items.Count;
            }
            else
            {
                toshow = toshow + "No talk joined\nName: " + name;
            }
            MessageBox.Show(toshow, "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MessageQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}