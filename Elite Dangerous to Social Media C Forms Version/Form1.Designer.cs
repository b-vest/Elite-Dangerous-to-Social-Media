﻿namespace Elite_Dangerous_to_Social_Media_C_Forms_Version
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MessageBox1 = new System.Windows.Forms.TextBox();
            this.consumerKeyBox = new System.Windows.Forms.TextBox();
            this.consumerSecretBox = new System.Windows.Forms.TextBox();
            this.accessTokenKeyBox = new System.Windows.Forms.TextBox();
            this.accessTokenSecretBox = new System.Windows.Forms.TextBox();
            this.logPathBox = new System.Windows.Forms.TextBox();
            this.sendTestTweetButton = new System.Windows.Forms.Button();
            this.browseFolderButton = new System.Windows.Forms.Button();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currentLogFileBox = new System.Windows.Forms.TextBox();
            this.lineCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageBox1
            // 
            this.MessageBox1.Location = new System.Drawing.Point(809, 48);
            this.MessageBox1.Multiline = true;
            this.MessageBox1.Name = "MessageBox1";
            this.MessageBox1.Size = new System.Drawing.Size(587, 642);
            this.MessageBox1.TabIndex = 0;
            // 
            // consumerKeyBox
            // 
            this.consumerKeyBox.Location = new System.Drawing.Point(44, 48);
            this.consumerKeyBox.Name = "consumerKeyBox";
            this.consumerKeyBox.Size = new System.Drawing.Size(286, 26);
            this.consumerKeyBox.TabIndex = 1;
            // 
            // consumerSecretBox
            // 
            this.consumerSecretBox.Location = new System.Drawing.Point(44, 129);
            this.consumerSecretBox.Name = "consumerSecretBox";
            this.consumerSecretBox.Size = new System.Drawing.Size(286, 26);
            this.consumerSecretBox.TabIndex = 2;
            // 
            // accessTokenKeyBox
            // 
            this.accessTokenKeyBox.Location = new System.Drawing.Point(44, 215);
            this.accessTokenKeyBox.Name = "accessTokenKeyBox";
            this.accessTokenKeyBox.Size = new System.Drawing.Size(286, 26);
            this.accessTokenKeyBox.TabIndex = 3;
            // 
            // accessTokenSecretBox
            // 
            this.accessTokenSecretBox.Location = new System.Drawing.Point(44, 305);
            this.accessTokenSecretBox.Name = "accessTokenSecretBox";
            this.accessTokenSecretBox.Size = new System.Drawing.Size(286, 26);
            this.accessTokenSecretBox.TabIndex = 4;
            // 
            // logPathBox
            // 
            this.logPathBox.Location = new System.Drawing.Point(44, 427);
            this.logPathBox.Name = "logPathBox";
            this.logPathBox.Size = new System.Drawing.Size(286, 26);
            this.logPathBox.TabIndex = 5;
            this.logPathBox.TextChanged += new System.EventHandler(this.logPathBox_TextChanged);
            // 
            // sendTestTweetButton
            // 
            this.sendTestTweetButton.AutoEllipsis = true;
            this.sendTestTweetButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.sendTestTweetButton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.sendTestTweetButton.FlatAppearance.BorderSize = 10;
            this.sendTestTweetButton.Location = new System.Drawing.Point(380, 725);
            this.sendTestTweetButton.Name = "sendTestTweetButton";
            this.sendTestTweetButton.Size = new System.Drawing.Size(197, 52);
            this.sendTestTweetButton.TabIndex = 6;
            this.sendTestTweetButton.Text = "Send Test Tweet";
            this.sendTestTweetButton.UseVisualStyleBackColor = true;
            this.sendTestTweetButton.Click += new System.EventHandler(this.sendTestTweetButton_Click);
            // 
            // browseFolderButton
            // 
            this.browseFolderButton.Location = new System.Drawing.Point(69, 472);
            this.browseFolderButton.Name = "browseFolderButton";
            this.browseFolderButton.Size = new System.Drawing.Size(201, 58);
            this.browseFolderButton.TabIndex = 7;
            this.browseFolderButton.Text = "Browse for Log Folder";
            this.browseFolderButton.UseVisualStyleBackColor = true;
            this.browseFolderButton.Click += new System.EventHandler(this.browseFolderButton_Click);
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(69, 647);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(201, 56);
            this.saveSettingsButton.TabIndex = 8;
            this.saveSettingsButton.Text = "Save Settings";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // currentLogFileBox
            // 
            this.currentLogFileBox.Location = new System.Drawing.Point(809, 725);
            this.currentLogFileBox.Name = "currentLogFileBox";
            this.currentLogFileBox.ReadOnly = true;
            this.currentLogFileBox.Size = new System.Drawing.Size(587, 26);
            this.currentLogFileBox.TabIndex = 9;
            // 
            // lineCountLabel
            // 
            this.lineCountLabel.AutoSize = true;
            this.lineCountLabel.Location = new System.Drawing.Point(809, 13);
            this.lineCountLabel.Name = "lineCountLabel";
            this.lineCountLabel.Size = new System.Drawing.Size(18, 20);
            this.lineCountLabel.TabIndex = 10;
            this.lineCountLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Timestamp Last Tweet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Gatweway Tweet Sent at";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1424, 806);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineCountLabel);
            this.Controls.Add(this.currentLogFileBox);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.browseFolderButton);
            this.Controls.Add(this.sendTestTweetButton);
            this.Controls.Add(this.logPathBox);
            this.Controls.Add(this.accessTokenSecretBox);
            this.Controls.Add(this.accessTokenKeyBox);
            this.Controls.Add(this.consumerSecretBox);
            this.Controls.Add(this.consumerKeyBox);
            this.Controls.Add(this.MessageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageBox1;
        private System.Windows.Forms.TextBox consumerKeyBox;
        private System.Windows.Forms.TextBox consumerSecretBox;
        private System.Windows.Forms.TextBox accessTokenKeyBox;
        private System.Windows.Forms.TextBox accessTokenSecretBox;
        private System.Windows.Forms.TextBox logPathBox;
        private System.Windows.Forms.Button sendTestTweetButton;
        private System.Windows.Forms.Button browseFolderButton;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox currentLogFileBox;
        private System.Windows.Forms.Label lineCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

