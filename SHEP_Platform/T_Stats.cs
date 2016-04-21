//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SHEP_Platform
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Stats
    {
        public int Id { get; set; }
        public string StatCode { get; set; }
        public Nullable<int> StatCodeUp { get; set; }
        public string StatName { get; set; }
        public string ChargeMan { get; set; }
        public string Telepone { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public int Country { get; set; }
        public string Street { get; set; }
        public double Square { get; set; }
        public System.DateTime ProStartTime { get; set; }
        public byte Stage { get; set; }
        public string ProType { get; set; }
        public Nullable<int> AlarmType { get; set; }
    
        public virtual T_AlarmType T_AlarmType { get; set; }
        public virtual T_Country T_Country { get; set; }
        public virtual T_Stage T_Stage { get; set; }
    }
}
