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
    
    public partial class tbMunicipios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbMunicipios()
        {
            this.tbAldeas = new HashSet<tbAldeas>();
            this.tbCandidatos = new HashSet<tbCandidatos>();
            this.tbCentroElectoral = new HashSet<tbCentroElectoral>();
            this.tbCentrosVotacion = new HashSet<tbCentrosVotacion>();
            this.tbPoblados = new HashSet<tbPoblados>();
        }
    
        public int muni_Id { get; set; }
        public string muni_Descripcion { get; set; }
        public int depto_Id { get; set; }
        public int muni_Codigo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAldeas> tbAldeas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCandidatos> tbCandidatos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCentroElectoral> tbCentroElectoral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCentrosVotacion> tbCentrosVotacion { get; set; }
        public virtual tbDepartamentos tbDepartamentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPoblados> tbPoblados { get; set; }
    }
}
