//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea1.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_INSTITUCIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_INSTITUCIONES()
        {
            this.TB_USERS = new HashSet<TB_USERS>();
        }
    
        public long PK_INSTITUCION { get; set; }
        public string FL_NAME { get; set; }
        public Nullable<int> FL_SECTOR { get; set; }
        public Nullable<bool> FL_ACTIVO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_USERS> TB_USERS { get; set; }
    }
}
