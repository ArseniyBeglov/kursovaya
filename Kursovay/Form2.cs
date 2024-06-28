using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovay
{
    public partial class Form2 : Form
    {
        public Form2(string text)
        {
            InitializeComponent();
            textBox1.Text = text;
        }
        // сохранение картинки(которая будет генерироваться) в определенном формате(потом переделаю под .SVG)
        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) 
            {
                
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                
                savedialog.OverwritePrompt = true;
                
                savedialog.CheckPathExists = true;
                
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|Image Files(*.SVG)|*.SVG|All files (*.*)|*.*";
                
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) 
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                       
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        
    }
}
