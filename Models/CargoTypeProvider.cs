using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 仓库管理系统.Models;

namespace 仓库管理系统
{
    public class CargoTypeProvider : IProvider<CargoType>
    {
        private TestEntities db = new TestEntities();
        public int Delete(CargoType t)
        {
            if (t == null) return 0;
            var model=db.CargoType.ToList().FirstOrDefault(item=>t.Id==item.Id);
            if(model==null) return 0;
            db.CargoType.Remove(model);
            int count=db.SaveChanges();
            return count;
        }

        public int Insert(CargoType t)
        {
            if (t == null) return 0;
            if(string.IsNullOrEmpty(t.Name) || string.IsNullOrEmpty(t.MemberName)) return 0;
            if(t.InsertDate==null) return 0;
            db.CargoType.Add(t);
            int count=db.SaveChanges();
            return count;

        }

        public List<CargoType> Select()
        {
            return db.CargoType.ToList();
        }

        public int Update(CargoType t)
        {
            if (t == null) return 0;
            return 0;
        }
    }
}
