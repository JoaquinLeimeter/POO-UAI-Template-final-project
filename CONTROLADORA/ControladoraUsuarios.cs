using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ControladoraUsuarios
    {
        private static ControladoraUsuarios _instancia;

        private ControladoraUsuarios() { }

        public static ControladoraUsuarios obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraUsuarios();
            }
            return _instancia;
        }

        public List<MODELO.Usuario> Listar_Usuarios()
        {
            return MODELO.SingletonContexto.obtener_instancia().Contexto.Usuarios.ToList();
        }

        public void Agregar_Usuario(MODELO.Usuario usuario)
        {
            MODELO.SingletonContexto.obtener_instancia().Contexto.Usuarios.Add(usuario);
            MODELO.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
    }
}
