
namespace DAM.ToDo.App
{
    partial class frmToDos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD:DAM.ToDo.App/frmToDos.Designer.cs
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabToDo = new System.Windows.Forms.TabControl();
            this.pagPending = new System.Windows.Forms.TabPage();
            this.lstPending = new System.Windows.Forms.ListBox();
            this.mnuPending = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPending = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.PagDone = new System.Windows.Forms.TabPage();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.mnuDone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detallesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pendienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDone = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.TabToDo.SuspendLayout();
            this.pagPending.SuspendLayout();
            this.mnuPending.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PagDone.SuspendLayout();
            this.mnuDone.SuspendLayout();
            this.panel2.SuspendLayout();
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contraseñaTxt = new System.Windows.Forms.TextBox();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.Comenzar = new System.Windows.Forms.Button();
            this.registrobtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
>>>>>>> 80ae533db1b7250cb925e09910f0850882aa4efe:DAM.ToDo.App/Form1.Designer.cs
            this.SuspendLayout();
            // 
            // label2
            // 
<<<<<<< HEAD:DAM.ToDo.App/frmToDos.Designer.cs
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(277, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbStatus
            // 
            this.sbStatus.Name = "sbStatus";
            this.sbStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // TabToDo
            // 
            this.TabToDo.Controls.Add(this.pagPending);
            this.TabToDo.Controls.Add(this.PagDone);
            this.TabToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabToDo.Location = new System.Drawing.Point(0, 0);
            this.TabToDo.Name = "TabToDo";
            this.TabToDo.SelectedIndex = 0;
            this.TabToDo.Size = new System.Drawing.Size(277, 400);
            this.TabToDo.TabIndex = 1;
            // 
            // pagPending
            // 
            this.pagPending.Controls.Add(this.lstPending);
            this.pagPending.Controls.Add(this.panel1);
            this.pagPending.Controls.Add(this.groupBox1);
            this.pagPending.Location = new System.Drawing.Point(4, 22);
            this.pagPending.Name = "pagPending";
            this.pagPending.Padding = new System.Windows.Forms.Padding(3);
            this.pagPending.Size = new System.Drawing.Size(269, 374);
            this.pagPending.TabIndex = 0;
            this.pagPending.Text = "Pendientes";
            this.pagPending.UseVisualStyleBackColor = true;
            // 
            // lstPending
            // 
            this.lstPending.ContextMenuStrip = this.mnuPending;
            this.lstPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPending.FormattingEnabled = true;
            this.lstPending.Location = new System.Drawing.Point(3, 67);
            this.lstPending.Name = "lstPending";
            this.lstPending.Size = new System.Drawing.Size(263, 270);
            this.lstPending.TabIndex = 2;
            // 
            // mnuPending
            // 
            this.mnuPending.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detallesToolStripMenuItem,
            this.hechaToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.mnuPending.Name = "mnuPending";
            this.mnuPending.Size = new System.Drawing.Size(118, 70);
            // 
            // detallesToolStripMenuItem
            // 
            this.detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
            this.detallesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.detallesToolStripMenuItem.Text = "Detalles";
            // 
            // hechaToolStripMenuItem
            // 
            this.hechaToolStripMenuItem.Name = "hechaToolStripMenuItem";
            this.hechaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.hechaToolStripMenuItem.Text = "Hecha";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPending);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 34);
            this.panel1.TabIndex = 1;
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPending.Location = new System.Drawing.Point(5, 13);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(112, 13);
            this.lblPending.TabIndex = 0;
            this.lblPending.Text = "## Tareas pendientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtTask);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva tarea";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(207, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Crear";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTask
            // 
            this.txtTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTask.Location = new System.Drawing.Point(8, 20);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(193, 20);
            this.txtTask.TabIndex = 0;
            // 
            // PagDone
            // 
            this.PagDone.Controls.Add(this.lstDone);
            this.PagDone.Controls.Add(this.panel2);
            this.PagDone.Location = new System.Drawing.Point(4, 22);
            this.PagDone.Name = "PagDone";
            this.PagDone.Padding = new System.Windows.Forms.Padding(3);
            this.PagDone.Size = new System.Drawing.Size(269, 374);
            this.PagDone.TabIndex = 1;
            this.PagDone.Text = "Hechas";
            this.PagDone.UseVisualStyleBackColor = true;
            // 
            // lstDone
            // 
            this.lstDone.ContextMenuStrip = this.mnuDone;
            this.lstDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDone.FormattingEnabled = true;
            this.lstDone.Location = new System.Drawing.Point(3, 3);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(263, 334);
            this.lstDone.TabIndex = 3;
            // 
            // mnuDone
            // 
            this.mnuDone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detallesToolStripMenuItem1,
            this.pendienteToolStripMenuItem,
            this.eliminarToolStripMenuItem1});
            this.mnuDone.Name = "mnuDone";
            this.mnuDone.Size = new System.Drawing.Size(128, 70);
            // 
            // detallesToolStripMenuItem1
            // 
            this.detallesToolStripMenuItem1.Name = "detallesToolStripMenuItem1";
            this.detallesToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.detallesToolStripMenuItem1.Text = "Detalles";
            // 
            // pendienteToolStripMenuItem
            // 
            this.pendienteToolStripMenuItem.Name = "pendienteToolStripMenuItem";
            this.pendienteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pendienteToolStripMenuItem.Text = "Pendiente";
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
=======
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(54, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(104, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "USUARIO";
            // 
            // contraseñaTxt
            // 
            this.contraseñaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contraseñaTxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.contraseñaTxt.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.contraseñaTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.contraseñaTxt.Location = new System.Drawing.Point(258, 356);
            this.contraseñaTxt.MaximumSize = new System.Drawing.Size(260, 42);
            this.contraseñaTxt.Multiline = true;
            this.contraseñaTxt.Name = "contraseñaTxt";
            this.contraseñaTxt.PasswordChar = '*';
            this.contraseñaTxt.Size = new System.Drawing.Size(260, 42);
            this.contraseñaTxt.TabIndex = 16;
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuarioTxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.usuarioTxt.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.usuarioTxt.Location = new System.Drawing.Point(258, 276);
            this.usuarioTxt.MaximumSize = new System.Drawing.Size(260, 42);
            this.usuarioTxt.MinimumSize = new System.Drawing.Size(260, 42);
            this.usuarioTxt.Multiline = true;
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(260, 42);
            this.usuarioTxt.TabIndex = 15;
            // 
            // Comenzar
            // 
            this.Comenzar.BackColor = System.Drawing.Color.Transparent;
            this.Comenzar.BackgroundImage = global::DAM.ToDo.App.Properties.Resources._1500x844_innovacion_7_0;
            this.Comenzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Comenzar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Comenzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comenzar.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comenzar.ForeColor = System.Drawing.Color.White;
            this.Comenzar.ImageKey = "(ninguno)";
            this.Comenzar.Location = new System.Drawing.Point(0, 508);
            this.Comenzar.Name = "Comenzar";
            this.Comenzar.Size = new System.Drawing.Size(609, 88);
            this.Comenzar.TabIndex = 14;
            this.Comenzar.Text = "Entrar";
            this.Comenzar.UseVisualStyleBackColor = false;
            this.Comenzar.Click += new System.EventHandler(this.Comenzar_Click);
            // 
            // registrobtn
            // 
            this.registrobtn.BackColor = System.Drawing.Color.Transparent;
            this.registrobtn.BackgroundImage = global::DAM.ToDo.App.Properties.Resources._1500x844_innovacion_7_0;
            this.registrobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrobtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.registrobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registrobtn.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrobtn.ForeColor = System.Drawing.Color.White;
            this.registrobtn.ImageKey = "(ninguno)";
            this.registrobtn.Location = new System.Drawing.Point(0, 596);
            this.registrobtn.Name = "registrobtn";
            this.registrobtn.Size = new System.Drawing.Size(609, 88);
            this.registrobtn.TabIndex = 13;
            this.registrobtn.Text = "REGISTRO";
            this.registrobtn.UseVisualStyleBackColor = false;
            this.registrobtn.Click += new System.EventHandler(this.registrobtn_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::DAM.ToDo.App.Properties.Resources._1500x844_innovacion_7_0;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageKey = "(ninguno)";
            this.button2.Location = new System.Drawing.Point(0, 684);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(609, 88);
            this.button2.TabIndex = 12;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 178);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
>>>>>>> 80ae533db1b7250cb925e09910f0850882aa4efe:DAM.ToDo.App/Form1.Designer.cs
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 34);
            this.panel2.TabIndex = 2;
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDone.Location = new System.Drawing.Point(5, 13);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(95, 13);
            this.lblDone.TabIndex = 0;
            this.lblDone.Text = "## Tareas hechas";
            // 
            // frmToDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD:DAM.ToDo.App/frmToDos.Designer.cs
            this.ClientSize = new System.Drawing.Size(277, 422);
            this.Controls.Add(this.TabToDo);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmToDos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmToDos_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TabToDo.ResumeLayout(false);
            this.pagPending.ResumeLayout(false);
            this.mnuPending.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PagDone.ResumeLayout(false);
            this.mnuDone.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
=======
            this.BackgroundImage = global::DAM.ToDo.App.Properties.Resources._1500x844_innovacion_7_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 772);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraseñaTxt);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.Comenzar);
            this.Controls.Add(this.registrobtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
>>>>>>> 80ae533db1b7250cb925e09910f0850882aa4efe:DAM.ToDo.App/Form1.Designer.cs
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD:DAM.ToDo.App/frmToDos.Designer.cs
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbStatus;
        private System.Windows.Forms.TabControl TabToDo;
        private System.Windows.Forms.TabPage pagPending;
        private System.Windows.Forms.TabPage PagDone;
        private System.Windows.Forms.ListBox lstPending;
        private System.Windows.Forms.ContextMenuStrip mnuPending;
        private System.Windows.Forms.ToolStripMenuItem detallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.ContextMenuStrip mnuDone;
        private System.Windows.Forms.ToolStripMenuItem detallesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pendienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDone;
=======
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contraseñaTxt;
        private System.Windows.Forms.Button Comenzar;
        private System.Windows.Forms.Button registrobtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox usuarioTxt;
>>>>>>> 80ae533db1b7250cb925e09910f0850882aa4efe:DAM.ToDo.App/Form1.Designer.cs
    }
}

