using FlySusProject.Prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlySusProject.Code
{
    class AdminFlightDal
    {
        public List<adminlflightInformations> GetAll()
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {

                return context.AdminlFlightInformations.ToList();
            }
        }
        public void add(adminlflightInformations adminlflight)
        {
            using (FlySusDataContext context = new FlySusDataContext())
            {
                context.AdminlFlightInformations.Add(adminlflight);
                context.SaveChanges();
            }
        }
    }
}
