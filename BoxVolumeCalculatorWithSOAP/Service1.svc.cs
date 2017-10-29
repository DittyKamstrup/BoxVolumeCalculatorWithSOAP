using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BoxVolumeCalculatorWithSOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        private const string ConnectionString = "Server=tcp:dittessqlserver.database.windows.net,1433;Initial Catalog=SchoolDB;Persist Security Info=False;User ID=ditteak;Password=Ditte1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";

        public double GetSide(double volume, double side1, double side2)
        {
            double length = volume / (side1 * side2);
            return length;
        }

        public double GetVolume(double length, double width, double height)
        {
            double volume = length * width * height;
            return volume;
        }

        public int InsertData(string request, double volume, double length, double width, double height)
        {
            const string insertData = "insert into BoxVolumeCalculatorTable (time, request, volume, length, width, height) values (@time, @request, @volume, @length, @width, @height)";

            using (SqlConnection databaseConnection = new SqlConnection(ConnectionString))
            {

                databaseConnection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertData, databaseConnection))
                {
                    insertCommand.Parameters.AddWithValue("@request", request);
                    insertCommand.Parameters.AddWithValue("@volume", volume);
                    insertCommand.Parameters.AddWithValue("@length", length);
                    insertCommand.Parameters.AddWithValue("@width", width);
                    insertCommand.Parameters.AddWithValue("@heigth", height);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
    }
}
