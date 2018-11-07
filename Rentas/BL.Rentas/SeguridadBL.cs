using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class SeguridadBL
    {
        Contexto _contexto;

        public SeguridadBL()
        {
            _contexto = new Contexto();
        }

        public Resultado Autorizar(string usuario, string contrasena)
        {
            var resultado = new Resultado();
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.Nombre && contrasena == usuarioDB.Contrasena)
                {
                    resultado.Exitoso = true;
                    resultado.Usuario = usuarioDB;

                    return resultado;
                }
            }

            resultado.Mensaje = "Usuario o contraseña incorrecta";
            return resultado;
        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }

        public bool PuedeVerFacturas { get; set; }
        public bool PuedeVerClientes { get; set; }
        public bool PuedeVerProductos { get; set; }
        public bool PuedeVerReportes { get; set; }
    }
}
