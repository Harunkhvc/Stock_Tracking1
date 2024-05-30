using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DevExpress.ClipboardSource.SpreadsheetML;
using System.Drawing;

namespace Stock_Tracking1
{
    internal class Sqlbaglanti
    {
        public SqlConnection baglanti()

        {
            SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-RSCA302\\SQLEXPRESS; Initial Catalog = dbo.StockTracking; Integrated Security = True;");
            baglan.Open();
            return baglan;
        }
    }
}
