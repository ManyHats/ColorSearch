using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSearch
{
    public partial class Form1 : Form
    {
        private string[] filePathsJPG;
        private string[] filePathsPNG;
        private int maxImageSize = 1000;
        private ImageList il = new ImageList();
        private List<string> filenames = new List<string>();
        private Process proc = Process.GetCurrentProcess();

        public Form1()
        {
            InitializeComponent();
            il.ImageSize = new Size(128, 128);
            il.ColorDepth = ColorDepth.Depth32Bit;
            //HasColor(Color.Red);
        }

        private void SearchFolder()
        {
            filePathsJPG = Directory.GetFiles(FolderPathBox.Text, "*.jpg");
            filePathsPNG = Directory.GetFiles(FolderPathBox.Text, "*.png");
            // Copy paths together into a single array
            var filePaths = new string[filePathsJPG.Length + filePathsPNG.Length];
            filePathsJPG.CopyTo(filePaths, 0);
            filePathsPNG.CopyTo(filePaths, filePathsJPG.Length);

            progressBar1.Maximum = filePaths.Length;

            foreach(var p in filePaths)
            {
                LookForColor(p);
                progressBar1.Value += 1;
            }
            PopulateThumbnails();
        }

        private void LookForColor(string path)
        {
            Bitmap b = new Bitmap(path);
            RamUsage.Text = "RamUsage: " + proc.PrivateMemorySize64 / 50000 + "MB";
            if (b.Size.Height > maxImageSize || b.Size.Width > maxImageSize)
            {
                return;
            }

            for(int x = 0; x < b.Size.Width; x++)
            {
                for (int y = 0; y < b.Size.Height; y++)
                {
                    Color color = b.GetPixel(x, y);
                    if(HasColor(color))
                    {
                        il.Images.Add("test", Image.FromFile(path));
                        //ResultBox.Items.Add(Path.GetFileName(path));
                        filenames.Add(Path.GetFileName(path));
                        return;
                    }
                }
            }
        }

        private bool HasColor(Color c)
        {
            var rDist = Math.Abs(c.R - colorDialog1.Color.R);
            var gDist = Math.Abs(c.G - colorDialog1.Color.G);
            var bDist = Math.Abs(c.B - colorDialog1.Color.B);

            if (rDist + gDist + bDist > ThreshholdSlider.Value)
                return false;
            else
                return true;
        }

        private void PopulateThumbnails()
        {
            ResultBox.LargeImageList = il;
            for (int i = 0; i < il.Images.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = filenames[i];
                ResultBox.Items.Add(lvi);
            }
        }

        private void ReadyToSearch()
        {
            if(FolderPathBox.Text.Length > 0 && HexColorBox.Text.Length > 0)
            {
                SearchButton.Enabled = true;
            }
        }

        private string ConvertColorToHex(Color c)
        {
            return "0x" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2"); 
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ResultBox.Items.Clear();
            il.Images.Clear();
            progressBar1.Value = 0;

            if(HexColorBox.Text.Length != 6)
            {
                HexColorBox.Text = "";
            }
            else
            {
                SearchFolder();
            }
        }

        private void BrowseFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            FolderPathBox.Text = folderBrowserDialog1.SelectedPath;
            ReadyToSearch();
        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            string hex = ConvertColorToHex(colorDialog1.Color).ToString();
            HexColorBox.Text = hex.Substring(2);
            ReadyToSearch();
        }
    }
}
