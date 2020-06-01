using PeakHour.Data;
using PeakHour.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakHour.Repository
{
    
    public class IPeakHourRepo: IPeakHour
    {
        private PeakHourEntities _context;

        public IPeakHourRepo(PeakHourEntities context)
        {
            _context = context;
        }

        public void AddPeakHour(tblPeakHour hours)
        {
             _context.tblPeakHours.Add(hours);
        }

        public void DeletePeak(int id)
        {
            tblPeakHour hour = _context.tblPeakHours.Find(id);
            if(hour != null)
            {
                _context.tblPeakHours.Remove(hour);
            }
        }

        public void EditPeakHour(int id, tblPeakHour hour)
        {
            _context.Entry(hour).State = System.Data.Entity.EntityState.Modified;
        }

        IEnumerable<tblPeakHour> IPeakHour.GetPeaks()
        {
            return _context.tblPeakHours.ToList();
        }

        void IPeakHour.Save()
        {
            throw new NotImplementedException();
        }
    }
}
