//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 仓库管理系统.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cargo1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string TypeName { get; set; }
        public string Unit { get; set; }
        public Nullable<double> Price { get; set; }
        public string Tag { get; set; }
        public System.DateTime InsertDate { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
    }
}
