using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM.ToDo.App
{
    public partial class frmToDos : Form
    {
        private ToDos Does;   // = new ToDos()
        public frmToDos()
        {
            InitializeComponent();
        }

        private void frmToDos_Load(object sender, EventArgs e)
        {
           Does = new ToDos();
            var t1 = Does.Add("Examen de desarrollo");
            var t2 = Does.Add("practica");
            var t3 = Does.Add("practica 3");
            Does.Do(t3);
            refreshPendingData();
            refreshDoneData();
            sbStatus.Text = "Datos cargados correctamente";

        }

        private void refreshPendingData()
        {
            lstPending.DataSource = null;
            lstPending.DataSource = Does.GetPending();
            lstPending.DisplayMember = "Task";
            lblPending.Text = lstPending.Items.Count + " tareas pendientes";
        }

        private void refreshDoneData()
        {
            lstDone.DataSource = null;
            lstDone.DataSource = Does.done();
            lstDone.DisplayMember = "Task";
            lstDone.Text = lstDone.Items.Count + " tareas hechas";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
