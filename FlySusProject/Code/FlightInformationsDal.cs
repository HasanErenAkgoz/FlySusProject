using FlySusProject.Prop;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlySusProject.Code
{
    class FlightInformationsDal
    {

        public List<Flight> GetAll()
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {

                return context.Flights.ToList();
            }
        }

      
        public List<Flight> PnrCode(string pnr)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                var result = context.Flights.Where(p => p.PnrCode == pnr).ToList();
                return result;
            }
        }
        public void Delete(Flight flight)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                var entity = context.Entry(flight);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<Flight> Tarih(DateTime pnr)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                var result = context.Flights.Where(p => p.rezTime <= pnr).ToList();
                return result;
            }
        }
        public void Update (Flight flight)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                var entity = context.Entry(flight);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Add(Flight flights)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                context.Flights.Add(flights);
                context.SaveChanges();
            }
        }
    }
}
