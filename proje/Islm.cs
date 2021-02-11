using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proje
{
    class Islm
    {
      public  static string adrs = System.IO.File.ReadAllText(@"C:\test.txt");
      public void StokKayıt(string bno,double mktr,double mmktr)
        { SqlConnection bgl = new SqlConnection(adrs);
            bgl.Open();
            SqlCommand cmd = new SqlCommand("Update Tablo set Miktar=@mktr where ID=@id1", bgl);
            cmd.Parameters.AddWithValue("@id1", bno);
            cmd.Parameters.AddWithValue("@mktr", mmktr+mktr);
            cmd.ExecuteNonQuery();
            bgl.Close();
        }
      
        
    }
  
}
