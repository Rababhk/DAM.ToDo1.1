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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();

        }

        private void registrobtn_Click(object sender, EventArgs e)
        {

            
            string usuario = usuarioTxt.Text.Trim().ToUpper();
            string contraseña = contraseñaTxt.Text.Trim();

            string texto = usuarioTxt.Text.Trim().ToUpper();
            Regex regex = new Regex(texto);

            MatchCollection acceso = regex.Matches(texto);
            string usuarios = File.ReadAllText(@"notasAPP.txt");


            if (usuarioTxt.Text.Trim() != "" && contraseñaTxt.Text !="" && comprobarCtrTxt.Text != "")
            {
                if (comprobarCtrTxt.Text.Trim() == contraseñaTxt.Text.Trim())
                {

                    if (regex.IsMatch(usuarios))
                    {
                        MessageBox.Show("Ya existe el nombre de usuario, pruebe con otro nickname");
                    }
                    if (!regex.IsMatch(usuarios))
                    {
                        funcionRegistro(usuario, contraseña);
                        MessageBox.Show("Recuerde: \nUsuario: " + usuario + "\n Contraseña: " + contraseña);
                        Form formulario = new Form1();
                        formulario.Show();
                        this.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("Las contraseñas no coiciden");
                }
            }
            else { MessageBox.Show("Escriba algo por favor");}
        
        }
        private void funcionRegistro(string usuario, string contraseña)
        {
            TextWriter file = new StreamWriter(@"notasAPP.txt", append: true);
            file.WriteLine(usuario + " " + contraseña);
            file.Close();
            MessageBox.Show("Registrado con exito");
            clear();
        }

        private void clear()
        {
            usuarioTxt.Clear();
            contraseñaTxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();
        }
    }
}
