//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiziYorumProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblBlok
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblBlok()
        {
            this.TblYorum = new HashSet<TblYorum>();
        }
    
        public int Blokid { get; set; }
        public string BlokBaslik { get; set; }
        public string Blokicerik { get; set; }
        public Nullable<System.DateTime> BlokTarih { get; set; }
        public string BlokGorsel { get; set; }
        public Nullable<byte> BlokTur { get; set; }
        public Nullable<byte> BlokKategori { get; set; }
    
        public virtual TblKategori TblKategori { get; set; }
        public virtual TblTur TblTur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblYorum> TblYorum { get; set; }
    }
}