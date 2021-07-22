using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApi
{
    public class Elephant
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string species { get; set; }
    }
}
