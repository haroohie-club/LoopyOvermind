using System;
using System.Collections.Generic;
using System.IO;

namespace Config {
    public class AppConfig {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Channel { get; set; }
        public Dictionary<string, Updates> UpdateChannel { get; set; }
        public class Updates {
            public string Endpoint { get; set; }
        }
        
    }
}