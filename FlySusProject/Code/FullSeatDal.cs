using FlySusProject.Prop;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlySusProject.Code
{
    class FullSeatDal
    {
        public void delete(fullseat fullseats)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                var entity = context.Entry(fullseats);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void add(fullseat fullseats)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                context.fullseats.Add(fullseats);
                context.SaveChanges();
            }
        }
    }
}
