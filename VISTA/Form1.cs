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
            MODELO.Usuario usuario = CONTROLADORA.ControladoraUsuarios.obtener_instancia().usuarioActual;
            
            List<MODELO.Formulario> formularios_habilitados = CONTROLADORA.ControladoraFormularios.obtener_instancia().Listar_Formularios(usuario);
            formularios_habilitados.ForEach((formulario) =>
            {  
                var items = menuStrip1.Items.Find(formulario.NombreSistema, true);
                items.ToList().ForEach(each =>
                {
                    if (each.Name == formulario.NombreSistema)
                    {
                        each.Enabled = true;
                    }
                });
            });
        } 

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionarUsuarios form = new FormGestionarUsuarios();
            form.Show(); 
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaClientes f = new FormListaClientes();
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
