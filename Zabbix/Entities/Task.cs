﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;

namespace Zabbix.Entities
{

    //TODO: this is probably wrong or bad or both

    public class TaskObject : BaseEntitiy
    {
        #region Properties
        [JsonProperty("taskid")]
        public override string EntityId { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("clock")]
        public string Clock { get; set; }

        [JsonProperty("ttl")]
        public int Ttl { get; set; }

        [JsonProperty("proxy_hostid")]
        public string ProxyHostId { get; set; }
        #endregion


        #region Components
        [JsonProperty("request")]
        public TaskTypeObject Request { get; set; }

        [JsonProperty("result")]
        public StatisticResult Result { get; set; }
        #endregion
    }

    public class CheckNowRequest : TaskTypeObject
    {
        #region Properties

        [JsonProperty("itemid")]
        public string ItemId { get; set; }

        #endregion
    }

    public class DiagnosticInformationRequest : TaskTypeObject
    {
        #region Components

        [JsonProperty("historycache")]
        public StatisticRequest HistoryCache { get; set; }

        [JsonProperty("valuecache")]
        public StatisticRequest ValueCache { get; set; }

        [JsonProperty("preprocessing")]
        public StatisticRequest Preprocessing { get; set; }

        [JsonProperty("alerting")]
        public StatisticRequest Alerting { get; set; }

        [JsonProperty("lld")]
        public StatisticRequest Lld { get; set; }

        #endregion

    }
    public class StatisticRequest
    {
        #region Properties

        [JsonProperty("stats")]
        public string Query { get; set; } = "extend";

        [JsonProperty("top")]
        public object Top { get; set; }

        #endregion

    }

    public class StatisticResult
    {
        #region Properties

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }

        #endregion

    }

    #region DummyClass

    public class TaskTypeObject
    {

    }

    #endregion


}
