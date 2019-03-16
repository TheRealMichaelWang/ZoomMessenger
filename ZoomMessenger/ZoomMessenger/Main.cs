using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZoomMessenger
{
    public partial class Main : Form
    {
        public Messenger messenger;
        public TalkNameStorage talkNameStorage;
        public string currenttalk = "";
        public string name = Environment.UserName;
        public string[] messages = null;

        public Main()
        {
            InitializeComponent();
            messenger = new Messenger();
            talkNameStorage = new TalkNameStorage();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public void RefreshMessageQueue()
        {
            if (!string.IsNullOrEmpty(currenttalk))
            {
                MessageQueue.Items.Clear();
                string[] messages = messenger.getMessages(currenttalk);
                foreach (string message in messages)
                {
                    if(message.Contains("‰"))
                    {
                        try
                        {
                            ComplexMessage cm = ComplexMessage.ParseDataString(message);
                            if (cm.to == name || cm.from == name)
                            {
                                MessageQueue.Items.Add("↓↓↓To read this complex message below, use the read complex message button↓↓↓");
                                MessageQueue.Items.Add(message);
                            }
                        }
                        catch
                        {

                        }
                    }
                    else if(message.Contains("startapp>"))
                    {
                        MessageQueue.Items.Add("↓↓↓Click the message below to start it↓↓↓");
                        MessageQueue.Items.Add(message);
                    }
                    else
                    {
                        MessageQueue.Items.Add(message);
                    }
                }
                MessageQueue.TopIndex = MessageQueue.Items.Count - 1;
                if(this.messages != null)
                {
                    if(this.messages != messages)
                    {
                        RefreshTimer.Enabled = false;
                        MessageBox.Show("Changes to the talk have been made.","Zoom Messenger",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        RefreshTimer.Enabled = true;
                    }
                }
                this.messages = messages;
            }
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(currenttalk))
                {
                    MessageBox.Show("We are sending your message. This may take a little while.", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!MessageInput.Text.Contains('‰'))
                    {
                        messenger.sendMessage(currenttalk, name + ": " + MessageInput.Text);
                    }
                    else
                    {
                        messenger.sendMessage(currenttalk, MessageInput.Text);
                    }
                    MessageInput.Text = "";
                    MessageBox.Show("Message sent", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshMessageQueue();
                }
                else
                {
                    MessageBox.Show("Please join a talk", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("That talk doesn't exist. The talk may have been ended.", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Prompt prompt = new Prompt("Enter talk name", talkNameStorage.SelectTalk());
            if (!string.IsNullOrEmpty(prompt.output))
            {
                if (prompt.output == "general forum")
                {
                    MessageBox.Show("Please do not use inappropriate language or say bad things because this the general forum. Everyone can view it and it cannot be cleared", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                MessageBox.Show("We are joining the talk. This may take a little while.", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (messenger.talkExists(prompt.output))
                {
                    MessageBox.Show("talk joined", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currenttalk = prompt.output;
                    talkNameStorage.AddTalk(currenttalk);
                    RefreshMessageQueue();
                }
                else
                {
                    MessageBox.Show("That talk doesn't exist. The talk may have been ended.", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    talkNameStorage.DelTalk(prompt.output);
                }
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
                    talkNameStorage.AddTalk(currenttalk);
                }
                else
                {
                    MessageBox.Show("That talk already exists", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    talkNameStorage.DelTalk(prompt.output);
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
            if (!string.IsNullOrEmpty(currenttalk))
            {
                if (MessageBox.Show("If you end this talk, it will no longer be joinable.", "Are you sure you want to end this talk?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    messenger.endTalk(currenttalk);
                    talkNameStorage.DelTalk(currenttalk);
                    currenttalk = "";
                    MessageQueue.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please join a talk", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshMessageQueue();
            if(string.IsNullOrEmpty(currenttalk))
            {
                MessageBox.Show("Please join a talk", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    string selected = (string)MessageQueue.SelectedItem;
                    if (selected == "↓↓↓To read this complex message below, use the read complex message button↓↓↓" || selected == "↓↓↓Click the message below to start it↓↓↓")
                    {
                        MessageBox.Show("That's a label. Not a message", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        MessageQueue.SelectedItem = null;
                        return;
                    }
                    MessageInput.Text = selected;
                    MessageInput.Text = MessageInput.Text.Split(":".ToCharArray())[1];
                    string[] args = MessageInput.Text.Split(' ');
                    List<string> usableargs = new List<string>();
                    foreach(string item in args)
                    {
                        if(!string.IsNullOrEmpty(item))
                        {
                            usableargs.Add(item);
                        }
                    }
                    if(usableargs[0] == "startapp>")
                    {
                        try
                        {
                            Process.Start(usableargs[1], usableargs[2]);
                        }
                        catch
                        {
                            MessageBox.Show("Unable to start that process", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
            try
            {
                if (!string.IsNullOrEmpty(currenttalk))
                {
                    if (currenttalk == "general forum")
                    {
                        MessageBox.Show("You can't clear this forum", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    messenger.clearMessages(currenttalk);
                    RefreshMessageQueue();
                }
                else
                {
                    MessageBox.Show("Please join a talk", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("That talk doesn't exist. The talk may have been ended.", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string toshow = "Zoom Messenger\n(C) Michael Wang 2019\n\nTalkname: ";
            if (!string.IsNullOrEmpty(currenttalk))
            {
                toshow = toshow + currenttalk + "\nName: ";
                toshow = toshow + name + "\nMessage Count: " + messages.Length + "\nSaved: ";
                if(talkNameStorage.talks.Contains(currenttalk))
                {
                    toshow = toshow + "Yes";
                }
                else
                {
                    toshow = toshow + "No";
                }
            }
            else
            {
                toshow = toshow + "No talk joined\nName: " + name;
            }
            toshow = toshow + "\nAutoRefresh: "+RefreshTimer.Enabled;
            toshow = toshow + "\nSaved Talk(s): " + talkNameStorage.talks.Count.ToString();
            MessageBox.Show(toshow, "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            talkNameStorage.SaveTalks();
        }

        private void ReadComplexMessageButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MessageInput.Text))
            {
                RefreshTimer.Enabled = false;
                string temp = MessageInput.Text;
                try
                {
                    ComplexMessage message = ComplexMessage.ParseDataString(temp);
                    ComplexMessageViewer viewer = new ComplexMessageViewer(message);
                }
                catch
                {
                    MessageBox.Show("That's not a complex message.", "Zoom Messenger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageQueue.SelectedItem = null;
                RefreshTimer.Enabled = true;
            }
        }

        private void WriteComplexMessageButton_Click(object sender, EventArgs e)
        {
            RefreshTimer.Enabled = false;
            ComplexMessageComposer composer = new ComplexMessageComposer(name);
            if(!composer.canceled)
            {
                MessageInput.Text = composer.output.ToDataString();
            }
            RefreshTimer.Enabled = true;
        }
    }
}