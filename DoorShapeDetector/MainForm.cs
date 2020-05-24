using Emgu.CV;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorShapeDetector
{
    public partial class MainForm : Form
    {
        Dictionary<string, Image<Bgr, byte>> imgList;
        public MainForm()
        {
            InitializeComponent();
            imgList = new Dictionary<string, Image<Bgr, byte>>();
        }



        private void AddImage(Image<Bgr, byte> img, string keyname)
        {
           

            if (!imgList.ContainsKey(keyname))
            {
                imgList.Add(keyname, img);
            }
            else
            {
                imgList[keyname] = img;
            }
        }

        private void btn_selectImage_Click(object sender, EventArgs e)
        {
            try
            {
               
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var img = new Image<Bgr, byte>(dialog.FileName);

                   
                    AddImage(img, "Input");
                    imageBoxEx1.Image = img.AsBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_setTemplate_Click(object sender, EventArgs e)
        {
            Image Src = imageBoxEx1.Image;
            RectangleF refF = imageBoxEx1.SelectionRegion;
            Image CroppedImg = HelperClass.CropImage(Src, (int)refF.X, (int)refF.Y, (int)refF.Width, (int)refF.Height);
            picTemplate.Image = CroppedImg;
            Rectangle rect = new Rectangle((int)refF.X, (int)refF.Y, (int)refF.Width, (int)refF.Height);
            //string  keyname=
            var img = new Bitmap(Src).ToImage<Bgr, byte>();

           

            img.ROI = rect;
            var imgROI = img.Copy();
            img.ROI = Rectangle.Empty;

            AddImage(imgROI, "ROI Image");


            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void  MultiSacleMatching(Image Img_template)
        {
            try
            {
                if (picTemplate.Image == null )
                {
                    return;
                }

                var imgScene = imgList["Input"].Clone();
                var template = new Bitmap(Img_template)
                    .ToImage<Bgr, byte>();
                // multi scale logic

                Rectangle r = Rectangle.Empty;
                double GlobalminVal = float.MaxValue;

                for (float scale = 0.5f; scale <= 1.50; scale += 0.25f)
                {
                    var temp = template.Resize(scale, Emgu.CV.CvEnum.Inter.Cubic);
                    Mat imgout = new Mat();
                    CvInvoke.MatchTemplate(imgScene, temp, imgout, Emgu.CV.CvEnum.TemplateMatchingType.Sqdiff);

                    double minval = 0;
                    double maxval = 0;
                    Point minloc = new Point();
                    Point maxloc = new Point();

                    CvInvoke.MinMaxLoc(imgout, ref minval, ref maxval, ref minloc, ref maxloc);

                    double prob = minval / (imgout.ToImage<Gray, byte>().GetSum().Intensity);

                    if (prob < GlobalminVal)
                    {
                        GlobalminVal = prob;
                        r = new Rectangle(minloc, temp.Size);
                    }
                }

                if (r != null)
                {
                    CvInvoke.Rectangle(imgScene, r, new MCvScalar(255, 0, 0), 3);
                    imageBoxEx1.Image = imgScene.AsBitmap();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btn_mulitmatching_Click(object sender, EventArgs e)
        { Image img = picTemplate.Image;
            MultiSacleMatching(img);
        }

        private void btn_multiObj_Click(object sender, EventArgs e)
        {
            Image img = picTemplate.Image;
            ApplyMultiObjectDetectionTM(img);
        }



        private void ApplyMultiObjectDetectionTM(Image img_emplate,float threshold = 0.01f )
        {
            try
            {
                var imgScene = imgList["Input"].Clone();
                var template = new Bitmap(img_emplate).ToImage<Bgr, byte>();

                Mat imgOut = new Mat();
                CvInvoke.MatchTemplate(imgScene, template, imgOut, Emgu.CV.CvEnum.TemplateMatchingType.Sqdiff);

                Mat imgOutNorm = new Mat();
                CvInvoke.Normalize(imgOut, imgOutNorm, 0, 1, Emgu.CV.CvEnum.NormType.MinMax, Emgu.CV.CvEnum.DepthType.Cv64F);

                Matrix<double> matches = new Matrix<double>(imgOutNorm.Size);
                imgOutNorm.CopyTo(matches);

                double minValue = 0, maxVal = 0;
                Point minLoc = new Point();
                Point maxLoc = new Point();

                do
                {
                    CvInvoke.MinMaxLoc(matches, ref minValue, ref maxVal, ref minLoc, ref maxLoc);
                    Rectangle r = new Rectangle(minLoc, template.Size);
                    CvInvoke.Rectangle(imgScene, r, new MCvScalar(255, 0, 0), 1);

                    matches[minLoc.Y, minLoc.X] = 0.5;
                    matches[maxLoc.Y, maxLoc.X] = 0.5;
                } while (minValue <= threshold);

                imageBoxEx1.Image = imgScene.AsBitmap();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btn_matching_Click(object sender, EventArgs e)
        {
            Image img = picTemplate.Image;
            JustMatchnig(img);
        }


        private void JustMatchnig(Image img)
        {

            try
            {
                if (img == null)
                {
                    return;
                }

                var imgScene = imgList["Input"].Clone();
                var template = new Bitmap(img)
                    .ToImage<Bgr, byte>();


                Mat imgout = new Mat();

                CvInvoke.MatchTemplate(imgScene, template, imgout, Emgu.CV.CvEnum.TemplateMatchingType.CcorrNormed);

                double minVal = 0.0;
                double maxVal = 0.0;
                Point minLoc = new Point();
                Point maxLoc = new Point();

                CvInvoke.MinMaxLoc(imgout, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
                Rectangle r = new Rectangle(maxLoc, template.Size);
                CvInvoke.Rectangle(imgScene, r, new MCvScalar(255, 0, 0), 3);
                imageBoxEx1.Image = imgScene.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ApplyHarisCorner(int threshold = 200)
        {
            try
            {
                if (imgList["Input"] == null)
                {
                    return;
                }

                var img = imgList["Input"].Clone();
                var gray = img.Convert<Gray, byte>();

                var corners = new Mat();
                CvInvoke.CornerHarris(gray, corners, 2);
                CvInvoke.Normalize(corners, corners, 255, 0, Emgu.CV.CvEnum.NormType.MinMax);

                Matrix<float> matrix = new Matrix<float>(corners.Rows, corners.Cols);
                corners.CopyTo(matrix);

                for (int i = 0; i < matrix.Rows; i++)
                {
                    for (int j = 0; j < matrix.Cols; j++)
                    {
                        if (matrix[i, j] > threshold)
                        {
                            CvInvoke.Circle(img, new Point(j, i), 5, new MCvScalar(0, 0, 255), 3);
                        }
                    }
                }

                imageBoxEx1.Image = img.AsBitmap();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void list_Features_SelectedIndexChanged(object sender, EventArgs e)
        {
            int threshold = Int32.Parse(textBox2.Text.Trim());
            int index = list_Features.SelectedIndex;
            switch (index)
            {

                case 0:
                   
                    ApplyHarisCorner(threshold);
                    break;
                case 1:
                    Shi_Tomasi();
                    break;

                case 2:
                   
                    ApplyFASTFeatureDetector(threshold);
                     break;

            }
        }


        private void Shi_Tomasi()
        {

            try
            {
                if (imgList["Input"] == null)
                {
                    return;
                }

                var img = imgList["Input"].Clone();
                var gray = img.Convert<Gray, byte>();

                GFTTDetector detector = new GFTTDetector(2000, 0.06);
                var corners = detector.Detect(gray);

                Mat outimg = new Mat();
                Features2DToolbox.DrawKeypoints(img, new VectorOfKeyPoint(corners), outimg, new Bgr(0, 0, 255));

                imageBoxEx1 .Image = outimg.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void ApplyFASTFeatureDetector(int threshold = 10)
        {
            try
            {
                if (imgList["Input"] == null)
                {
                    return;
                }

                var img = imgList["Input"].Clone();
                var gray = img.Convert<Gray, byte>();

                FastFeatureDetector detector = new FastFeatureDetector(threshold);
                var corners = detector.Detect(gray);

                Mat outimg = new Mat();
                Features2DToolbox.DrawKeypoints(img, new VectorOfKeyPoint(corners), outimg, new Bgr(0, 0, 255));

                imageBoxEx1 .Image = outimg.ToBitmap();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
