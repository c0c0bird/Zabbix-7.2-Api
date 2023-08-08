﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class HighAvailabilityNodeService : GetService<HighAvailabilityNode, HighAvailabilityNodeInclude, HighAvailabilityNodeProperties>
    {
        public HighAvailabilityNodeService(ICore core) : base(core, "hanode")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<HighAvailabilityNodeProperties, HighAvailabilityNodeInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
    }

    public enum HighAvailabilityNodeInclude
    {
    }
}
