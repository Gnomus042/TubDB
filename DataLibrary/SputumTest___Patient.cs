//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class SputumTest___Patient
    {
        public int sptp_id { get; set; }
        public int sptp_patid { get; set; }
        public int sptp_testid { get; set; }
        public System.DateTime sptp_date { get; set; }
        public int sptp_state { get; set; }
    
        public virtual Patients Patients { get; set; }
        public virtual SputumTest SputumTest { get; set; }
        public virtual State State { get; set; }
    }
}
