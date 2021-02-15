using System;
using System.Collections.Generic;

namespace xamarin_dex.Models
{
    public class Pokemon
    {
        public int NationalNumber { get; set; }

        public int RegionalNumber { get; set; }
        public string Name { get; set; }
        public Dictionary<string, string> DexEntry { get; set; }

        public Dictionary<string, IEnumerable<string>> ImagesUrl { get; set; }
    }
}