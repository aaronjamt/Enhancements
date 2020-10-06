﻿using System.Collections.Generic;
using IPA.Config.Stores.Attributes;
using IPA.Config.Stores.Converters;

namespace Enhancements.Clock
{
    public class ClockSettings
    {
        public virtual string Format { get; set; } = "h:mm tt";

        public virtual string Culture { get; set; } = "";

        [NonNullable]
        [UseConverter(typeof(ListConverter<string>))]
        public virtual List<string> Formats { get; set; } = new List<string>()
        {
            "h:mm tt",
            "h:mm:ss tt",
            "HH:mm",
            "HH:mm:ss",
            "dddd",
            "MMMM dd, yyyy | h:mm tt",
        };
    }
}
