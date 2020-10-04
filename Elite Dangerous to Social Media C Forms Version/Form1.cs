using LinqToTwitter;
using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Elite_Dangerous_to_Social_Media_C_Forms_Version
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            consumerKeyBox.Text = Properties.Settings.Default.consumerKey;
            consumerSecretBox.Text = Properties.Settings.Default.consumerSecret;
            accessTokenKeyBox.Text = Properties.Settings.Default.accessToken;
            accessTokenSecretBox.Text = Properties.Settings.Default.accessTokenSecret;
            logPathBox.Text = Properties.Settings.Default.logPath;

            var CurrentLogFile = NewestFileofDirectory(logPathBox.Text);
            MessageBox1.Text = "Current Config File:" + CurrentLogFile;
            currentLogFileBox.Text = CurrentLogFile;
            timer1.Start();
        }

        private void sendTestTweetButton_Click(object sender, EventArgs e)
        {
            SendTweetTextOnly("Elite Dangerous to Twitter Gateway. C# Version" + "\nLoading: " + NewestFileofDirectory(logPathBox.Text) + "\nLoading complete\nMonitoring Log\nOnline at:" + DateTime.Now);
        }
        public async void SendTweetTextOnly(string twitterMessage)
        {
            var auth = new SingleUserAuthorizer
            {
                CredentialStore = new SingleUserInMemoryCredentialStore
                {
                    ConsumerKey = Properties.Settings.Default.consumerKey,
                    ConsumerSecret = Properties.Settings.Default.consumerSecret,
                    AccessToken = Properties.Settings.Default.accessToken,
                    AccessTokenSecret = Properties.Settings.Default.accessTokenSecret
                }
            };

            var ctx = new TwitterContext(auth);
            await ctx.TweetAsync(twitterMessage);

        }
        public static string NewestFileofDirectory(string directoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            if (directoryInfo == null || !directoryInfo.Exists)
                return null;

            FileInfo[] files = directoryInfo.GetFiles("Journal*log");
            DateTime recentWrite = DateTime.MinValue;
            FileInfo recentFile = null;

            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > recentWrite)
                {
                    recentWrite = file.LastWriteTime;
                    recentFile = file;
                }
            }
            return recentFile.Name;
        }

        private void browseFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                logPathBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void logPathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.consumerKey = consumerKeyBox.Text;
            Properties.Settings.Default.consumerSecret = consumerSecretBox.Text;
            Properties.Settings.Default.accessToken = accessTokenKeyBox.Text;
            Properties.Settings.Default.accessTokenSecret = accessTokenSecretBox.Text;
            Properties.Settings.Default.logPath = logPathBox.Text;
            Properties.Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox1.AppendText(Environment.NewLine + "Timer Tick" + Environment.NewLine);
            MessageBox1.AppendText("Verify Current Log File" + Environment.NewLine);
            var UseLogFile = NewestFileofDirectory(logPathBox.Text);
            MessageBox1.AppendText("Using:" + UseLogFile + Environment.NewLine);
            if (UseLogFile.Trim() != currentLogFileBox.Text.Trim())
            {
                MessageBox1.AppendText("Log File Changed. Updating System" + Environment.NewLine);
                currentLogFileBox.Text = UseLogFile;
            }
            ReadLog(logPathBox.Text.Trim() + "/" + UseLogFile);


        }
        public void ReadLog(string logPath)
        {
            var fs = new FileStream(logPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var sr = new StreamReader(fs);
            var lineCount = 0;

            string line = String.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                lineCount += 1;
                if (lineCount > Int32.Parse(lineCountLabel.Text))
                {
                    MessageBox1.AppendText(lineCount + ":" + line + Environment.NewLine);
                    if (line.Contains("@twitter") && Int32.Parse(lineCountLabel.Text) > 0)
                    {
                        MessageBox1.AppendText("Send Message to Twitter " + Environment.NewLine);
                        DateTime now = DateTime.Now;
                        string timeString = now.ToString();
                        label1.Text = timeString;
                        dynamic json = JsonConvert.DeserializeObject(line);
                        string twitterMessage = json.Message;
                        twitterMessage = '^' + twitterMessage.Substring(1);
                        MessageBox1.AppendText("Twitter Message Sent:" + twitterMessage + Environment.NewLine);
                        var sendMessage = "EDtoTwitter Message Gateway\n\nMessage from Cockpit\n\n" + twitterMessage + "\n" + timeString;
                        MessageBox1.AppendText("Sent Message:" + sendMessage + Environment.NewLine);
                        SendTweetTextOnly(sendMessage);
                    }
                }
            }
            lineCountLabel.Text = lineCount.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
