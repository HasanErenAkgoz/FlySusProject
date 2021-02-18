using FlySusProject.Prop;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlySusProject.Code
{
    class emptyseatDal
    {
      
        public List<emptyseat> All()
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {

                return context.emptyseats.OrderBy(p => p.Emptyseats).ToList();
            }
        }
        public void delete(emptyseat empty)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                var entity = context.Entry(empty);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void add(emptyseat empty)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                context.emptyseats.Add(empty);
                context.SaveChanges();
            }
        }

    }
}
