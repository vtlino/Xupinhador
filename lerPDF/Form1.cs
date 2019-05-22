using System.Configuration;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace lerPDF
{

    public partial class Form1 : Form
    {
        //public PdfReader reader;
        public string value = ConfigurationSettings.AppSettings["caminho"];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // manipular de diretorios
            var value = ConfigurationSettings.AppSettings["caminho"];

            //DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\fpri018\Downloads\pdf");
            DirectoryInfo dirInfo = new DirectoryInfo(value);
            // procurar arquivos
            BuscaArquivos(dirInfo);
        }
        public string LerTodasAsPaginas(String pdfPath, int pagina)
        {
            PdfReader reader = new PdfReader(pdfPath);

            /* ================ Verifica por Região do arquivo
            RenderFilter[] filters = new RenderFilter[1];
            LocationTextExtractionStrategy regionFilter = new LocationTextExtractionStrategy();
            filters[0] = new RegionTextRenderFilter(new System.util.RectangleJ(0, 0, 1024, 768));
            */


            ////FilteredTextRenderListener strategy = new FilteredTextRenderListener(regionFilter, filters);
            ////String result = PdfTextExtractor.GetTextFromPage(reader, 1, strategy);
            ////reader.NumberOfPages
            String result = PdfTextExtractor.GetTextFromPage(reader, pagina);

            return result.ToString();
        }

        private void BuscaArquivos(DirectoryInfo dir)
        {
            // lista arquivos do diretorio corrente
            int tot = -1;
            foreach (FileInfo file in dir.GetFiles())
            {
                if (file.Extension.Equals(".pdf"))
                {
                    tot++;
                    if (tot == numericUpDown1.Value) return;
                    listBox1.Items.Add(file.FullName);
                }
            }

            // busca arquivos do proximo sub-diretorio
            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                BuscaArquivos(subDir);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                //for (int i = 1; i < reader.NumberOfPages; i++)
                int i = 0;
                string retorno = "";
                while (true)
                {
                    i++;
                    //string retorno = LerTodasAsPaginas($@"{listBox1.SelectedItem.ToString()}",i);
                    try
                    {
                        retorno = LerTodasAsPaginas($@"{item.ToString()}", i).ToUpper();
                    }
                    catch { break; }
                    String[] elements = item.ToString().Split('\\');
                    string Nome = elements[elements.Count() - 1].Replace(".pdf", "");
                    if (retorno.Contains("ISOLADAMENTE"))
                    {
                        listBox2.Items.Add(Nome.PadRight(40, ' ') + "ISOLADO");
                        break;
                    }
                    if (retorno.Contains("EM CONJUNTO"))
                    {
                        listBox2.Items.Add(Nome.PadRight(40, ' ') + "EM CONJUNTO");
                        break;
                    }
                }
                
            }


            //if (listBox1.SelectedIndex < 0)
            //{
            //    MessageBox.Show("seleciona algum arquivo vei");
            //}
            //else
            //{
            //    string retorno = LerTodasAsPaginas($@"{listBox1.SelectedItem.ToString()}");
            //    if (retorno.Contains("Contribuinte"))
            //        MessageBox.Show("achou");
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\fpri018\Downloads\pdf");
            DirectoryInfo dirInfo = new DirectoryInfo(value);
            // procurar arquivos
            BuscaArquivos(dirInfo);
        }
    }
}
