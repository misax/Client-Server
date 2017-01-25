using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;


namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public List<string> ListProducts()
        {
            List<string> node = new List<string>();
            string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\prog_Log\Documents\Visual Studio 2015\Projects\Client\Server\Database1.mdf;Integrated Security=True";
            try
            {
                using (adventureworkEntities data = new adventureworkEntities(connect))
                {
                    connect = data.Connect;
                    data.IsConect = true;
                    if (data.IsConect)
                    {
                        node.Add(connect);
                    }
                }
               
            }
            catch (Exception)
            {

                throw;
            }
            return node;
        }
    }
}
