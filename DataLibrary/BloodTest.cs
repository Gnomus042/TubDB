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
    
    public partial class BloodTest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BloodTest()
        {
            this.BlTest___Patient = new HashSet<BlTest___Patient>();
        }
    
        public int bltest_id { get; set; }
        public Nullable<double> bltest_leu { get; set; }
        public Nullable<int> bltest_hem { get; set; }
        public Nullable<double> bltest_er { get; set; }
        public Nullable<int> bltest_gran { get; set; }
        public Nullable<int> bltest_limf { get; set; }
        public Nullable<int> bltest_mono { get; set; }
        public Nullable<int> bltest_soy { get; set; }
    
        public virtual BloodTest BloodTest1 { get; set; }
        public virtual BloodTest BloodTest2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlTest___Patient> BlTest___Patient { get; set; }
    }
}