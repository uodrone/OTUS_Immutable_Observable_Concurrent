using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Immutable_Observable_Concurrent
{
    internal class Part4 : GenericPart<Part4>
    {
        protected override ImmutableList<string> AddLines(ImmutableList<string> previousPoem)
        {
            return previousPoem
                .AddRange(new[]
                {
                    "",
                    "Вот кот,",
                    "Который пугает и ловит синицу,",
                    "Которая часто ворует пшеницу,",
                    "Которая в темном чулане хранится",
                    "В доме,",
                    "Который построил Джек."
                });
        }
    }
}
