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
    
    public partial class tbCandidatos
    {
        public int cand_Id { get; set; }
        public int part_Id { get; set; }
        public int mov_Id { get; set; }
        public int tipcan_Id { get; set; }
        public int censo_Id { get; set; }
        public int depto_Id { get; set; }
        public int muni_Id { get; set; }
        public int cand_Posicion { get; set; }
    
        public virtual tbCentroElectoral tbCentroElectoral { get; set; }
        public virtual tbDepartamentos tbDepartamentos { get; set; }
        public virtual tbMunicipios tbMunicipios { get; set; }
        public virtual tbPartidos tbPartidos { get; set; }
        public virtual tbTipoCandidato tbTipoCandidato { get; set; }
        public virtual tbMovimientos tbMovimientos { get; set; }
    }
}
