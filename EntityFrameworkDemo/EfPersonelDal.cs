using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkDemo
{
    public class EfPersonelDal
    {
        public void Add(Personel personel)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Personels.Add(personel);
                context.SaveChanges();
            }
        }

        public void Delete(Personel personel)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Personels.Remove(context.Personels.SingleOrDefault(p => p.Id == personel.Id));
                context.SaveChanges();
            }
        }


        public void Update(Personel personel)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var personelToUpdate = context.Personels.SingleOrDefault(p => p.Id == personel.Id);
                personelToUpdate.Id = personel.Id;
                personelToUpdate.Name = personel.Name;
                personelToUpdate.Surname = personel.Surname;
                context.SaveChanges();
            }
        }
        public List<Personel> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Personels.ToList();
            }
        }

        public Personel GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Personels.SingleOrDefault(p => p.Id == id);
            }
        }
    }
}
