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
    public class GenerosBLL
    {
        public static bool Guardar(Generos Gen)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Genero.Add(Gen);

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

        public static bool Modificar(Generos Gen)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Entry(Gen).State = EntityState.Modified;

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
                Generos Gen = db.Genero.Find(id);

                db.Genero.Remove(Gen);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static Generos Buscar(int id)
        {
            Generos Gen = null;
            try
            {
                Contexto db = new Contexto();
                Gen = db.Genero.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return Gen;
        }

        public static List<Generos> GetListTodo()
        {
            List<Generos> lista = null;
            try
            {
                Contexto dbase = new Contexto();
                lista = dbase.Genero.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

        public static List<Generos> GetList(Expression<Func<Generos, bool>> filter)
        {
            List<Generos> list = null;

            try
            {
                Contexto db = new Contexto();
                list = db.Genero.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
    }
}
