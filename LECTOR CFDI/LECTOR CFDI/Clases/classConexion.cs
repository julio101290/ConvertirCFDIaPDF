using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite; 

namespace LECTOR_CFDI.Clases
{
    

    
    //Classe para hacer la conexion y ejecutar querys
    class classConexion
    {
        //VARIABLES QUE USAREMOS
        SQLiteConnection SQLcon = new SQLiteConnection("Data Source=|DataDirectory|facturas.s3db;");
        SQLiteCommand SQLcmd;

    public void ejecutar(string strConsulta){
        SQLcon.Open();  
        SQLcmd= new SQLiteCommand (strConsulta,SQLcon);
        SQLcmd.ExecuteNonQuery();
    }
    }
  
}


    
    

