#nullable enable

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hediet.DebugVisualizer.ExtractedData
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    abstract class ExtractedData
    {
        [JsonProperty("kind")]
        public Dictionary<string, bool> Kind
        {
            get
            {
                var d = new Dictionary<string, bool>();
                foreach (var tag in Tags)
                {
                    d.Add(tag, true);
                }
                return d;
            }
        }

        [JsonIgnore]
        public abstract string[] Tags { get; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    class TextData : ExtractedData
    {
        public TextData(string text)
        {
            this.TextValue = text;
        }

        public override string[] Tags => new string[] { "text" };

        [JsonProperty("text")]
        public string TextValue { get; set; }
    }

    class GraphData : ExtractedData
    {
        public override string[] Tags => new string[] { "graph" };

        [JsonProperty("nodes")]
        public IList<NodeGraphData> Nodes { get; set; } = new List<NodeGraphData>();

        [JsonProperty("edges")]
        public IList<EdgeGraphData> Edges { get; set; } = new List<EdgeGraphData>();
    }

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    class NodeGraphData
    {
        public NodeGraphData(string id)
        {
            Id = id;
        }

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("label")]
        public string? Label;

        [JsonProperty("color")]
        public string? Color;

        [JsonProperty("shape")]
        public string? Shape;
    }

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]

    class EdgeGraphData
    {
        public EdgeGraphData(string from, string to)
        {
            From = from;
            To = to;
        }

        [JsonProperty("from")]
        public string From;

        [JsonProperty("to")]
        public string To;

        [JsonProperty("label")]
        public string? Label;

        [JsonProperty("id")]
        public string? Id;

        [JsonProperty("color")]
        public string? Color;

        [JsonProperty("dashes")]
        public bool? Dashes;
    }
}

