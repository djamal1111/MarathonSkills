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
    
    public partial class Sponsorship
    {
        public int SponsorshipId { get; set; }
        public string SponsorName { get; set; }
        public int RegistrationId { get; set; }
        public decimal Amount { get; set; }
    
        public virtual Registration Registration { get; set; }
    }
}
