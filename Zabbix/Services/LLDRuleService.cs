﻿using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{

    //TODO Copy method
    public class LldRuleService : CrudService<LldRule, GetLldRuleFilter, LldRuleService.LldRuleResult>
    {

        public LldRuleService(ICore core) : base(core, "discoveryrule")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class LldRuleResult : BaseResult
        {
            [JsonProperty("itemids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class GetLldRuleFilter : GetFilter
    {
        #region Filter Properties

        [JsonProperty("itemids")]
        public IList<string>? ItemIds { get; set; }

        [JsonProperty("groupids")]
        public IList<string>? GroupIds { get; set; }

        [JsonProperty("hostids")]
        public IList<string>? HostIds { get; set; }

        [JsonProperty("inherited")]
        public bool? Inherited { get; set; }

        [JsonProperty("interfaceids")]
        public IList<string>? InterfaceIds { get; set; }

        [JsonProperty("monitored")]
        public bool? Monitored { get; set; }

        [JsonProperty("templated")]
        public bool? Templated { get; set; }

        [JsonProperty("templateids")]
        public IList<string>? TemplateIds { get; set; }

        [JsonProperty("selectFilter")]
        public string? SelectFilter { get; set; }

        [JsonProperty("selectGraphs")]
        public IList<string>? SelectGraphs { get; set; }

        [JsonProperty("selectHostPrototypes")]
        public IList<string>? SelectHostPrototypes { get; set; }

        [JsonProperty("selectHosts")]
        public IList<string>? SelectHosts { get; set; }

        [JsonProperty("selectItems")]
        public IList<string>? SelectItems { get; set; }

        [JsonProperty("selectTriggers")]
        public IList<string>? SelectTriggers { get; set; }

        [JsonProperty("selectLLDMacroPaths")]
        public string? SelectLLDMacroPaths { get; set; }

        [JsonProperty("selectPreprocessing")]
        public string? SelectPreprocessing { get; set; }

        [JsonProperty("selectOverrides")]
        public string? SelectOverrides { get; set; }

        [JsonProperty("filter")]
        public IDictionary<string, object>? Filter { get; set; }

        [JsonProperty("limitSelects")]
        public int? LimitSelects { get; set; }

        #endregion
    }


}
