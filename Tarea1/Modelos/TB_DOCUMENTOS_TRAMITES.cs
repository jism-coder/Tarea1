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
    
    public partial class TB_DOCUMENTOS_TRAMITES
    {
        public long PK_OFICINA_TRAMITE { get; set; }
        public Nullable<long> FK_TRAMITE { get; set; }
        public Nullable<long> FK_DOCUMENTO { get; set; }
        public Nullable<bool> FL_ACTIVO { get; set; }
        public Nullable<bool> FL_OBLIGATORIO { get; set; }
    
        public virtual TB_TIPO_DOCUMENTOS TB_TIPO_DOCUMENTOS { get; set; }
        public virtual TB_TRAMITES TB_TRAMITES { get; set; }
    }
}
