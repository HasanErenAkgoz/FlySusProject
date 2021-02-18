using FlySusProject.Prop;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlySusProject.Code
{
    class passengerInformationsDal
    {
        public List<passangerInformation> GetAll()
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                return context.passangerInformations.ToList();
            }
        }
        public void add(passangerInformation passanger)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                context.passangerInformations.Add(passanger);
                context.SaveChanges();
            }
        }
        public List<passangerInformation> PnrCode(int pnr)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                var result = context.passangerInformations.Where(p => p.PassangerCode == pnr).ToList();
                return result;
            }
        }
        public void delete(passangerInformation passanger)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                var entity = context.Entry(passanger);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }
    }
}
