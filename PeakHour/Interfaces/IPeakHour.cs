using PeakHour.Data;
using PeakHour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakHour.Interfaces
{
    public interface IPeakHour
    {
        void AddPeakHour(tblPeakHour hours);

        void EditPeakHour(int id, tblPeakHour hour);

        void DeletePeak(int id);

        IEnumerable<tblPeakHour> GetPeaks();

        void Save();

    }
}
