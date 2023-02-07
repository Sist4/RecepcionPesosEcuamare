﻿using SistemaRecepcionPesos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcionPesos.Controlador
{
    class LoginController
    {
        DBEcuamareEntities bd = new DBEcuamareEntities();

        public USUARIO obtenerUsuarioLogeado(string usuario, string contraseña)
        {
            string pass = Base64_Encode(contraseña);
            USUARIO usuarioActual = (from u in bd.USUARIOS
                                     where u.USU_USUARIO.Equals(usuario) & u.USU_CONTRASENA.Equals(pass)
                                     select u).FirstOrDefault();
            return usuarioActual;
        }
        public string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        public string Base64_Decode(string str)
        {
            try
            {
                byte[] decbuff = Convert.FromBase64String(str);
                return System.Text.Encoding.UTF8.GetString(decbuff);
            }
            catch
            {
                //si se envia una cadena si codificación base64, mandamos vacio
                return "";
            }
        }
        public static string Base64_Encode(string str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }
    }
}
