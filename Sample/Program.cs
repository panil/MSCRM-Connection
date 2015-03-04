using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CRMConnect;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Xrm.Sdk.IOrganizationService _service = null;
            Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy _serviceProxy;
            ServerConnection serverConnect = new ServerConnection();

            // Final parameter of this method is your CRM version. like crm4, crm5 etc. If you pass Blank value it will use crm default.
            ServerConnection.Configuration config = serverConnect.GetServerConfiguration("YourUserName", "YourPassword", "crm");
            
            _serviceProxy = ServerConnection.GetOrganizationProxy(config);

            // This statement is required to enable early-bound type support.
            _serviceProxy.EnableProxyTypes();

            _service = (Microsoft.Xrm.Sdk.IOrganizationService)_serviceProxy;
        }
    }
}
