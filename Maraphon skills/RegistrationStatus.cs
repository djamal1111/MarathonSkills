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
    
    public partial class RegistrationStatus
    {
        public RegistrationStatus()
        {
            this.Registration = new HashSet<Registration>();
        }
    
        public byte RegistrationStatusId { get; set; }
        public string RegistrationStatus1 { get; set; }
    
        public virtual ICollection<Registration> Registration { get; set; }
    }
}
