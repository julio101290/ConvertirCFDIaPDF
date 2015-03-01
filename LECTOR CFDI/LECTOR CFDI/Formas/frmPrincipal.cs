using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Data.SQLite;
using LECTOR_CFDI.Clases; 

namespace LECTOR_CFDI
{
    public partial class Form1 : Form
    {
        string strUUID;
        string strSelloSat;
        string strNoCertificadoSat;
        string strSelloCFD;
        string strFechaTimbrado;
        string strVersion;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer serielizer = new XmlSerializer(typeof(Comprobante));
            XmlTextReader reader = new XmlTextReader(@"C:\xml.xml");
            Comprobante factura = (Comprobante)serielizer.Deserialize(reader);

            classConexion bd = new classConexion();


            classComplemento complemento = new classComplemento();
            complemento.strUUID = (factura.Complemento.Any[0].Attributes[3].Value);
            complemento.strVersion = (factura.Complemento.Any[0].Attributes[2].Value);
            complemento.strFechaTimbrado = (factura.Complemento.Any[0].Attributes[4].Value);
            complemento.strSelloSat = (factura.Complemento.Any[0].Attributes[7].Value);
            complemento.strSelloCFD = (factura.Complemento.Any[0].Attributes[5].Value);
            complemento.strNoCertificadoSat = (factura.Complemento.Any[0].Attributes[6].Value);
            complemento.insertar();

            //INSERTANDO LOS CONCEPTOS
            foreach (ComprobanteConcepto comp in factura.Conceptos)
            {
                classConceptos clsConceptos = new classConceptos();
                clsConceptos.strUUID = complemento.strUUID;
                clsConceptos.strImporte = comp.importe.ToString () ;
                clsConceptos.strDescripcion = comp.descripcion.ToString();
                clsConceptos.strValorUnitario = comp.valorUnitario.ToString();
                clsConceptos.strCantidad = comp.cantidad.ToString();
                clsConceptos.insertar();

            }
        
        }
        
    }
}
