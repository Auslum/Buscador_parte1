using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirArchivo_Click(object sender, EventArgs e)
        {
            
            string path = @"C:\Users\ulise\Escritorio\proy_ing_software\Files";
            string[] files = Directory.GetFiles(path);
            float totalTime = 0;

            /*WindowLoadFile.ShowDialog();
            time.Start();
            file = WindowLoadFile.FileName;
            folder = System.IO.Path.GetDirectoryName(file);
            DirectoryInfo di = new DirectoryInfo(folder);
            registroResultados.AppendText("Inicio de limpieza");*/

            foreach (string file in files)
            {
                Stopwatch time = Stopwatch.StartNew();
                string content = File.ReadAllText(file);
                time.Stop();
                totalTime += time.ElapsedMilliseconds;

                string nombre = "\n\rArchivo: " + file;
                string tiempo = "\n\rTiempo de carga: " + time.Elapsed;
                registroResultados.AppendText("\n\r" + nombre + "\n\r" + tiempo + "\n\r");
            }

            string tiempototal = "\n\rTiempo total: " + totalTime + "ms";
            registroResultados.AppendText("\n\n\r" + tiempototal);

        }
    }
}