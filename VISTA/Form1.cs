using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //aquí hay que hacer una lógica para disablear ciertos botones dependiendo de 
            //los permisos que tenga el usuario actualmente logueado.
            //gestionarToolStripMenuItem.Enabled = false;
            //Login login = new Login();
            //login.Show();
        } 

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionarUsuarios form = new FormGestionarUsuarios();
            form.Show(); 
        }
    }
}
