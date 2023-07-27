using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 仓库管理系统.Models;

namespace 仓库管理系统
{
    public class RecordProvider : IProvider<Record>
    {
        private TestEntities db = new TestEntities();
        public int Delete(Record t)
        {
            throw new NotImplementedException();
        }

        public int Insert(Record t)
        {
            throw new NotImplementedException();
        }

        public List<Record> Select()
        {
            throw new NotImplementedException();
        }

        public int Update(Record t)
        {
            throw new NotImplementedException();
        }
    }
}
