using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tarea1.Modelos;

namespace Tarea1.Controles
{
    public partial class ListadeUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Consultas.Consultas c = new Consultas.Consultas();
            List<NuevoUsuario> resultado = new List<NuevoUsuario>();
            resultado = c.getUsuario();

            if (resultado.Count > 0)
            {
                IdgdUsuarios.AllowPaging = true;
                IdgdUsuarios.DataSource = resultado;
                IdgdUsuarios.DataBind();

            }

       
      
        }

        protected void IdgdUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int nRowIndex = Int32.Parse(e.CommandArgument.ToString());

            string pk = IdgdUsuarios.DataKeys[nRowIndex].Value.ToString();

            int IdPk = int.Parse(pk);


            //Esto es necesario para las actualizaciones de datos

            NuevoUsuario obj = new NuevoUsuario();
            Consultas.Consultas c = new Consultas.Consultas();
            obj = c.getDetallteUsuario(IdPk);
            //ME falta completar esto
            this.IdNombre.Text = obj.FL_NOMBRE;
            this.IdNombre.Visible = true;
            //hacer visibles los campos y mapear los datos faltantes


            var oUser = new TB_USERS();
            oUser.PK_USER = obj.PK_USER;
            //oUser.PK_USER = IdPk;
            oUser.FL_NOMBRE = this.IdNombre.Text;
            oUser.FL_APELLIDO_P = this.IdApp.Text;
            oUser.FL_EMAIL = this.IdEmail.Text;
            CNSFFORMULARIOS2Entities db = new CNSFFORMULARIOS2Entities();

            db.Entry(oUser).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();


            //Lo de abajo borra, esto me sirve para la otra página
            //CNSFFORMULARIOS2Entities db = new CNSFFORMULARIOS2Entities();
            //var oUser = db.TB_USERS.Find(IdPk);
            //db.TB_USERS.Remove(oUser);
            //db.SaveChanges();
        }

        protected void IdgdUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}