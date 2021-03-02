
namespace DAM.ToDo.App
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabToDo = new System.Windows.Forms.TabControl();
            this.pagPending = new System.Windows.Forms.TabPage();
            this.lstPending = new System.Windows.Forms.ListBox();
            this.mnuPendiente = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPending = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.PagDone = new System.Windows.Forms.TabPage();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.mnuHecha = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDone = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Todaslst = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusSb = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuTodas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pendienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TabToDo.SuspendLayout();
            this.pagPending.SuspendLayout();
            this.mnuPendiente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PagDone.SuspendLayout();
            this.mnuHecha.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mnuTodas.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabToDo
            // 
            this.TabToDo.Controls.Add(this.pagPending);
            this.TabToDo.Controls.Add(this.PagDone);
            this.TabToDo.Controls.Add(this.tabPage1);
            this.TabToDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabToDo.Font = new System.Drawing.Font("Stencil", 9F);
            this.TabToDo.Location = new System.Drawing.Point(0, 0);
            this.TabToDo.Name = "TabToDo";
            this.TabToDo.SelectedIndex = 0;
            this.TabToDo.ShowToolTips = true;
            this.TabToDo.Size = new System.Drawing.Size(609, 772);
            this.TabToDo.TabIndex = 2;
            // 
            // pagPending
            // 
            this.pagPending.BackgroundImage = global::DAM.ToDo.App.Properties.Resources._1500x844_innovacion_7_0;
            this.pagPending.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pagPending.Controls.Add(this.button3);
            this.pagPending.Controls.Add(this.label1);
            this.pagPending.Controls.Add(this.lstPending);
            this.pagPending.Controls.Add(this.panel1);
            this.pagPending.Controls.Add(this.groupBox1);
            this.pagPending.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pagPending.Location = new System.Drawing.Point(4, 23);
            this.pagPending.Name = "pagPending";
            this.pagPending.Padding = new System.Windows.Forms.Padding(3);
            this.pagPending.Size = new System.Drawing.Size(601, 745);
            this.pagPending.TabIndex = 0;
            this.pagPending.Text = "Pendientes";
            this.pagPending.UseVisualStyleBackColor = true;
            // 
            // lstPending
            // 
            this.lstPending.BackColor = System.Drawing.Color.Black;
            this.lstPending.ContextMenuStrip = this.mnuPendiente;
            this.lstPending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPending.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold);
            this.lstPending.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lstPending.FormattingEnabled = true;
            this.lstPending.Location = new System.Drawing.Point(3, 99);
            this.lstPending.Name = "lstPending";
            this.lstPending.Size = new System.Drawing.Size(595, 572);
            this.lstPending.TabIndex = 2;
            // 
            // mnuPendiente
            // 
            this.mnuPendiente.BackgroundImage = global::DAM.ToDo.App.Properties.Resources.cieloGalax;
            this.mnuPendiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnuPendiente.Font = new System.Drawing.Font("Stencil", 9F);
            this.mnuPendiente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.mnuPendiente.Name = "mnuPending";
            this.mnuPendiente.Size = new System.Drawing.Size(181, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem1.Text = "Hecha";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem2.Text = "Detalles";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Eliminar";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lblPending);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 671);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 71);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::DAM.ToDo.App.Properties.Resources.cieloNotas;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Stencil", 11F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(446, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "CERRAR SESION";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPending.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold);
            this.lblPending.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPending.Location = new System.Drawing.Point(5, 21);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(186, 17);
            this.lblPending.TabIndex = 0;
            this.lblPending.Text = "## Tareas pendientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtTask);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva tarea";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackgroundImage = global::DAM.ToDo.App.Properties.Resources.gjhiojuhijfg;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Font = new System.Drawing.Font("Stencil", 8F);
            this.btnAdd.Location = new System.Drawing.Point(516, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Crear";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTask
            // 
            this.txtTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTask.BackColor = System.Drawing.Color.Black;
            this.txtTask.Font = new System.Drawing.Font("Stencil", 8F);
            this.txtTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTask.Location = new System.Drawing.Point(8, 19);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(485, 59);
            this.txtTask.TabIndex = 0;
            // 
            // PagDone
            // 
            this.PagDone.Controls.Add(this.lstDone);
            this.PagDone.Controls.Add(this.panel2);
            this.PagDone.Location = new System.Drawing.Point(4, 23);
            this.PagDone.Name = "PagDone";
            this.PagDone.Padding = new System.Windows.Forms.Padding(3);
            this.PagDone.Size = new System.Drawing.Size(601, 745);
            this.PagDone.TabIndex = 1;
            this.PagDone.Text = "Hechas";
            this.PagDone.UseVisualStyleBackColor = true;
            // 
            // lstDone
            // 
            this.lstDone.BackColor = System.Drawing.Color.Black;
            this.lstDone.ContextMenuStrip = this.mnuHecha;
            this.lstDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDone.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold);
            this.lstDone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstDone.FormattingEnabled = true;
            this.lstDone.Location = new System.Drawing.Point(3, 3);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(595, 665);
            this.lstDone.TabIndex = 3;
            // 
            // mnuHecha
            // 
            this.mnuHecha.BackgroundImage = global::DAM.ToDo.App.Properties.Resources.cieloGalax;
            this.mnuHecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnuHecha.Font = new System.Drawing.Font("Stencil", 9F);
            this.mnuHecha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.mnuHecha.Name = "mnuPending";
            this.mnuHecha.Size = new System.Drawing.Size(140, 70);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem4.Text = "Pendiente";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem5.Text = "Detalles";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem6.Text = "Eliminar";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DAM.ToDo.App.Properties.Resources._1500x844_innovacion_7_0;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblDone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 668);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 74);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DAM.ToDo.App.Properties.Resources.cieloNotas;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Stencil", 11F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(445, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "CERRAR SESION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDone.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold);
            this.lblDone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDone.Location = new System.Drawing.Point(5, 21);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(155, 17);
            this.lblDone.TabIndex = 0;
            this.lblDone.Text = "## Tareas hechas";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::DAM.ToDo.App.Properties.Resources._1500x844_innovacion_7_0;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.Todaslst);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 745);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Todas las tareas";
            // 
            // Todaslst
            // 
            this.Todaslst.BackColor = System.Drawing.Color.Black;
            this.Todaslst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Todaslst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Todaslst.ForeColor = System.Drawing.SystemColors.Window;
            this.Todaslst.FormattingEnabled = true;
            this.Todaslst.ItemHeight = 14;
            this.Todaslst.Location = new System.Drawing.Point(3, 3);
            this.Todaslst.Name = "Todaslst";
            this.Todaslst.Size = new System.Drawing.Size(595, 739);
            this.Todaslst.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusSb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 750);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(609, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusSb
            // 
            this.StatusSb.Name = "StatusSb";
            this.StatusSb.Size = new System.Drawing.Size(118, 17);
            this.StatusSb.Text = "toolStripStatusLabel1";
            // 
            // mnuTodas
            // 
            this.mnuTodas.BackgroundImage = global::DAM.ToDo.App.Properties.Resources.cieloGalax;
            this.mnuTodas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnuTodas.Font = new System.Drawing.Font("Stencil", 9F);
            this.mnuTodas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendienteToolStripMenuItem,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.mnuTodas.Name = "mnuPending";
            this.mnuTodas.Size = new System.Drawing.Size(140, 92);
            // 
            // pendienteToolStripMenuItem
            // 
            this.pendienteToolStripMenuItem.Name = "pendienteToolStripMenuItem";
            this.pendienteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pendienteToolStripMenuItem.Text = "pendiente";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem7.Text = "Hecha";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem8.Text = "Detalles";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem9.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(564, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = global::DAM.ToDo.App.Properties.Resources.gjhiojuhijfg;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Stencil", 8F);
            this.button3.Location = new System.Drawing.Point(102, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(394, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "MOSTRAR TAREAS PENDIENTES";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DAM.ToDo.App.Properties.Resources._1500x844_innovacion_7_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 772);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TabToDo);
            this.Name = "Form3";
            this.Text = "Form3";
            this.TabToDo.ResumeLayout(false);
            this.pagPending.ResumeLayout(false);
            this.pagPending.PerformLayout();
            this.mnuPendiente.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PagDone.ResumeLayout(false);
            this.mnuHecha.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mnuTodas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabToDo;
        private System.Windows.Forms.TabPage pagPending;
        private System.Windows.Forms.ListBox lstPending;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.TabPage PagDone;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusSb;
        private System.Windows.Forms.ContextMenuStrip mnuPendiente;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip mnuHecha;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox Todaslst;
        private System.Windows.Forms.ContextMenuStrip mnuTodas;
        private System.Windows.Forms.ToolStripMenuItem pendienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}