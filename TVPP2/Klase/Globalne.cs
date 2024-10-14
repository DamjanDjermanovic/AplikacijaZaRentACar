using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPP2.Klase
{
    public class Globalne
    {
        public static void ZameniFormu(Form trenutnaForma, Form novaForma)
        {
            novaForma.FormClosed += (s, args) => trenutnaForma.Dispose();
            novaForma.Show();
            trenutnaForma.Hide();
        }
    }
}
