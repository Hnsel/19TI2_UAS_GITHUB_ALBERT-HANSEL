using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukuKasPribadi.UI
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            lblP.MaximumSize = new Size(700, 0);
            lblP.AutoSize = true;
            lblP.Text = "Seperti yang kita ketahui bahwa sebagai seorang millenial menabung uang adalah suatu kebiasaan yang sangat membantu kita dimasa masa saat ini yang dimana itu akan menjadi suatu cadangan finansial yang mungkin akan dapat membantu kita untuk mencapai tujuan kita di saat yang akan datang, untuk menabung, kita tentunya memerlukan target dan startegi yang baik di dalam mengelola keuangan kita secara cermat agar terhindar dari pengeluaran yang tidak terkontrol, perasaan uang yang tiba tiba habis tanpa sebab yang mampu menimbulkan kesalahpahaman dsb, agar kita dapat menghindari permasalahan tersebut maka kita harus melalukan pencatatan yang mendetail mengenai keuangan keseharian tersebut.Tetapi terkadang kita tidak mampu untuk mencatat secara mendetail mengenai permasalahan pengelolan uang tersebut. " + "\n" +
                "Oleh sebab itu software Buku Kas ini akan menjadi sebuah solusi yang baik untuk mengatasi permasalah di atas. Buku Kas Pribadi merupakan sebuah software yang dirancang untuk mengelola keuangan Anda sehari hari yang dimana Anda dapat melalukan pencatatan secara mendetail mengenai pemasukkan, pengeluaran, utang dan piutang yang terjadi didalam kehidupan kita sehari hari. Ini akan sangat membantu kita didalam melakukan tracking terhadap transaksi keuangan kita sehari hari sehingga kita menyusun strategi yang cocok agar kita bisa menabung." + "\n" +
                "Software ini dirancang dan dikembangkan oleh : " + "\n" + "- Albert Hansel (03082190034)" + "\n" + "- Edric Justin (03082190002)";
            lblCPY.Text = "Copyright " + "\u00a9" + " 2021 Albert Hansel and Edric Justin. - All Right Reserved";
        }

        private string Justify(string text, Font font, int width)
        {
            char SpaceChar = (char)0x200A;
            List<string> WordsList = text.Split((char)32).ToList();
            if (WordsList.Capacity < 2)
                return text;

            int NumberOfWords = WordsList.Capacity - 1;
            int WordsWidth = TextRenderer.MeasureText(text.Replace(" ", ""), font).Width;
            int SpaceCharWidth = TextRenderer.MeasureText(WordsList[0] + SpaceChar, font).Width
                               - TextRenderer.MeasureText(WordsList[0], font).Width;

            //Calculate the average spacing between each word minus the last one 
            int AverageSpace = ((width - WordsWidth) / NumberOfWords) / SpaceCharWidth;
            float AdjustSpace = (width - (WordsWidth + (AverageSpace * NumberOfWords * SpaceCharWidth)));

            //Add spaces to all words
            return ((Func<string>)(() => {
                string Spaces = "";
                string AdjustedWords = "";

                for (int h = 0; h < AverageSpace; h++)
                    Spaces += SpaceChar;

                foreach (string Word in WordsList)
                {
                    AdjustedWords += Word + Spaces;
                    //Adjust the spacing if there's a reminder
                    if (AdjustSpace > 0)
                    {
                        AdjustedWords += SpaceChar;
                        AdjustSpace -= SpaceCharWidth;
                    }
                }
                return AdjustedWords.TrimEnd();
            }))();
        }

        public string JustifyParagraph(string text, Font font, int ControlWidth)
        {
            string result = string.Empty;
            List<string> ParagraphsList = new List<string>();
            ParagraphsList.AddRange(text.Split(new[] { "\r\n" }, StringSplitOptions.None).ToList());

            foreach (string Paragraph in ParagraphsList)
            {
                string line = string.Empty;
                int ParagraphWidth = TextRenderer.MeasureText(Paragraph, font).Width;

                if (ParagraphWidth > ControlWidth)
                {
                    //Get all paragraph words, add a normal space and calculate when their sum exceeds the constraints
                    string[] Words = Paragraph.Split(' ');
                    line = Words[0] + (char)32;
                    for (int x = 1; x < Words.Length; x++)
                    {
                        string tmpLine = line + (Words[x] + (char)32);
                        if (TextRenderer.MeasureText(tmpLine, font).Width > ControlWidth)
                        {
                            //Max lenght reached. Justify the line and step back
                            result += Justify(line.TrimEnd(), font, ControlWidth) + "\r\n";
                            line = string.Empty;
                            --x;
                        }
                        else
                        {
                            //Some capacity still left
                            line += (Words[x] + (char)32);
                        }
                    }
                    //Adds the remainder if any
                    if (line.Length > 0)
                        result += line + "\r\n";
                }
                else
                {
                    result += Paragraph + "\r\n";
                }
            }
            return result.TrimEnd(new[] { '\r', '\n' });
        }

        private void btnJustify_Click(object sender, EventArgs e)
        {
            lblP.Text = JustifyParagraph(lblP.Text, lblP.Font, lblP.ClientSize.Width);
        }
    }
}
