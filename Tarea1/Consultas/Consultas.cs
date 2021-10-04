using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tarea1.Modelos;

namespace Tarea1.Consultas
{
    public class Consultas
    {
        public List<NuevoUsuario> getUsuario()
        {
            CNSFFORMULARIOS2Entities c = new CNSFFORMULARIOS2Entities();
            List<NuevoUsuario> respuesta = new List<NuevoUsuario>();

            var lista = (from registro in c.TB_USERS
                         select new NuevoUsuario
                         {
                             PK_USER = registro.PK_USER,
                             FL_NOMBRE = registro.FL_NOMBRE,
                             FL_APELLIDO_P = registro.FL_APELLIDO_P,
                             FL_EMAIL = registro.FL_EMAIL


                         }).ToList();

            if (lista.Count > 0)
            {
                foreach (var i in lista)
                {
                    respuesta.Add(new NuevoUsuario
                    {
                        PK_USER = i.PK_USER,
                        FL_NOMBRE = i.FL_NOMBRE,
                        FL_APELLIDO_P = i.FL_APELLIDO_P,
                        FL_EMAIL = i.FL_EMAIL,
                    });
                }
            }

            return respuesta;
        }
        public List<Actividades> getUsuario1()
        {
            CNSFFORMULARIOS2Entities c = new CNSFFORMULARIOS2Entities();
            List<Actividades> respuesta = new List<Actividades>();

            var lista = (from registro in c.TB_ACTIVIDADES
                         select new Actividades
                         {
                             pk_Actividad = registro.PK_ACTIVIDAD,
                             FL_Descripcion = registro.FL_DESCRIPCION,
                             FL_Name = registro.FL_NAME,

                         }).ToList();

            if (lista.Count > 0)
            {
                foreach (var i in lista)
                {
                    respuesta.Add(new Actividades
                    {
                        pk_Actividad =i.pk_Actividad,
                        FL_Descripcion= i.FL_Descripcion,
                        FL_Name =i.FL_Name,
                    });
                }
            }

            return respuesta;

        }
        public NuevoUsuario getDetallteUsuario(int pk)
        {
            CNSFFORMULARIOS2Entities c = new CNSFFORMULARIOS2Entities();
            NuevoUsuario r = new NuevoUsuario();

            var query = (from a in c.TB_USERS
                         where a.PK_USER == pk
                         select new NuevoUsuario
                         {
                             PK_USER = a.PK_USER,
                             FL_NOMBRE = a.FL_NOMBRE,
                             FL_APELLIDO_P = a.FL_APELLIDO_P,
                             FL_EMAIL = a.FL_EMAIL


                         }).FirstOrDefault();
            if(query != null)
            {
                r = query;
            }
            return r;
        }
    }
}
