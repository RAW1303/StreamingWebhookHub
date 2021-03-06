﻿using System.Text.Json.Serialization;

namespace Raw.Streaming.Webhook.Model
{
    public class HubSubscriptionRequest
    {
        [JsonPropertyName("hub.callback")]
        public string Callback { get; set; }

        [JsonPropertyName("hub.mode")]
        public string Mode { get; set; }

        [JsonPropertyName("hub.topic")]
        public string Topic { get; set; }

        [JsonPropertyName("hub.lease_seconds")]
        public int LeaseSeconds { get; set; }

        [JsonPropertyName("hub.secret")]
        public string Secret { get; set; }
    }
}
