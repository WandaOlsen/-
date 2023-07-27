using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统
{
    public interface IProvider<T> where T : class
    {
        List<T> Select();

        //插入一条记录
        int Insert(T t);

        //修改一条记录
        int Update(T t);

        //删除一条记录
        int Delete(T t);



    }
}
