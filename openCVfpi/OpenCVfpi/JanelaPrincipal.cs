using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace OpenCVfpi
{
    public partial class JanelaPrincipal : Form
    {
        VideoCapture videoOriginal;
        Mat frame;
        bool mirrorHoriCheck, mirrorVertCheck, rotateClockCheck, rotateCounterCheck;

        public JanelaPrincipal()
        {
            InitializeComponent();
            videoOriginal = new VideoCapture();
            frame = new Mat();
            mirrorHoriCheck = mirrorVertCheck = rotateCounterCheck = rotateClockCheck = false;

            Application.Idle += new EventHandler(delegate (object sender, EventArgs e)
            {
                frame = videoOriginal.QueryFrame();
                GaussText.Text = GaussBar.Value.ToString();
                brilhoCheck.Text = "Brilho: " + brilhoBar.Value.ToString();
                if(gaussCheck.Checked)
                {
                    int size = (GaussBar.Value % 2 == 0) ? GaussBar.Value + 1 : GaussBar.Value;
                    CvInvoke.GaussianBlur(frame, frame, new Size(size, size), 0, 0);
                }
                if(cannyCheck.Checked)
                {
                    Mat frameCanny = new Mat();
                    CvInvoke.Canny(frame, frameCanny, 140, 180);
                    frame = frameCanny;
                }
                if(sobelCheck.Checked)
                {
                    CvInvoke.Sobel(frame, frame, DepthType.Default, 0, 1);
                }
                if(brilhoCheck.Checked)
                {
                    Mat frameAux = new Mat();
                    frame.ConvertTo(frameAux, DepthType.Default, brilhoBar.Value);
                    frame = frameAux;
                }
                if(contrastCheck.Checked)
                {
                    Mat frameAux = new Mat();
                    frame.ConvertTo(frameAux, DepthType.Default, 1, contrastBar.Value);
                    frame = frameAux;
                }
                if(negativeCheck.Checked)
                {
                    Mat frameAux = new Mat();
                    frame.ConvertTo(frameAux, DepthType.Default, -1, 255);
                    frame = frameAux;
                }
                if(grayCheck.Checked)
                {
                    CvInvoke.CvtColor(frame, frame, ColorConversion.Bgr2Gray);
                }
                if(halveCheck.Checked)
                {
                    CvInvoke.Resize(frame, frame, new Size(frame.Width / 2, frame.Height / 2));
                }
                if(mirrorHoriCheck)
                {
                    Mat frameAux = frame;
                    CvInvoke.Flip(frame, frameAux, FlipType.Horizontal);
                    frame = frameAux;
                }
                if(mirrorVertCheck)
                {
                    Mat frameAux = frame;
                    CvInvoke.Flip(frame, frameAux, FlipType.Vertical);
                    frame = frameAux;
                }
                if(rotateClockCheck)
                {
                    CvInvoke.Rotate(frame, frame, RotateFlags.Rotate90Clockwise);
                }
                if(rotateCounterCheck)
                {
                    CvInvoke.Rotate(frame, frame, RotateFlags.Rotate90CounterClockwise);
                }
                webcamBox.Image = frame;
            });
        }

        private void rotateCounter_Click(object sender, EventArgs e)
        {
            rotateCounterCheck = !rotateCounterCheck;
        }

        private void rotateClock_Click(object sender, EventArgs e)
        {
            rotateClockCheck = !rotateClockCheck;
        }

        private void mirrorHori_Click(object sender, EventArgs e)
        {
            mirrorHoriCheck = !mirrorHoriCheck;
        }

        private void mirrorVert_Click(object sender, EventArgs e)
        {
            mirrorVertCheck = !mirrorVertCheck;
        }
    }
}
