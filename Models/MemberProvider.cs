using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 仓库管理系统.Models;

namespace 仓库管理系统
{
    public class MemberProvider : IProvider<Member>
    {
        private TestEntities db =new TestEntities();
        public int Delete(Member t)
        {
            throw new NotImplementedException();
        }

        public int Insert(Member t)
        {
            throw new NotImplementedException();
        }

        public List<Member> Select()
        {
            return db.Member.ToList();
        }

        public int Update(Member t)
        {
            throw new NotImplementedException();
        }
    }
}
