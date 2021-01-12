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

namespace ColorSearch
{
    public partial class Form1 : Form
    {
        private string[] filePaths;
        private int offset = 32000;

        public Form1()
        {
            InitializeComponent();
            //HasColor(Color.Red);
        }

        private void SearchFolder()
        {
            filePaths = Directory.GetFiles(FolderPathBox.Text);
            progressBar1.Maximum = filePaths.Length;

            foreach(var p in filePaths)
            {
                LookForColor(p);
                progressBar1.Value += 1;
            }
        }

        private void LookForColor(string path)
        {
            Bitmap b = new Bitmap(path);
            for(int x = 0; x < b.Size.Width; x++)
            {
                for (int y = 0; y < b.Size.Height; y++)
                {
                    Color color = b.GetPixel(x, y);
                    if(HasColor(color))
                    {
                        Console.WriteLine(Path.GetFileName(path));
                        ResultBox.Items.Add(Path.GetFileName(path));
                        return;
                    }
                }
            }
        }

        private bool HasColor(Color c)
        {
            string pixelHex = ConvertColorToHex(c);
            int hexInt = Convert.ToInt32(pixelHex, 16);

            int boundLower = hexInt - offset;
            int boundHigher = hexInt + offset;

            int inputHex = Convert.ToInt32(HexColorBox.Text, 16);
            if (inputHex > boundLower && inputHex < boundHigher)
                return true;
            else
                return false;

        }

        private string ConvertColorToHex(Color c)
        {
            return "0x" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2"); 
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ResultBox.Items.Clear();
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
        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            string hex = ConvertColorToHex(colorDialog1.Color).ToString();
            HexColorBox.Text = hex.Substring(2);
        }
    }
}
