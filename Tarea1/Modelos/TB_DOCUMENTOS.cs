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
    
    public partial class TB_DOCUMENTOS
    {
        public long PK_DOCUMENTO { get; set; }
        public byte[] FL_CIF { get; set; }
        public string FL_MYME_CIF { get; set; }
        public byte[] FL_RFC { get; set; }
        public string FL_MYME_RFC { get; set; }
        public byte[] FL_ACTA_N { get; set; }
        public string FL_MYME_ACTA { get; set; }
        public byte[] FL_FOTO_IR { get; set; }
        public string FL_MYME_IR { get; set; }
        public byte[] FL_COMPROBANTE_D { get; set; }
        public string FL_MYME_CD { get; set; }
        public byte[] FL_CERTIFICADO_E { get; set; }
        public string FL_MYME_C_E { get; set; }
        public byte[] FL_CURP { get; set; }
        public string FL_MYME_CURP { get; set; }
        public byte[] FL_IDENTIFICACION_O { get; set; }
        public string FL_MYME_I_O { get; set; }
        public Nullable<long> FK_USER { get; set; }
        public Nullable<bool> FL_ACTIVO { get; set; }
        public Nullable<long> FK_TRAMITE { get; set; }
    
        public virtual TB_TRAMITES TB_TRAMITES { get; set; }
        public virtual TB_USERS TB_USERS { get; set; }
    }
}
