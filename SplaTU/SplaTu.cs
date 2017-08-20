using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// using ImageMagick;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Threading;
using System.Globalization;
using SplaTU.Resources;

namespace SplaTU
{
    public partial class SplaTU : Form
    {
        public SplaTU()
        {
            InitializeComponent();
            InitDefaults();


        } 

        private void InitDefaults()
        {

            try
            {
                txtPath.Text = Properties.Settings.Default.setting_last_path ; 
            }
            catch
            {
                txtPath.Text = "";
            }


        } 
           
        private void btnBrowse_Click(object sender, EventArgs e)
        {

            try
            {
                string path = @"C:\";

                try
                {
                    path = Path.GetDirectoryName(Properties.Settings.Default.setting_last_path);
                }
                catch
                {
                    path = @"C:\";
                }

                OpenFileDialog file = new OpenFileDialog();
                file.Title =  Strings.str_LoadImg;
                if (Directory.Exists(path))
                {
                    file.InitialDirectory = path;
                }
                else
                {
                    file.InitialDirectory = @"C:\";
                }

                if (file.ShowDialog() == DialogResult.OK)
                {
                    path = file.FileName;
                    txtPath.Text = path;

                    Properties.Settings.Default.setting_last_path = txtPath.Text;
                    Properties.Settings.Default.Save();



                    Image inputFile = Image.FromFile(txtPath.Text); 
                    Bitmap inputImg = new Bitmap(inputFile);
                    if (inputImg.Height != 120 && inputImg.Width != 320)
                    {
                        inputImg = ResizeImage(inputImg, 320, 120);
                    } 
                    pbInput.Image = inputImg;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }




        private void btnPreviewImg_Click(object sender, EventArgs e)
        {

            try
            {
                 
                Image inputFile = Image.FromFile(txtPath.Text);
                Bitmap inputImg = new Bitmap(inputFile);
                if (inputImg.Height != 120 && inputImg.Width != 320)
                {
                    inputImg = ResizeImage(inputImg, 320, 120);
                }
                pbInput.Image = inputImg;

                 
                //// Method 1: 
                //Image img1 = ProcessImageTo1Bit(new Bitmap(ProcessImageByOrderedDither(inputImg)));
                //pbOutput.Image = img1; 
                //img1.Save("outImage1.bmp", ImageFormat.Bmp);

                // Method 2:
                Image img2 = ProcessImageTo1Bit(inputImg);
                pbOutput2.Image = img2;
                img2.Save("outImage0.bmp", ImageFormat.Bmp);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            try
            { 
                Image outImg =   pbOutput2.Image ;
                   
                if(outImg ==null)
                { 
                    MessageBox.Show(Strings.str_SelError);
                    return;
                }
                 
                GenerateData(new Bitmap(outImg));

                MakeFile();

               // MessageBox.Show(str_FileGen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
    
            }

        }

        private void MakeFile( )
        {

            try
            {

                //System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

                string path = Directory.GetCurrentDirectory();
                path += @"\Switch-Fightstick-master"; 
                startInfo.WorkingDirectory = path;
                startInfo.FileName = "cmd.exe";
             //   startInfo.Arguments = @"/c start /wait spMake.bat ";
                startInfo.Arguments = @"/c start /wait make ";
                //process.StartInfo = startInfo;
                //process.Start();

                //try
                //{
                //    // Start the process with the info we specified.
                //    // Call WaitForExit and then the using-statement will close.
                //    using (Process exeProcess = Process.Start(startInfo))
                //    {
                //        exeProcess.WaitForExit();
                //    }
                //}
                //catch
                //{
                //    // Log error.
                //}
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;

                string output = "";
                string error = "";

                Process process = Process.Start(startInfo);
                process.WaitForExit();
                using (StreamReader streamReader = process.StandardOutput)
                {
                     output = streamReader.ReadToEnd();
                }

                using (StreamReader streamReader = process.StandardError)
                {
                    error = streamReader.ReadToEnd();
                }

                if (error == "")
                { 
                    string hexFilePath = path + @"\Joystick.hex";

                    MessageBox.Show(Resources.Strings.str_FileGen+"\r\n" + hexFilePath );
                }
                else
                {
                    MessageBox.Show("Error: " + error); 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }


        public Image ProcessImageByOrderedDither(Bitmap inputImg)
        { 
            try
            {
                //// OrderedDither    
                //using (MagickImage image = new MagickImage( inputImg ))
                //{
                //    MagickGeometry size = new MagickGeometry(320, 120);
                //    size.IgnoreAspectRatio = true;
                     
                //    image.Format = MagickFormat.Bmp3;
                //    image.Resize(size);
                //    image.Depth = 1;

                //    image.ClassType = ClassType.Pseudo;
                //    image.ColorSpace = ColorSpace.Gray;
                //    image.ColorType = ColorType.Grayscale;

                //    //  pbInput.Image = image;
                //    image.OrderedDither("o8x8");
                //    int totalcolor = image.TotalColors;

                //    var colormapsize = image.ColormapSize;
                //    Stream magicImgStream = new System.IO.MemoryStream();
                //    image.Write(magicImgStream); 
                //    Image outputImg = Image.FromStream(magicImgStream);
                     
                //    return outputImg; 
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }

        public Image ProcessImageTo1Bit(Bitmap inputImg)
        {
            try
            {
                /// Floyd-Steinberg  
                Image outputImg = ConvertTo1Bit( inputImg );
                 
                return outputImg; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


        public static Bitmap ConvertTo1Bit(Bitmap input)
        {
            /// Floyd-Steinberg
            /// 
            var masks = new byte[] { 0x80, 0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x01 };
            var output = new Bitmap(input.Width, input.Height, PixelFormat.Format1bppIndexed);
            var data = new sbyte[input.Width, input.Height];
            var inputData = input.LockBits(new Rectangle(0, 0, input.Width, input.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            try
            {
                var scanLine = inputData.Scan0;
                var line = new byte[inputData.Stride];
                for (var y = 0; y < inputData.Height; y++, scanLine += inputData.Stride)
                {
                    Marshal.Copy(scanLine, line, 0, line.Length);
                    for (var x = 0; x < input.Width; x++)
                    {
                        data[x, y] = (sbyte)(64 * (GetGreyLevel(line[x * 3 + 2], line[x * 3 + 1], line[x * 3 + 0]) - 0.5));
                    }
                }
            }
            finally
            {
                input.UnlockBits(inputData);
            }
            var outputData = output.LockBits(new Rectangle(0, 0, output.Width, output.Height), ImageLockMode.WriteOnly, PixelFormat.Format1bppIndexed);
            try
            {
                var scanLine = outputData.Scan0;
                for (var y = 0; y < outputData.Height; y++, scanLine += outputData.Stride)
                {
                    var line = new byte[outputData.Stride];
                    for (var x = 0; x < input.Width; x++)
                    {
                        var j = data[x, y] > 0;
                        if (j) line[x / 8] |= masks[x % 8];
                        var error = (sbyte)(data[x, y] - (j ? 32 : -32));
                        if (x < input.Width - 1) data[x + 1, y] += (sbyte)(7 * error / 16);
                        if (y < input.Height - 1)
                        {
                            if (x > 0) data[x - 1, y + 1] += (sbyte)(3 * error / 16);
                            data[x, y + 1] += (sbyte)(5 * error / 16);
                            if (x < input.Width - 1) data[x + 1, y + 1] += (sbyte)(1 * error / 16);
                        }
                    }
                    Marshal.Copy(line, 0, scanLine, outputData.Stride);
                }
            }
            finally
            {
                output.UnlockBits(outputData);
            }
            return output;
        }

        public static double GetGreyLevel(byte r, byte g, byte b)
        {
            return (r * 0.299 + g * 0.587 + b * 0.114) / 255;
        }


        public byte[] GenerateData(Bitmap bitmap)
        {
             
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            System.Drawing.Imaging.BitmapData bmpData = null;
            byte[] bitVaues = null;
            int stride = 0;
            try
            {
                bmpData = bitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly, bitmap.PixelFormat);
                IntPtr ptr = bmpData.Scan0;
                stride = bmpData.Stride;
                int bytes = bmpData.Stride * bitmap.Height;
                bitVaues = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, bitVaues, 0, bytes);
            }
            finally
            {
                if (bmpData != null)
                    bitmap.UnlockBits(bmpData);
            }

            // File.WriteAllBytes("Foo.data", bitVaues);

            byte[] outPixelData = new byte[bitmap.Width * bitmap.Height];
            for (int i = 0; i < bitVaues.Length - 4; i = i + 4)
            {
                var v1 = bitVaues[i];
                var v2 = bitVaues[i + 1];
                var v3 = bitVaues[i + 2];
                var v4 = bitVaues[i + 3];

                if (v1 == 0x00 && v2 == 0x00 && v3 == 0x00 && v4 == 0xFF)
                {
                    outPixelData[i / 4] = 0x00;
                }
                else if (v1 == 0xFF && v2 == 0xFF && v3 == 0xFF && v4 == 0xFF)
                {
                    outPixelData[i / 4] = 0x01;
                }
                else
                {
                    throw new Exception("Invalid Bitmap Data");
                }
            }
              
            // File.WriteAllBytes(@"splaTuOutput.data", outPixelData);

            GenerateImageC(outPixelData);


            return outPixelData;
        }

        public void GenerateImageC(byte[] data)
        { 

            string str_out = "#include <stdint.h>\n\nuint8_t image_data[0x12c1] = {";

            for (int i =0; i< (320 * 120) / 8;i++)
            {
                int val = 0x00;
                 
                for (int j=0; j< 8;j++)
                {

                   int a =   (int)(data[(i * 8) + j]);

                    val |=   (int)(data[(i * 8) + j]) << j ;
                }
                val = ~val & 0xFF;
                str_out += "0x"+val.ToString("x") + ", ";
            }
             

            str_out += "0x0};";
            File.WriteAllText(@"Switch-Fightstick-master\imaget.c", str_out, Encoding.UTF8);
             
            byte[] bytes = System.IO.File.ReadAllBytes(@"Switch-Fightstick-master\imaget.c");

            System.IO.File.WriteAllBytes(@"Switch-Fightstick-master\image.c", bytes.Skip(3).ToArray());

            try
            {
                if (File.Exists(@"Switch-Fightstick-master\imaget.c"))
                {
                    File.Delete(@"Switch-Fightstick-master\imaget.c");
                }
            }
            catch { }
            


        }
         
         
        private void btnRunTeensy_Click(object sender, EventArgs e)
        {
            OpenFile(@"teensy.exe");
        }

        private void OpenFile(string path )
        {
            try
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = path;
                start.WindowStyle = ProcessWindowStyle.Normal;
                start.CreateNoWindow = true;
                //	int exitCode;

                using (Process proc = Process.Start(start))
                {
                    // proc.WaitForExit();
                    // exitCode = proc.ExitCode;
                }
                // AddLog("[OpenFile] Exit Code:" + exitCode, tab);
            }
            catch (Exception ex)
            {
                MessageBox.Show("[OpenFile]" + ex.Message );
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {// Create a new instance of the Form2 class
            AboutBox aboutwindow = new AboutBox();

            // Show the settings form
            aboutwindow.Show();

        }



        #region Localize
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en"); 
            ApplyResource();
        }

        private void SchineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CN"); 
            ApplyResource();
        }



        private void ApplyResource()
        {
            System.ComponentModel.ComponentResourceManager res = new ComponentResourceManager(typeof(SplaTU));
            foreach (Control ctl in Controls)
            {
                res.ApplyResources(ctl, ctl.Name);
            }
             
            foreach (ToolStripMenuItem item in this.menuStrip1.Items)
            {
                res.ApplyResources(item, item.Name);
                foreach (ToolStripMenuItem subItem in item.DropDownItems)
                {
                    res.ApplyResources(subItem, subItem.Name);
                }
            }

            //Caption
            res.ApplyResources(this, "$this");
        }
        #endregion
    }
}
