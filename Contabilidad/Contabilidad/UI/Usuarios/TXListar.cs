using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Contabilidad.UI.Usuarios
{
    public partial class TXListar : Form
    {

        public TXListar()
        {
            InitializeComponent();
            this.pintarUsuarios();
        }

        private void pintarUsuarios()
        {
           try
            {
                Cursor.Current = Cursors.WaitCursor;
                
                System.Data.SqlClient.SqlConnection conn = FRWK.CORE.ServicesManager.getInstance().getSQLService().getService();
               
                string query = "SELECT uuid, nombre, usuario, contrasena, rol, status, cdate FROM Usuario ORDER BY nombre ASC";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn);
                System.Data.SqlClient.SqlDataReader dr = cmd.ExecuteReader();

                ArrayList listaUsuarios = new ArrayList();
                ENTIDADES.Usuario u = null;

                while(dr.Read())
                {
                    if (!dr.IsDBNull(0) && !dr.IsDBNull(1) && !dr.IsDBNull(2) &&
                        !dr.IsDBNull(3) && !dr.IsDBNull(4) && !dr.IsDBNull(5) &&
                        !dr.IsDBNull(6))
                    {
                        string uuid = dr.GetString(0) + "";
                        string nombre = dr.GetString(1) + "";
                        string usuario = dr.GetString(2) + "";
                        string contrasena = dr.GetString(3) + "";
                        string rol = dr.GetString(4) + "";
                        string status = dr.GetString(5) + "";
                        DateTime cdate = dr.GetDateTime(6);

                        u = new ENTIDADES.Usuario(uuid, nombre, usuario, contrasena, rol, status, cdate);

                        listaUsuarios.Add(u);
                    }
                }
                dr.Close();
                FRWK.CORE.ServicesManager.getInstance().getSQLService().closeService(conn);

                DataView dv = new DataView();

                DataTable dtUsuarios = new DataTable("dtUsuarios");
                dtUsuarios.Columns.Add("Uuid");
                dtUsuarios.Columns.Add("Nombre");
                dtUsuarios.Columns.Add("Usuario");
                dtUsuarios.Columns.Add("Rol");
                dtUsuarios.Columns.Add("Status");
                dtUsuarios.Columns.Add("FechaAlta");

                foreach (ENTIDADES.Usuario usuario in listaUsuarios)
                {
                   dtUsuarios.Rows.Add(usuario.Uuid, usuario.Nombre, usuario.User, usuario.Rol,
                        usuario.Status, usuario.Cdate.ToShortDateString());
                }

                dv.Table = dtUsuarios;
                bindingSource1.DataSource = dv;
                gridUsuarios.DataSource = bindingSource1;
                gridUsuarios.ReadOnly = true;

                gridUsuarios.Columns["Uuid"].Width = 100;
                gridUsuarios.Columns["Nombre"].Width = 150;
                gridUsuarios.Columns["Usuario"].Width = 100;
                gridUsuarios.Columns["Rol"].Width = 100;
                gridUsuarios.Columns["Status"].Width = 100;
                gridUsuarios.Columns["FechaAlta"].Width = 100;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("ERROR: "+e.Message);
            }
        }
    }
}
