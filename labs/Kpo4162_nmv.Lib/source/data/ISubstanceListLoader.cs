using Kpo4162_nmv.Lib;
using System;
using System.Collections.Generic;

namespace Kpo4162.nmv.Lib
{
    public interface ISubstanceListLoader
    {
        List<Substance> detailsList { get; }
        void Execute();
    }
}