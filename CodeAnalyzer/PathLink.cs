﻿using System;
using System.IO;

namespace CodeAnalyzer
{
    internal struct PathLink
    {
        public readonly string Path;

        public bool Valid { get { return !String.IsNullOrEmpty(Path) && File.Exists(Path); } }
        public PathLink(string path)
            : this()
        {
            Path = path;
        }

        public static implicit operator string(PathLink path)
        {
            return path.Path;
        }
        public override string ToString()
        {
            return Path;
        }
    }
}