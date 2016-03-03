using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;

namespace UpdateAccountNameTest
{
    public class UpdateAccountInfo : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                Entity AccountEntity = (Entity)context.InputParameters["Target"];
                AccountEntity.Attributes["accountnumber"] = "123456";
                AccountEntity.Attributes["fax"] = "123469";
            }

        }
    }
}
