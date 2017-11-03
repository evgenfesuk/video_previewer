using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_previewer.logic
{
    public static class Preview
    {
        public static string SelectFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Video files|*.avi; *.mkv; *.m4v; *.mp4; *.mpeg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    return openFileDialog1.FileName;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else return null; ;
        }

        public static void GetFileInfo(string fileName)
        {
            // getting exif of videofile
        }
    }
}
