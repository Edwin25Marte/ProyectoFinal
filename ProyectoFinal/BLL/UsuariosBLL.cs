using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoFinal.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Us User)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Usuario.Add(User);

                db.SaveChanges();
                db.Dispose();
                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static bool Modificar(Us User)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Entry(User).State = EntityState.Modified;

                db.SaveChanges();
                db.Dispose();
                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static bool Eliminar(int id)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                Us User = db.Usuario.Find(id);

                db.Usuario.Remove(User);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static Us Buscar(int id)
        {
            Us User = null;
            try
            {
                Contexto db = new Contexto();
                User = db.Usuario.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return User;
        }

        public static List<Us> GetListTodo()
        {
            List<Us> lista = null;
            try
            {
                Contexto dbase = new Contexto();
                lista = dbase.Usuario.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

        public static List<Us> GetList(Expression<Func<Us, bool>> filter)
        {
            List<Us> list = null;

            try
            {
                Contexto db = new Contexto();
                list = db.Usuario.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
    }
}
