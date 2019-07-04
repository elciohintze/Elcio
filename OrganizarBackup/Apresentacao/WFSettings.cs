using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizarBackup
{
    public partial class WFSettings : Form
    {
        public WFSettings()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string inputFolder = txtInput.Text;
            if (inputFolder == "")
            {
                MessageBox.Show("Root directory is empty!");
            }
            else if (txtOutput.Text == "")
            {
                MessageBox.Show("Output directory is empty!");
            }
            else
            {
                string Dir = null;
                string[] arrayFiles = Directory.GetFiles(txtInput.Text); //Aqui estou criando a lista com os arquivos  do diretório apontado
                btnRun.Enabled = false; //desativando o botão enquanto o laço é executado
                foreach (var item in arrayFiles)
                {
                    FileInfo infoArquivo = new FileInfo(item);
                    string extension = infoArquivo.Extension.Replace(".", ""); //trantado a extensão do arquivo e guardando na variavel
                    string primeiraLetra = infoArquivo.Name.Substring(0, 1); // pegando a primeira letra do arquivo
                    string arquivosDuplicados = Path.Combine(txtOutput.Text, "DUPLICADOS");

                    //a sequencia de IF's abaixo valida a extensão do arquivo e determina a pasta 
                    if ((extension == "txt") || (extension == "xml") || (extension == "html") || (extension == "csv"))
                    {
                        Dir = "TEXTO";
                    }
                    else if ((extension == "mp4") || (extension == "MKV"))
                    {
                        Dir = "VIDEO";
                    }
                    else if ((extension == "pdf") || (extension == "png") || (extension == "gif"))
                    {
                        Dir = "IMAGEM";
                    }
                    else if ((extension == "mp3") || (extension == "WAV") || (extension == "WMA"))
                    {
                        Dir = "MUSICA";
                    }
                    else
                    {
                        Dir = "RESTO";
                    }

                    string outputPath = Path.Combine(txtOutput.Text, Dir, primeiraLetra); //montagem do diretorio final
                    bool existeDiretorio = Directory.Exists(outputPath);

                    if (!existeDiretorio) //verificando a existencia do diretório... 
                    {

                        Directory.CreateDirectory(outputPath); //caso o diretório não exista o mesmo sera criado
                    }

                    bool existeArquivo = File.Exists(infoArquivo.Name);


                    if (!existeArquivo)
                    {
                        //infoArquivo = arquivo a ser copiado (G:\Arquivos)
                        //infoArquivoDestino = arquivo da pasta Arquivos_Organizados (G:\Arquivos_Organizados)

                        try
                        {
                            File.Copy(infoArquivo.FullName, $"{outputPath}\\{infoArquivo.Name}"); //interpolação
                        }
                        catch (IOException)
                        {
                            if (!Directory.Exists(arquivosDuplicados))
                            {
                                Directory.CreateDirectory(arquivosDuplicados); //caso o diretório não exista o mesmo sera criado
                            }

                            FileInfo infoArquivoDestino = new FileInfo($"{outputPath}\\{infoArquivo.Name}");

                            if (infoArquivo.LastWriteTime > infoArquivoDestino.LastWriteTime) // se a data de (G:\Arquivos\Arq) > (G:\Arquivos_Organizados\arq), entao move arquivo destino para duplicados e arquivo para arquivos organizados
                            {
                                //File.Move(infoArquivoDestino.FullName, $"{arquivosDuplicados}\\{infoArquivo.Name.Substring(0, infoArquivo.Name.Length - 4) + " - " + DateTime.Now.ToShortDateString() + "." + extension}"); //interpolação
                                File.Move(infoArquivoDestino.FullName, $"{arquivosDuplicados}\\{infoArquivo.Name}_{DateTime.Now.ToString("HH-mm yyyy-MM-dd")}"); //interpolação
                                File.Delete(infoArquivoDestino.FullName); //apaga o arquivo do diretório de entrada após copiar para o novo diretório
                                File.Copy(infoArquivo.FullName, $"{outputPath}\\{infoArquivo.Name}"); //interpolação
                            }
                            else if (!File.Exists(Path.Combine(arquivosDuplicados, infoArquivo.Name)))
                            {
                                File.Copy(infoArquivo.FullName, $"{arquivosDuplicados}\\{infoArquivo.Name}"); //interpolação
                            }
                        }
                        finally
                        {
                            File.Delete($"{inputFolder}\\{infoArquivo.Name}"); //apaga o arquivo do diretório de entrada após copiar para o novo diretório
                        }
                    }


                }

                MessageBox.Show("process completed");
                btnRun.Enabled = true; //reativando o botão
            }
        }


        private void btnSearchInputDir_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtInput.Text = fbd.SelectedPath;//selecionado diretorio
            }
        }

        private void btnSearchOutputDir_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtOutput.Text = fbd.SelectedPath;
            }
        }
    }
}
