﻿using System.Collections.Generic;

namespace MetaProgramming.RoslynCTP
{
    public class ScriptInfo
    {
        public IEnumerable<string> Namespaces { get; set; }
        public IEnumerable<string> Assemblies { get; set; }
        public string Script { get; set; }
    }
}
