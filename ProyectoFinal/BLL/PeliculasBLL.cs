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
    public class PeliculasBLL
    {
        public static bool Guardar(Peli Pel)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Pelicula.Add(Pel);

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

        public static bool Modificar(Peli Pel)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Entry(Pel).State = EntityState.Modified;

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
                Peli Pel = db.Pelicula.Find(id);

                db.Pelicula.Remove(Pel);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static Peli Buscar(int id)
        {
            Peli Pel = null;
            try
            {
                Contexto db = new Contexto();
                Pel = db.Pelicula.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return Pel;
        }

        public static List<Peli> GetListTodo()
        {
            List<Peli> lista = null;
            try
            {
                Contexto dbase = new Contexto();
                lista = dbase.Pelicula.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

        public static List<Peli> GetList(Expression<Func<Peli, bool>> filter)
        {
            List<Peli> list = null;

            try
            {
                Contexto db = new Contexto();
                list = db.Pelicula.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
    }
}
