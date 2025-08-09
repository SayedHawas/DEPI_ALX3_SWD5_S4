using System.Text;

namespace IO_Demos
{
    public partial class Form1 : Form
    {
        /*
         ********************************************************
         DriveInfo, Directory , DirectoryInfo ,File ,FileInfo
         ********************************************************
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Drive = DriveInfo.GetDrives();
            foreach (var drive in Drive)
            {
                if (drive.IsReady == true && drive.DriveType == DriveType.Fixed)
                    comboBox1.Items.Add(drive.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo Di = new DriveInfo(comboBox1.Text);

            //string Result = "";
            //Result += Di.Name + Environment.NewLine;
            //Result += Di.DriveFormat + Environment.NewLine;
            //Result += Di.TotalSize / 1024 / 1024 / 1024 + " GB " + Environment.NewLine;
            //Result += Di.AvailableFreeSpace / 1024 / 1024 / 1024 + " GB " + Environment.NewLine;
            //label2.Text = Result;

            string Result = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Di.Name + Environment.NewLine);
            stringBuilder.Append(Di.DriveFormat + Environment.NewLine);
            stringBuilder.Append(Di.TotalSize / 1024 / 1024 / 1024 + " GB " + Environment.NewLine);
            stringBuilder.Append(Di.AvailableFreeSpace / 1024 / 1024 / 1024 + " GB " + Environment.NewLine);
            Result = stringBuilder.ToString();
            label2.Text = Result;
            //static class
            string[] Folders = Directory.GetDirectories(comboBox1.Text);
            listBox1.Items.Clear();
            foreach (string Folder in Folders)
            {
                listBox1.Items.Add(Folder);
            }
            //NonStatic
            //DirectoryInfo Di = new DirectoryInfo("");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            string[] FilesName = Directory.GetFiles(listBox1.Text);
            listBox2.Items.Clear();
            foreach (string File in FilesName)
            {
                listBox2.Items.Add(File);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = listBox2.Text;
            FileInfo Fi = new FileInfo(listBox2.Text);

            string Result = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Name : " + Fi.Name + Environment.NewLine);
            stringBuilder.Append("Extension : " + Fi.Extension + Environment.NewLine);
            stringBuilder.Append(Fi.FullName + Environment.NewLine);
            stringBuilder.Append("Create Date : " + Fi.CreationTimeUtc + Environment.NewLine);
            Result = stringBuilder.ToString();
            label5.Text = Result;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(comboBox1.Text + "/NewFolderFromApp"))
            {
                Directory.CreateDirectory(comboBox1.Text + "/NewFolderFromApp");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(comboBox1.Text + "/NewFolderFromApp"))
            {
                Directory.Delete(comboBox1.Text + "/NewFolderFromApp");
                MessageBox.Show("Folder Deleted ....");
            }
            else
            {
                MessageBox.Show("Folder Not Found ...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // to create file By FileStream
            FileStream fs = new FileStream(@"D:\Sayed1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // to read the File 
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(richTextBox1.Text);

            sw.Close();
            richTextBox1.Text = string.Empty;
            MessageBox.Show("Saving  ....");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // to create file By FileStream
            FileStream fs = new FileStream(@"D:\Sayed1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // to read the File 
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();

            sr.Close();
            MessageBox.Show("Open ....");
        }
    }
}
