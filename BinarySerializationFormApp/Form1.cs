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

namespace BinarySerializationFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MemoryStream memoryStream = new MemoryStream();

        byte[] imageArray = new byte[64];   //Can be considered as a buffer size, we specified transaction rate (64 byte) at a time.  

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Choose an image file";
            openFileDialog1.Filter = "JPG Files | *.jpg";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = string.Empty;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate);
                while (fileStream.Read(imageArray, 0, imageArray.Length) != 0)  //while filestream keeps reading image array as 64 bytes packages
                {
                    memoryStream.Write(imageArray, 0, imageArray.Length);
                }
                fileStream.Close();
                fileStream.Dispose();
                pictureBox1.Image = new Bitmap(memoryStream);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(memoryStream.Length == 0)
            {
                pictureBox1.Image = null;
                MessageBox.Show("ERROR: There is no opened image with memory stream object in RAM!");
                return;     //Important
                //using return has meaning of indicating the life span of the current scope ended.
                //no need to use for else block.
            }

            try
            {
                saveFileDialog1.Title = "Saving Process";
                saveFileDialog1.Filter = "(*.jpg) | *.jpg";
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string fileNameGuid = Guid.NewGuid().ToString();
                fileNameGuid = fileNameGuid.Replace("-", "");
                saveFileDialog1.FileName = fileNameGuid;
                


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fileStream = File.Create(saveFileDialog1.FileName))
                    {
                        memoryStream.Seek(0, SeekOrigin.Begin);
                        while (memoryStream.Read(imageArray, 0, imageArray.Length) != 0)
                        {
                            fileStream.Write(imageArray, 0, imageArray.Length);
                        }
                        MessageBox.Show($"Image has been saved to your computer.\nPath: {saveFileDialog1.FileName}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
