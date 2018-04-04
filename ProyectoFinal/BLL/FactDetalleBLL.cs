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
    public class FactDetalleBLL
    {
        public static bool Guardar(FactDetalle FD)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.FactDetalle.Add(FD);

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

        public static bool Modificar(FactDetalle FD)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Entry(FD).State = EntityState.Modified;

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
                FactDetalle FD = db.FactDetalle.Find(id);

                db.FactDetalle.Remove(FD);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static FactDetalle Buscar(int id)
        {
            FactDetalle FD = null;
            try
            {
                Contexto db = new Contexto();
                FD = db.FactDetalle.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return FD;
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

        public static List<FactDetalle> GetList(Expression<Func<FactDetalle, bool>> filter)
        {
            List<FactDetalle> list = null;

            try
            {
                Contexto db = new Contexto();
                list = db.FactDetalle.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
    }
}
