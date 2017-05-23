using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Media;

namespace GUI_Test
{
    public partial class frmThisIs : Form
    {
        #region const and dll functions for moving form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        private GifImage gifImage = null;


        public frmThisIs()
        {
            InitializeComponent();
            //a) Normal way
            //pictureBox1.Image = Image.FromFile(filePath);

            //b) We control the animation
            gifImage = new GifImage(GUI_Test.Properties.Resources.travolta);
            gifImage.ReverseAtEnd = true; //dont reverse at end
        }

        private void frmThisIs_Load(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(global::GUI_Test.Properties.Resources.thisissparta);
            sound.Play();
        }

        private void MyMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #region Controle dos GIF's
        public class GifImage
        {
            private Image gifImage;
            private FrameDimension dimension;
            private int frameCount;
            private int currentFrame = 0;
            private bool reverse;
            private int step = 1;

            public GifImage(string path)
            {
                gifImage = Image.FromFile(path);
                //initialize
                dimension = new FrameDimension(gifImage.FrameDimensionsList[0]);
                //gets the GUID
                //total frames in the animation
                frameCount = gifImage.GetFrameCount(dimension);
            }
            public GifImage(Bitmap imagem)
            {
                gifImage = imagem;// Image.FromFile(path);
                
                //initialize
                dimension = new FrameDimension(gifImage.FrameDimensionsList[0]);
                //gets the GUID
                //total frames in the animation
                frameCount = gifImage.GetFrameCount(dimension);
            }

            public bool ReverseAtEnd
            {
                //whether the gif should play backwards when it reaches the end
                get { return reverse; }
                set { reverse = value; }
            }

            public Image GetNextFrame()
            {

                currentFrame += step;

                //if the animation reaches a boundary...
                if (currentFrame >= frameCount || currentFrame < 1)
                {
                    if (reverse)
                    {
                        step *= -1;
                        //...reverse the count
                        //apply it
                        currentFrame += step;
                    }
                    else
                    {
                        currentFrame = 0;
                        //...or start over
                    }
                }
                return GetFrame(currentFrame);
            }

            public Image GetFrame(int index)
            {
                gifImage.SelectActiveFrame(dimension, index);
                //find the frame
                return (Image)gifImage.Clone();
                //return a copy of it
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }
    }
}
