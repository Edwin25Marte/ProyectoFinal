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
    public class FacturaBLL
    {
        public static bool Guardar(Fact Fact)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Factura.Add(Fact);

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

        public static bool Modificar(Fact Fact)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Entry(Fact).State = EntityState.Modified;

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
                Fact Fact = db.Factura.Find(id);

                db.Factura.Remove(Fact);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static Fact Buscar(int id)
        {
            Fact Fact = null;
            try
            {
                Contexto db = new Contexto();
                Fact = db.Factura.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return Fact;
        }

        public static List<Fact> GetListTodo()
        {
            List<Fact> lista = null;
            try
            {
                Contexto dbase = new Contexto();
                lista = dbase.Factura.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

        public static List<Fact> GetList(Expression<Func<Fact, bool>> filter)
        {
            List<Fact> list = null;

            try
            {
                Contexto db = new Contexto();
                list = db.Factura.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
    }
}
