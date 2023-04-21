using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.GZip;
namespace Lab02_NT106
{   
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            
        }
        
        /// <summary>
        /// Hàm nén file thành .zip
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        public static void CompressToZip(string inputFile, string outputFile)
        {
            using (var fsIn = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            using (var fsOut = new FileStream(outputFile, FileMode.Create,  FileAccess.Write))
            {
                var zipStream = new ZipOutputStream(fsOut);
                zipStream.PutNextEntry(new ZipEntry(Path.GetFileName(inputFile)));
                byte[] buffer = new byte[4096];
                int bytesRead = 0;
                while((bytesRead = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    zipStream.Write(buffer, 0, bytesRead);
                }
                zipStream.CloseEntry();
                zipStream.Close();
            }
        }
        /// <summary>
        /// Hàm nén file thành .gz
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        public static void CompressToGZip(string inputFile, string outputFile)
        {
            using(var fsIn = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            using(var fsOut =  new FileStream(outputFile, FileMode.Create, FileAccess.Write))
            {
                var gzipStream = new GZipOutputStream(fsOut);
                
                byte[] buffer = new byte[4096];
                int bytesRead;
                while((bytesRead = fsIn.Read(buffer,0, buffer.Length)) > 0)
                {
                    gzipStream.Write(buffer, 0, bytesRead);
                }
        
                gzipStream.Close();
            }
        }
        
        private void btnCompressToZip_Click(object sender, EventArgs e)
        {
            string inputFile = "input5.txt";
            string outputFile = "output5.zip";
            CompressToZip(inputFile, outputFile);
            MessageBox.Show("Tập tin đã được nén thành file Zip thành công");
        }

        private void btnCompressToGzip_Click(object sender, EventArgs e)
        {
            string inputFile = "input5.txt";
            string outputFile = "output5.gz";
            CompressToGZip(inputFile, outputFile);
            MessageBox.Show("Tập tin đã được nén file Gzip thành công");
        }
        public static void Decompress(string inputFile, string outputFile, ProgressBar progressBar)
        {
            using (var fsIn = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            using (var fsOut = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;
                long totalBytesRead = 0;
                long fileSize = fsIn.Length;
                if (Path.GetExtension(inputFile).Equals(".zip", StringComparison.OrdinalIgnoreCase))
                {
                    var zipStream = new ZipInputStream(fsIn);
                    zipStream.GetNextEntry();
                    while ((bytesRead = zipStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fsOut.Write(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;
                        long progressPercentage = (totalBytesRead * 100L / fileSize);
                        if (progressPercentage > progressBar.Maximum)
                        {
                            progressBar.Value = progressBar.Maximum;
                        }
                        else
                        {
                            progressBar.Value = (int)progressPercentage;
                        }
                    }
                    zipStream.Close();
                }
                else if (Path.GetExtension(inputFile).Equals(".gz", StringComparison.OrdinalIgnoreCase))
                {
                    var gzipStream = new GZipInputStream(fsIn);
                    while ((bytesRead = gzipStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fsOut.Write(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;
                        long progressPercentage = (totalBytesRead * 100L / fileSize);
                        if (progressPercentage > progressBar.Maximum)
                        {
                            progressBar.Value = progressBar.Maximum;
                        }
                        else
                        {
                            progressBar.Value = (int)progressPercentage;
                        }
                    }
                    gzipStream.Close();
                }
            }

        }

        private void btnDecompressZip_Click(object sender, EventArgs e)
        {
            string inputFile = "output5.zip";
            string outputFile = "output5.txt";
            Decompress(inputFile, outputFile, progressBar);
            MessageBox.Show("Tập tin đã được giải nén thành công");
        }

        private void btnDecompressGzip_Click(object sender, EventArgs e)
        {
            string inputFile = "output5.gz";
            string outputFile = "output.txt";
            Decompress(inputFile, outputFile, progressBar);
            MessageBox.Show("Tập tin đã được giải nén thành công");
        }
    }
}
