using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 仓库管理系统.Models;

namespace 仓库管理系统
{
    public class Cargo1Provider : IProvider<Cargo1>
    {
        private TestEntities db=new TestEntities();
        public int Delete(Cargo1 t)
        {
            throw new NotImplementedException();
        }

        public int Insert(Cargo1 t)
        {
            throw new NotImplementedException();
        }

        public List<Cargo1> Select()
        {
            throw new NotImplementedException();
        }

        public int Update(Cargo1 t)
        {
            throw new NotImplementedException();
        }
    }
}
