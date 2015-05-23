using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LECTOR_CFDI.Clases
{
    class classImpuestos
    {

        public string strUUID;
        public string strImpuesto;
        public string strTasa;
        public string strValor;


        public void insertar()
        {
            string strQuery;

            strQuery = "";
            strQuery = "insert into Impuestos values('";
            strQuery = strQuery + strUUID + "','";
            strQuery = strQuery + strImpuesto + "','";
            strQuery = strQuery + strTasa + "','";

            strQuery = strQuery + strValor + "')";


            classConexion con = new classConexion();

            con.ejecutar(strQuery);

        }
    }
}
