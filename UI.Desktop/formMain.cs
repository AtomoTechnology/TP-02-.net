using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class formMain : Form
    {
        Form form = null;
        public formMain()
        {
            InitializeComponent();
            this.DiseableMenu();
        }

        private void mnuArchivo_Click(object sender, EventArgs e)
        {

        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formMain_Shown(object sender, EventArgs e)
        {

            formLogin appLogin = new formLogin();
            //appLogin.ShowDialog();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {            
                this.Dispose();
            }
            else
            {
                
                this.mnsPrincipal.Visible = true;

                if (Sesion.userType == 1)
                {
                    this.GetAdmin();
                }
                else if (Sesion.userType == 2)
                {
                    this.GetTeacher();
                }
                else
                {
                    this.GetStudent();
                }
            }
           
          
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }
        private void GetAdmin(  )
        {
            this.aBMAlumnoToolStripMenuItem.Visible = true;
            this.profesoresToolStripMenuItem.Visible =  true;
            this.adminToolStripMenuItem.Visible = true;

        }
        private void GetStudent()
        {
            this.aBMAlumnoToolStripMenuItem.Visible = true;
            this.profesoresToolStripMenuItem.Visible = false;
            this.adminToolStripMenuItem.Visible = false;
        }
        private void GetTeacher()
        {
            this.aBMAlumnoToolStripMenuItem.Visible = false;
            this.profesoresToolStripMenuItem.Visible = true;
            this.adminToolStripMenuItem.Visible = false;
        }
        private void DiseableMenu()
        {
            this.aBMAlumnoToolStripMenuItem.Visible = false;
            this.profesoresToolStripMenuItem.Visible = false;
            this.adminToolStripMenuItem.Visible = false;
            this.mnsPrincipal.Visible = false;
        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void crearPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOtherForm();
            this.form = null;
            form = new Usuario();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
            
            //if(usuario == null)
            //{
            //usuario = new Usuario();
            //usuario.FormClosed += Usuario_FormClosed;
            //usuario.Show();
            //}
            //else
            //{
            //    usuario.Activate();
            //}
            //usuario.ShowDialog();
        }

        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
          

        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOtherForm();
            this.form = null;
            form = new Planes();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void CloseOtherForm()
        {
            foreach (var item in MdiChildren)
            {
                item.Close();
                item.Dispose();
            }
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOtherForm();
            this.form = null;
            form = new Comisiones();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseOtherForm();
            this.form = null;
            form = new Cursos();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
