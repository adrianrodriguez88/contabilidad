using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad.FRWK.CORE
{
    public class ServicesManager
    {
        private static ServicesManager _instance = null;

        private FRWK.INTERFACES.ISQLService _sqlService = null;

        public static ServicesManager getInstance()
        {
            if (_instance == null)
                _instance = new ServicesManager();
            return _instance;
        }

        private ServicesManager()
        {
            // TODO: Generar las instancias de acuerdo a los servicios implementados
            if (_sqlService == null)
                _sqlService = new FRWK.SERVICES.SQLService();
        }

        public FRWK.INTERFACES.ISQLService getSQLService()
        {
            return _sqlService;
        }

    }
}
