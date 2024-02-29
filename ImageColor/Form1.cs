using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//EmguCV
using Emgu.CV; //opencv 主要函式
using Emgu.CV.CvEnum; //CV列舉項
using Emgu.CV.Cvb; //CVblob 功能
using Emgu.CV.Structure; //色彩形態定義
using Emgu.CV.UI; //imgbox顯示功能
using Emgu.CV.Util; //特殊形別定義 CV使用
using Emgu.Util;

using System.Diagnostics;
using System.IO;

namespace ImageColor
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> Image_Gamma0;
        Image<Bgr, byte> Image_Gamma1;

        Image<Hls, byte> Image_HSI0;
        Image<Hls, byte> Image_HSI1;

        Image<Bgr, double> Roat; 

        public Form1()
        {
            InitializeComponent();

            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Task.Run(() => All());
        }

        void All()
        {
            if (comboBox_DeputyName.Text != "Select")
            {
                try
                {
                    btnStart.Enabled = false;
                    Count_Data.Value = 0;

                    //要檢測的資料夾路徑
                    string All_Path = textBox1.Text; //路徑
                    DirectoryInfo Path_Images = new DirectoryInfo(All_Path);

                    //檢測資料夾類別數量 START
                    int quantity = Path_Images.GetFiles("*." + comboBox_DeputyName.Text).Length; //數量
                    labelQuantity.Text = quantity.ToString();
                    Count_Data.Maximum = quantity;

                    foreach (var fi in Path_Images.GetFiles("*." + comboBox_DeputyName.Text))
                    {
                        Image_Gamma0 = new Image<Bgr, byte>(All_Path + @"\" + fi.Name);
                        Image_Gamma1 = new Image<Bgr, byte>(All_Path + @"\" + fi.Name);

                        Image_HSI0 = new Image<Hls, byte>(All_Path + @"\" + fi.Name);
                        Image_HSI1 = new Image<Hls, byte>(All_Path + @"\" + fi.Name);

                        Roat = new Image<Bgr, double>(All_Path + @"\" + fi.Name);

                        int H = Image_Gamma0.Height, W = Image_Gamma0.Width;

                        //Gamma↓
                        if (cb_Gamma0.Checked)
                        {
                            //double g0 = double.Parse(textBox_Gamma0.Text);
                            Random m = new Random();
                            double x = 1,y=0,m1=0;
                            m1 = (double)(m.Next(1, 10));
                            y =0.9+Randr(0.1,0.2);
                            textBox_Gamma0.Text = y.ToString();
                            //MessageBox.Show(y.ToString());
                            if (y > 1)
                            {
                                Image_Gamma0._EqualizeHist();
                                Image_Gamma0._GammaCorrect(y);

                                Image_Gamma0.Save(textBox2.Text + @"\Gamma0_"  + fi.Name);
                            }
                        }

                        if (cb_Gamma1.Checked)
                        {
                            //double g1 = double.Parse(textBox_Gamma1.Text);
                            Random m = new Random();
                            double x = 1, y = 0, m1 = 0;
                            m1 = (double)(m.Next(1, 10));
                            y = x - Randr(0.1, 0.5);
                            textBox_Gamma1.Text = y.ToString();
                            //MessageBox.Show(y.ToString());
                            if (y < 1)
                            {
                                Image_Gamma1._EqualizeHist();
                                Image_Gamma1._GammaCorrect(y);

                                Image_Gamma1.Save(textBox2.Text + @"\Gamma1_" +  fi.Name);
                            }
                        }
                        //Gamma↑

                        //HSI Intensity1↓
                        if (cb_HSI1.Checked)
                        {
                            ////double i0 = double.Parse(textBox_HSI0.Text);
                            //Random m = new Random();
                            double x1 = 1, y1 = 0, m1 = 0;
                            //m1 = (double)(m.Next(1, 10));
                            //do
                            //{
                            //    y1 = Randr(Convert.ToDouble(textBox_HSI1.Text), Convert.ToDouble(textBox_HSI0.Text));
                            //} while (Math.Abs(y1 - x1) >= 0.1);
                            ////Console.WriteLine(y1);
                            ////textBox_HSI0.Text = y1.ToString();
                            y1 = Convert.ToDouble(textBox_HSI1.Text);
                            for (int y = 0; y < H; y++)
                            {
                                for (int x = 0; x < W; x++)
                                {
                                    int Vi0 = (int)((double)Image_HSI1.Data[y, x, 1] * y1);//y1
                                    if (Vi0 > 255) { Vi0 = 255; }
                                    if (Vi0 < 0) { Vi0 = 0; }
                                    Image_HSI1.Data[y, x, 1] = (byte)Vi0;
                                }
                            }
                            Image_HSI1.Save(textBox2.Text + @"\Intensity1_" +  fi.Name);

                        }
                        //HSI Intensity1↑

                        //HSI Intensity0↓
                        if (cb_HSI0.Checked)
                        {
                            ////double i0 = double.Parse(textBox_HSI0.Text);
                            //Random m = new Random();
                            double x1 = 1, y1 = 0, m1 = 0;
                            //m1 = (double)(m.Next(1, 10));
                            //do
                            //{
                            //    y1 = Randr(Convert.ToDouble(textBox_HSI1.Text), Convert.ToDouble(textBox_HSI0.Text));
                            //} while (Math.Abs(y1 - x1) >= 0.1);
                            ////Console.WriteLine(y1);
                            ////textBox_HSI0.Text = y1.ToString();
                            y1 = Convert.ToDouble(textBox_HSI3.Text);
                            for (int y = 0; y < H; y++)
                            {
                                for (int x = 0; x < W; x++)
                                {
                                    int Vi0 = (int)((double)Image_HSI0.Data[y, x, 1] * y1);//y1
                                    if (Vi0 > 255) { Vi0 = 255; }
                                    if (Vi0 < 0) { Vi0 = 0; }
                                    Image_HSI0.Data[y, x, 1] = (byte)Vi0;
                                }
                            }
                            Image_HSI0.Save(textBox2.Text + @"\Intensity0_" + fi.Name);

                        }
                        //HSI Intensity0↑


                        Count_Data.PerformStep();
                    }
                }
                catch (Exception Cai) { MessageBox.Show("Error !"); }
            }
            else { MessageBox.Show("No deputy file name !"); }

            //把所以儲存後的影像做旋轉
            if (comboBox_DeputyName.Text != "Select")
            {
                try
                {
                    //檢測後的資料夾路徑
                    string All_Path = textBox1.Text; //路徑
                    DirectoryInfo Path_Images = new DirectoryInfo(All_Path);

                    //檢測後的資料夾類別數量 START
                    int quantity = Path_Images.GetFiles("*." + comboBox_DeputyName.Text).Length; //數量
                    labelQuantity.Text = quantity.ToString();
                    Count_Data.Maximum = quantity;

                    foreach (var fi in Path_Images.GetFiles("*." + comboBox_DeputyName.Text))
                    {

                        Roat = new Image<Bgr, double>(All_Path + @"\" + fi.Name);

                        //Rotating↓
                        if (RotatingImg.Checked)
                        {

                            /// <summary>
                            /// 影象的旋轉
                            /// 在 Image<TColor,TDepth>Rotate 有三個過載函式， 這邊簡單介紹：
                            /// public Image<TColor, TDepth> Rotate(double angle, TColor background);
                            /// public Image<TColor, TDepth> Rotate(double angle, TColor background, boolcrop);
                            /// public Image<TColor, TDepth> Rotate(double angle, PointF center, Inter interpolationMethod, TColor background, bool crop);
                            ///引數解析：
                            /// double angle： 順時針旋轉角度。
                            /// PointF center： 旋轉中心， 預設為影象的中心。
                            /// Inter interpolationMethod： 插值型別表示符， 如表 6.1 所示。
                            /// TColor background： 背景影象的顏色， TColor 型別與影象的顏色
                            /// 型別一致。
                            /// bool crop： 如果 Crop = true， 則影象裁剪到與原來影象一樣大，可能會失去邊角資訊。 
                            ///false， 保證不失去邊角資訊， 但是改變了影象的大小。 預設為 true。
                            /// </summary>

                            Random n = new Random();
                            int n1 = 180;//旋轉180度
                            //Image<Bgra, byte> Imga1 = new Image<Bgra, byte>(Roat.ToBitmap());
                            //Image<Bgra, byte> Imga2 = Imga1.Rotate(Dou, new Bgra(0, 0, 0, 0), Bol);
                            // Image<Bgra, byte> Imga2 = Imga1.Rotate(Dou, new Bgra(0, 0, 0, 0), Bol) 等同於
                            //Image<Bgra, byte> Imga2 = Imga1.Rotate(n1, new PointF(Imga1.Width / 2, Imga1.Height / 2), Inter.Cubic, new Bgra(0, 0, 0, 0), false);

                            Roat = Roat.Rotate(n1, new PointF(Roat.Width / 2, Roat.Height / 2), Inter.Cubic, new Bgr(0, 0, 0), false);
                            Roat.Save(textBox2.Text + @"\Rotating_" + n1.ToString() + fi.Name);
                        }
                        //Rotating↑

                        Count_Data.PerformStep();
                    }
                }
                catch (Exception Cai) { MessageBox.Show("Error !"); }
            }
            else { MessageBox.Show("No deputy file name !"); }

            GC.Collect();
            
            btnStart.Enabled = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        //小數點亂數函式
        private double Randr(double r1, double r2)
        {
            double pvalue;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            //Debug.Print("rnd : " + rnd.NextDouble());
            pvalue = r1 + (r2 - r1) * rnd.NextDouble();

            return pvalue;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            GC.Collect();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog FileImages = new FolderBrowserDialog())
            {
                FileImages.ShowDialog();

                if (FileImages.SelectedPath != "")
                {
                    textBox1.Text = FileImages.SelectedPath;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog FileImages = new FolderBrowserDialog())
            {
                FileImages.ShowDialog();

                if (FileImages.SelectedPath != "")
                {
                    textBox2.Text = FileImages.SelectedPath;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
