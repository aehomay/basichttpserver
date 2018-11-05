using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicHTTPServer
{
    public class BasicModule : NancyModule
    {
        decimal value = 0;
        public BasicModule()
        {
            Get["/temperature/{value:decimal}", runAsync:true] = async (parameters, token) =>
            {
                return await Task.Run(() => 
                {
                    return "Value " + parameters.value + "25.5000";
                });
            };

            Post["/temperature/{value:decimal}", runAsync:true] = async (parameters, token) => 
            {
                return await Task.Run(() => 
                {
                    value = parameters.value;
                    return HttpStatusCode.OK;
                });
            };
        }
    }
}
