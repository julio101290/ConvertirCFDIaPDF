using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LECTOR_CFDI.Clases
{
    class classConceptos
    {
        public string strUUID;
        public string strImporte;
        public string strValorUnitario;
        public string strDescripcion;
        public string strUnidad;
        public string strCantidad;


        public void insertar()
        {
            string strQuery;

            strQuery = "";
            strQuery = "insert into Conceptos values('";
            strQuery = strQuery + strUUID + "','";
            strQuery = strQuery + strImporte + "','";
            strQuery = strQuery + strValorUnitario + "','";
            strQuery = strQuery + strDescripcion + "','";
            strQuery = strQuery + strUnidad + "','";
            strQuery = strQuery + strCantidad + "')";
      

            classConexion con = new classConexion();

            con.ejecutar(strQuery);

        }
        
    }
}
