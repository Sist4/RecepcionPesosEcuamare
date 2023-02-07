using SistemaRecepcionPesos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcionPesos.Controlador
{
    class UsuariosController
    {
        DBEcuamareEntities bd = new DBEcuamareEntities();

        public List<USUARIO> ObtenerUsuarios()
        {
            return bd.USUARIOS.Take(100).ToList();
        }
        public void GuardarUsuario(USUARIO usuario)
        {
            bd.USUARIOS.Add(usuario);
            bd.SaveChanges();
        }
        public string Base64_Encode(string str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }
        public bool ExisteUsuarioEnPeso(int id)
        {
            bool existe = bd.PESOS.Any(x => x.USU_ID == id);
            return existe;
        }
        public USUARIO ObtenerUsuarioPorId(int id)
        {
            USUARIO usuario = (from usu in bd.USUARIOS
                                   where usu.USU_ID==id
                                   select usu).Single();
            return usuario;
        }
        public bool ActualizarUsuario(USUARIO usuario, string nombre, string contraseña,string rol)
        {
            try
            {
                bd.USUARIOS.Attach(usuario);
                usuario.USU_NOMBRES = nombre;
                usuario.USU_CONTRASENA= contraseña;
                usuario.USU_ROL = rol;
                bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool EliminarUsuario(int id)
        {
            try
            {
                USUARIO usuario = bd.USUARIOS.Single(x => x.USU_ID.Equals(id));
                bd.USUARIOS.Remove(usuario);
                bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
