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
    
    public partial class Patients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patients()
        {
            this.BlTest___Patient = new HashSet<BlTest___Patient>();
            this.Consult___Patient = new HashSet<Consult___Patient>();
            this.HepTest___Patient = new HashSet<HepTest___Patient>();
            this.SputumTest___Patient = new HashSet<SputumTest___Patient>();
            this.UrTest__Patient = new HashSet<UrTest__Patient>();
        }
    
        public int p_id { get; set; }
        public string p_name { get; set; }
        public string p_surname { get; set; }
        public string p_secname { get; set; }
        public Nullable<System.DateTime> p_birthday { get; set; }
        public int p_genderId { get; set; }
        public string p_factAddress { get; set; }
        public string p_regAddress { get; set; }
        public Nullable<int> p_diagnosisId { get; set; }
        public Nullable<int> p_typeId { get; set; }
        public Nullable<int> p_bkID { get; set; }
        public Nullable<int> p_destructionId { get; set; }
        public string p_otherDiseases { get; set; }
        public Nullable<System.DateTime> p_firstVisit { get; set; }
        public Nullable<System.DateTime> p_lastVisit { get; set; }
        public string p_result { get; set; }
        public string p_phones { get; set; }
        public string p_komment { get; set; }
    
        public virtual BK BK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlTest___Patient> BlTest___Patient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consult___Patient> Consult___Patient { get; set; }
        public virtual Destruction Destruction { get; set; }
        public virtual Diagnosis Diagnosis { get; set; }
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HepTest___Patient> HepTest___Patient { get; set; }
        public virtual Type Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SputumTest___Patient> SputumTest___Patient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrTest__Patient> UrTest__Patient { get; set; }
    }
}
