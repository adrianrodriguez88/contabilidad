using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad.ENTIDADES
{
    public class Usuario
    {
        private string uuid, nombre, rol, status, user, contrasena;
        private DateTime cdate;

        public Usuario(string uuid, string nombre, string user, string contrasena, string rol, string status, DateTime cdate)
        {
            this.uuid = uuid;
            this.nombre = nombre;
            this.user = user;
            this.contrasena = contrasena;
            this.rol = rol;
            this.status = status;
            this.cdate = cdate;
        }

        public string Uuid
        {
            get { return uuid; }
            //set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string User
        {
            get { return user; }
        }

        public string Contrasena
        {
            get { return contrasena; }
        }

        public string Rol
        {
            get { return rol; }
        }

        public string Status
        {
            get { return status; }
        }

        public DateTime Cdate
        {
            get { return cdate; }
        }

    }
}
