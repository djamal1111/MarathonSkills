//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Maraphon_skills
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.Marathon = new HashSet<Marathon>();
            this.Runner = new HashSet<Runner>();
            this.Volunteer = new HashSet<Volunteer>();
        }
    
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountryFlag { get; set; }
    
        public virtual ICollection<Marathon> Marathon { get; set; }
        public virtual ICollection<Runner> Runner { get; set; }
        public virtual ICollection<Volunteer> Volunteer { get; set; }
    }
}
