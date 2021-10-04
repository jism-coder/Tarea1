using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea1.Modelos
{
    public class Modelos
    {
        public string Nombre { get; set; }
    }
    public class Actividades
    {
        public string FL_Descripcion { get; set; }
        public long pk_Actividad { get; set; }
        public string FL_Name { get; set; }

    }
    public class NuevoUsuario
    {
        public long PK_USER { get; set; }
        public string FL_NOMBRE { get; set; }
        public string FL_EMAIL { get; set; }
        public string FL_PASSWORD { get; set; }
        public Nullable<int> FL_ESTATUS { get; set; }
        public string FL_RFC { get; set; }
        public string FL_CURP { get; set; }
        public Nullable<System.DateTime> FL_FECHA { get; set; }
        public Nullable<int> FL_PERFIL { get; set; }
        public Nullable<long> FK_INSTITUCION { get; set; }
        public string FL_APELLIDO_P { get; set; }
        public string FL_APELLIDO_M { get; set; }
        public string FL_GUID { get; set; }
        public string FL_TELEFONO_O { get; set; }
        public string FL_TELEFONO_P { get; set; }
        public string FL_TEL_CEL { get; set; }
        public string FL_CALLE_F { get; set; }
        public string FL_NUM_I_F { get; set; }
        public string FL_NUMERO_E_F { get; set; }
        public string FL_COLONIA_F { get; set; }
        public string FL_POBLACION_F { get; set; }
        public string FL_ESTADO_F { get; set; }
        public string FL_CP_F { get; set; }
        public string FL_CALLE_P { get; set; }
        public string FL_NUM_E_P { get; set; }
        public string FL_NUMERO_I_P { get; set; }
        public string FL_COLONIA_P { get; set; }
        public string FL_ESTADO_P { get; set; }
        public string FL_CP_P { get; set; }
        public string FL_POBLACION_P { get; set; }
        public Nullable<bool> FL_TERMINOS { get; set; }
        public Nullable<System.DateTime> FL_FECHA_NACIMIENTO { get; set; }
        public string FL_NACIONALIDAD { get; set; }
        public string FL_LUGAR_NACIMEINTO { get; set; }
        public string FL_ESCOLARIDAD { get; set; }
        public string FL_SESSION { get; set; }


    }
}