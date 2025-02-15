using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Immutable_Observable_Concurrent
{
    internal class Part1 : GenericPart<Part1>
    {
        protected override ImmutableList<string> AddLines(ImmutableList<string> previousPoem)
        {
            return previousPoem
                .Add("Вот дом,")
                .Add("Который построил Джек.");
        }
    }
}
