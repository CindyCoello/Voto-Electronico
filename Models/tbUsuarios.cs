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
    
    public partial class tbUsuarios
    {
        public int usu_Id { get; set; }
        public string usu_Identidad { get; set; }
        public string usu_PrimerNombre { get; set; }
        public string usu_PrimerApellido { get; set; }
        public string usu_SegundoNombre { get; set; }
        public string usu_SegundoApellido { get; set; }
        public string usu_Telefono { get; set; }
        public byte[] usu_Contraseña { get; set; }
        public int rol_Id { get; set; }
        public bool usu_EsActivo { get; set; }
    
        public virtual tbRoles tbRoles { get; set; }
    }
}
