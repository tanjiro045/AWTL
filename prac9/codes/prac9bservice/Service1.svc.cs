using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Practical9b_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public DataSet getEmployees()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-LABV26J8;Initial Catalog=MCA;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM EMP", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataSet);
            sqlConnection.Close();
            return dataSet;
        }
    }
}
