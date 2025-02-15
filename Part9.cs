using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Immutable_Observable_Concurrent
{
    internal class Part9 : GenericPart<Part9>
    {
        protected override ImmutableList<string> AddLines(ImmutableList<string> previousPoem)
        {
            return previousPoem
                .AddRange(new[]
                {
                    "",
                    "Вот два петуха,",
                    "Которые будят того пастуха,",
                    "Который бранится с коровницей строгою,",
                    "Которая доит корову безрогую,",
                    "Лягнувшую старого пса без хвоста,",
                    "Который за шиворот треплет кота,",
                    "Который пугает и ловит синицу,",
                    "Которая часто ворует пшеницу,",
                    "Которая в темном чулане хранится",
                    "В доме,",
                    "Который построил Джек."
                });
        }
    }
}
