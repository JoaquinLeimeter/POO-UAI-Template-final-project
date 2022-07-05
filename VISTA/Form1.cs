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
            //traemos usuario actual
            MODELO.Usuario usuario = CONTROLADORA.ControladoraUsuarios.obtener_instancia().usuarioActual;
            
            //traemos los formularios de este usuario (ver metodo en controladora)
            List<MODELO.Formulario> formularios_habilitados = CONTROLADORA.ControladoraFormularios.obtener_instancia().Listar_Formularios(usuario);

            //por cada formulario habilitado, nos conviene porque formularios_habilitados <= todos los formularios para iterar.
            //esto si no tenemos formularios dentro de formularios, piensen como prefieren hacer esta búsqueda.
            formularios_habilitados.ForEach((formulario) =>
            {
                //buscamos en el menuStrip la lista de opciones o la tab donde se encuentra este formulario
                //ToolStripItem[] options = menuStrip1.Items.Find(formulario.NombreSistema, true);

                //como el método .Find nos devuelve un arreglo y no un solo item, usamos .First() para acceder a ese formulario
                //que sabemos que es único porque todos nuestros formularios se llaman distinto.
                //TODO: buscar un mejor método.
                //options.First().Enabled = true;



                //iteramos sobre esta lista de opciones, por ejemplo: gestionar, listarClientes, etc en la tab Usuarios
                //options.ToList().ForEach(option =>
                //{
                //    Console.WriteLine("option.name" + option.Name);
                //    Console.WriteLine("option.name" + option.Name);
                //    Console.WriteLine("option.name" + option.Name);
                //    if (option.Name == formulario.NombreSistema)
                //    {
                //        option.Enabled = true;
                //    }
                //});

                int i = 1;
                foreach (ToolStripMenuItem categoria in menuStrip1.Items)
                {
                    Console.WriteLine($"{i}: {categoria}");
                    i++;
                    int j = 1;
                    foreach (ToolStripMenuItem form in categoria.DropDownItems)
                    {
                        Console.WriteLine($"\t{j}: {form}");
                        if (form.Name == formulario.NombreSistema)
                        {
                            form.Enabled = true;
                        }
                    }
                }
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
