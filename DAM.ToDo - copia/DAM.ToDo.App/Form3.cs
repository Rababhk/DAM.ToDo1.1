using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DAM.ToDo.App
{
    public partial class Form3 : Form
    {
        List<string> listaNotas = new List<string>();

        public Form3()
        {
            InitializeComponent();



        }

        private void lecturaNotas()
        {
            string rutaUsuario = @"notasTxt" + label1.Text.Trim() + ".txt";
            if (File.Exists(rutaUsuario))
            {
                string a = File.ReadAllText(rutaUsuario);
                string[] line = a.Split('\n');

                for (int i = 0; i < line.Length; i++)
                {
                    listaNotas.Add(line[i]);
                    lstPending.DataSource = null;
                    lstPending.DataSource = listaNotas;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form formulario = new Form1();
            formulario.Show();
            this.Close();
        }

        private void funcionRegistro(string notaNueva)
        {
            string ruta = @"notasTxt" + label1.Text.Trim() + ".txt";
            TextWriter file = new StreamWriter(ruta, append: true);
            file.WriteLine(notaNueva);
            file.Close();
            MessageBox.Show("Tarea apuntada con exito");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string notaNueva = txtTask.Text;
            funcionRegistro(notaNueva);
            listaNotas.Add(notaNueva);
            lstPending.DataSource = null;
            lstPending.DataSource = listaNotas;




        }

        private void button3_Click(object sender, EventArgs e)
        {
            lecturaNotas();
            button3.Visible = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string ruta = @"notasTxt" + label1.Text.Trim() + ".txt";
            string Text = lstPending.SelectedItem.ToString();
            listaNotas.Remove(Text);
            lstPending.DataSource = null;
            lstPending.DataSource = listaNotas;

            Regex regex = new Regex(Text);
            int f = listaNotas.IndexOf(Text);
            if (regex.IsMatch(ruta))
            {

//                string[] lines = File.ReadAllLines(ruta);
 //               File.Replace(ruta, ruta, ruta);
//             string newLines = "";
//              File.WriteAllLines(ruta, newLines);
            }


            string notaNueva = txtTask.Text;


            MessageBox.Show("Tarea eliminada" + f);
        }
    }
}
