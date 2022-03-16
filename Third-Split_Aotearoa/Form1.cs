using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Third_Split_Aotearoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_splitMP3.Enabled = false;
            openFileDialog.Multiselect = true;
        }

        private void split_file(string pathToFile) 
        {
            Cursor.Current = Cursors.WaitCursor;
            string strMP3SourceFilename = pathToFile;              
            string strMP3OutputFilename = getFileName(pathToFile);

            //use filename as foldername without the extension mp3
            string strMP3OutputFolder = $"{strMP3SourceFilename.Substring(0, strMP3SourceFilename.Length - 4)}\\";

            //create Directory if it does not exist -> base is the given filename
            if (!Directory.Exists(strMP3OutputFolder))
            {
                Directory.CreateDirectory(strMP3OutputFolder);
            }

            using (Mp3FileReader reader = new Mp3FileReader(strMP3SourceFilename))
            {
                int count = 1;
                int fragment = 1;
                string zeroPadding = "00";
                Mp3Frame mp3Frame = reader.ReadNextFrame();
                System.IO.FileStream _fs = new System.IO.FileStream(strMP3OutputFolder + zeroPadding + fragment + " " + strMP3OutputFilename, System.IO.FileMode.Create, System.IO.FileAccess.Write);

                //double audioLengthInSeconds = (double)mp3Frame.SampleCount / mp3Frame.SampleRate; //how long is a frame -> to use for user to set time instead of frame
                //Console.WriteLine(audioLengthInSeconds.ToString());
                int frameIndex = convertSecondsToFrame(mp3Frame.SampleCount, mp3Frame.SampleRate);

                while (mp3Frame != null)
                {
                    if (count % frameIndex == 0) //retrieve a sample of frames ToDo: -> base on the frame on the kbit/s to let user define by time instead of frame
                    {
                        fragment++;
                        if (fragment > 9)   { zeroPadding = "0"; }
                        if (fragment > 99 ) { zeroPadding = "" ; }
                        _fs.Close();
                        _fs = new System.IO.FileStream(strMP3OutputFolder + zeroPadding + fragment + " " + strMP3OutputFilename, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                        
                    }
                    _fs.Write(mp3Frame.RawData, 0, mp3Frame.RawData.Length);

                    count++;
                    mp3Frame = reader.ReadNextFrame();
                }

                _fs.Close();
            }
        }

        private void button_folderDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                label_chosenFolder.Text = folderBrowserDialog.SelectedPath;
                showMP3FileOnList();
            }
        }

        private void button_addFiles_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    listBox_folderContents.Items.Add(file);
                }
                    
                button_splitMP3.Enabled = true;
            }
        }

        private void showMP3FileOnList()
        {
            string[] files = { };
            files = Directory.GetFiles(label_chosenFolder.Text);

            foreach( string file in files )
            {
                if (file.Contains(".mp3"))
                {
                    listBox_folderContents.Items.Add(file);
                }
            }
            button_splitMP3.Enabled = true;
        }

        private void button_splitMP3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            button_splitMP3.Enabled = false;

            foreach (string mp3 in listBox_folderContents.Items)
            {
                split_file(mp3);
            }

            Cursor.Current = Cursors.Default;
            button_splitMP3.Enabled = true;
        }

        private string getFileName(string pathToFile)
        {
            int lastSlash = pathToFile.LastIndexOf('\\');
            
            return pathToFile.Substring(lastSlash+1, pathToFile.Length-lastSlash-1);
        }

        private int convertSecondsToFrame(int sampleCount, int sampleRate)
        {
            int givenSeconds = Int32.Parse(textBox_splitSize.Text);

            double frameLengthInSeconds = (double)sampleCount / (double)sampleRate;
            double framesConverted = Convert.ToDouble(givenSeconds) / frameLengthInSeconds;

            int Value = Convert.ToInt32(framesConverted);

            return Value;
        }

        private void button_emptyList_Click(object sender, EventArgs e)
        {
            listBox_folderContents.Items.Clear();
        }
    }
}
