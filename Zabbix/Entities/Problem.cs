﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public class Problem : IBaseEntitiy
    {
        #region Properties
        [JsonProperty("eventid")]
        public string Eventid { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("objectid")]
        public string Objectid { get; set; }

        [JsonProperty("clock")]
        public string Clock { get; set; }

        [JsonProperty("ns")]
        public string Ns { get; set; }

        [JsonProperty("r_eventid")]
        public string REventid { get; set; }

        [JsonProperty("r_clock")]
        public string RClock { get; set; }

        [JsonProperty("r_ns")]
        public string RNs { get; set; }

        [JsonProperty("correlationid")]
        public string Correlationid { get; set; }

        [JsonProperty("userid")]
        public string Userid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("acknowledged")]
        public string Acknowledged { get; set; }

        [JsonProperty("severity")]
        public string Severity { get; set; }

        [JsonProperty("opdata")]
        public string Opdata { get; set; }

        [JsonProperty("suppressed")]
        public string Suppressed { get; set; }

        #endregion

        #region Components
        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("acknowledges")]
        public List<Acknowledge> Acknowledges { get; set; }

        [JsonProperty("suppression_data")]
        public List<SuppressionData> SuppressionData { get; set; }
        #endregion

    }
}
