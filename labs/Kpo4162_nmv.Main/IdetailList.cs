using System;

namespace Kpo4162.nmv.Lib
{
    public interface IdetailsList
    {
        List<Details> detailsList { get; }
        void Execute();
    }
}