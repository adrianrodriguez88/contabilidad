using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad.ENTITIES
{
    public class User
    {
        private string uuid, name, role, status;
        private DateTime cdate;

        public User(string uuid, string name, string role, string status)
        {
            this.uuid = uuid;
            this.name = name;
            this.role = role;
            this.status = status;
        }

        public string Uuid
        {
            get { return uuid; }
            //set { id = value; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Role
        {
            get { return role; }
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
