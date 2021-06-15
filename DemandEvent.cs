using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALEventMgt;

namespace DALeEventMgt
{
    public class DemandEvent
    {
        SqlConnection cn = new SqlConnection("server=PAKANATI\\PAKANATI;Integrated Security=true;database=EventManagement");

        // cmd.CommandType = System.Data.CommandType.StoredProcedure;
        public DemandEvent demand()
        {
            SqlCommand cmd = new SqlCommand("[dbo].[demand]", cn);
            //SqlCommand cmd = new SqlCommand("demand", cn);
            cn.Open();
            demanevent de = new demanevent();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    de.events = Convert.ToString(dr["events"]);
                    de.users = Convert.ToString(dr["users"]);

                }
                else
                {

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            cn.Close();
            return de;
        }


    }
}

