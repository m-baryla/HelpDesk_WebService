using System.Configuration;

namespace WebServiceHost.Model
{
    public static class HelperConnection
    {
        public static string ConnectionStringValue(string value)
        {
            return ConfigurationManager.ConnectionStrings[value].ConnectionString;
        }
    }

}
