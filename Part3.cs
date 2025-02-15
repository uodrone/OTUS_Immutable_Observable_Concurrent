using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Immutable_Observable_Concurrent
{

    internal class Part3 : GenericPart<Part3>
    {
        protected override ImmutableList<string> AddLines(ImmutableList<string> previousPoem)
        {
            return previousPoem
                .AddRange(new[]
                {
                    "",
                    "А это весёлая птица-синица,",
                    "Которая часто ворует пшеницу,",
                    "Которая в тёмном чулане хранится",
                    "В доме,",
                    "Который построил Джек."
                });
        }
    }
}
