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
    public class ActorBLL
    {
        public static bool Guardar(Actores Act)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Actor.Add(Act);

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

        public static bool Modificar(Actores Act)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Entry(Act).State = EntityState.Modified;

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
                Actores Act = db.Actor.Find(id);

                db.Actor.Remove(Act);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static Actores Buscar(int id)
        {
            Actores Act = null;
            try
            {
                Contexto db = new Contexto();
                Act = db.Actor.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return Act;
        }

        public static List<Actores> GetListTodo()
        {
            List<Actores> lista = null;
            try
            {
                Contexto dbase = new Contexto();
                lista = dbase.Actor.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

        public static List<Actores> GetList(Expression<Func<Actores, bool>> filter)
        {
            List<Actores> list = null;

            try
            {
                Contexto db = new Contexto();
                list = db.Actor.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
    }
}
