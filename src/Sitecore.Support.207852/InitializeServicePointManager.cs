using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Sitecore.Pipelines;

namespace Sitecore.Support.Pipelines.Loader
{
    public class InitializeServicePointManager
    {
        public void Process(PipelineArgs args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
    }
}