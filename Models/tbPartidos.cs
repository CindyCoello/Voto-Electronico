//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VotoElectronico.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbPartidos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbPartidos()
        {
            this.tbCandidatos = new HashSet<tbCandidatos>();
            this.tbMovimientos = new HashSet<tbMovimientos>();
        }
    
        public int part_Id { get; set; }
        public string part_Nombre { get; set; }
        public string part_Siglas { get; set; }
        public string part_Sede { get; set; }
        public string part_ColorEmblema { get; set; }
        public string part_Logo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCandidatos> tbCandidatos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMovimientos> tbMovimientos { get; set; }
    }
}
