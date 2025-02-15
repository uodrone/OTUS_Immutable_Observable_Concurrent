using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Immutable_Observable_Concurrent
{
    public interface IPart
    {
        ImmutableList<string> Poem { get; }
        ImmutableList<string> AddPart(ImmutableList<string> previousPoem);
        void PrintPoem(string partName);
    }
}
