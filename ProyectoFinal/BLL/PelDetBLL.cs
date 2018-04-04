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
    public class PelDetBLL
    {
        public static bool Guardar(GenAct GA)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.GA.Add(GA);

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

        public static bool Modificar(GenAct GA)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Entry(GA).State = EntityState.Modified;

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
                GenAct GA = db.GA.Find(id);

                db.GA.Remove(GA);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static GenAct Buscar(int id)
        {
            GenAct GA = null;
            try
            {
                Contexto db = new Contexto();
                GA = db.GA.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return GA;
        }

        public static List<GenAct> GetListTodo()
        {
            List<GenAct> lista = null;
            try
            {
                Contexto dbase = new Contexto();
                lista = dbase.GA.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}
