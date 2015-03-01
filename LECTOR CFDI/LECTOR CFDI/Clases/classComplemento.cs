using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LECTOR_CFDI.Clases;

namespace LECTOR_CFDI.Clases
{
    class classComplemento
    {
        public string strUUID;
        public string strSelloSat;
        public string strNoCertificadoSat;
        public string strSelloCFD;
        public string strFechaTimbrado;
        public string strVersion;
        
        public void insertar()
        {
            string strQuery;

            strQuery = "";
            strQuery = "insert into Complemento values('";
            strQuery = strQuery+strUUID + "','";
            strQuery = strQuery+strFechaTimbrado + "','";
            strQuery = strQuery+strSelloCFD + "','";
            strQuery = strQuery+strNoCertificadoSat + "','";
            strQuery = strQuery+strSelloSat + "','";
            strQuery = strQuery+strVersion + "')";

            classConexion con= new classConexion();

            con.ejecutar(strQuery);

        }
    }
}
