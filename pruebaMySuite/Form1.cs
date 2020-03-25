using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pruebaMySuite.ServiceMySuite;
using Newtonsoft.Json.Linq;

namespace pruebaMySuite
{
    public partial class Form1 : Form
    {
        FactWSFrontSoapClient clienteMySuite = new FactWSFrontSoapClient("FactWSFrontSoap");
        public Form1()
        {
            InitializeComponent();
        }

        private void test()
        {
            TransactionTag transaccion = new TransactionTag();
            string resultado = clienteMySuite.Authenticate("AAA010101AAA", "MX.AAA010101AAA.tester", "123456789");
            JObject jsonResult = new JObject();
            jsonResult = JObject.Parse(resultado);
            MessageBox.Show(jsonResult["ErrorCode"].ToString());

            //clienteMySuite.JsonServiceCall("", Transactions.CONVERT_NATIVE_XML.ToString(), "");
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            test();
        }
    }
}
