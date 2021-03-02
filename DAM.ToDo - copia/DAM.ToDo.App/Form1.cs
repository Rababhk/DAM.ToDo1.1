using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM.ToDo.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Form formulario = new Form2();
            //formulario.Show();

        }




        private void Comenzar_Click(object sender, EventArgs e)
        {
            if (usuarioTxt.Text != "" && contraseñaTxt.Text != "")
            {
                    string texto = usuarioTxt.Text.Trim().ToUpper() + " " + contraseñaTxt.Text.Trim();
                    Regex regex = new Regex(texto);

                    MatchCollection acceso = regex.Matches(texto);
                    string usuarios = File.ReadAllText(@"notasAPP.txt").ToUpper();

                    if (regex.IsMatch(usuarios))
                    {
                        Form3 formulario = new Form3();
                        formulario.label1.Text = usuarioTxt.Text.Trim();
                        formulario.Show();
                        clear();
                        this.Close();
                
                
                    }
                    if (!regex.IsMatch(usuarios))
                    {
                        MessageBox.Show("Revise los datos...");

                    }
            }
        }

        private void registrobtn_Click_1(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Close();

        }
        private void clear()
        {
            usuarioTxt.Clear();
            contraseñaTxt.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
