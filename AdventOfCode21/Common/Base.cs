using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AdventOfCode21.Common
{
    public abstract class Base
    {
        public static IEnumerable<string> LoadInput(string folder)
        {
            var basePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            return File.ReadAllLines($"{basePath}/../../../{folder}/input.txt");
        }
    }
}
