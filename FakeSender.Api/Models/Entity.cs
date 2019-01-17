﻿using System;
using Newtonsoft.Json;

namespace FakeSender.Api.Models
{
    public abstract class Entity
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public virtual string EntityId { get; set; }
        [JsonIgnore]
        public DateTime ReceivedAt { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}