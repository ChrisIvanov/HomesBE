﻿using MessagePack;

namespace BuildingMarket.Properties.Application.Models
{
    [MessagePackObject]
    public class ReportRedisModel
    {
        [Key(0)]
        public string UserId { get; set; }

        [Key(1)]
        public DateTime TimeStamp { get; set; }

        [Key(2)]
        public string Reason { get; set; }
    }
}
