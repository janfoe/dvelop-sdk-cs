﻿using System.Collections.Generic;

namespace Dvelop.Sdk.Config.Dto
{
    public class ConfigFeatureDto
    {
        public string AppName { get; set; }
        public List<PredefinedHeadlineDto> PredefinedHeadlines { get; set; }
        public List<CustomHeadlineDto> CustomHeadlines { get; set; }

        public ConfigFeatureDto()
        {
            PredefinedHeadlines = new List<PredefinedHeadlineDto>();
            CustomHeadlines = new List<CustomHeadlineDto>();
        }
    }
}