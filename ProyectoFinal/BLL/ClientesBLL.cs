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
    public  class ClientesBLL
    {
        public static bool Guardar(Client Cli)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Cliente.Add(Cli);

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

        public static bool Modificar(Client Cli)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Entry(Cli).State = EntityState.Modified;

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
                Client Cli = db.Cliente.Find(id);

                db.Cliente.Remove(Cli);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static Client Buscar(int id)
        {
            Client Cli = null;
            try
            {
                Contexto db = new Contexto();
                Cli = db.Cliente.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return Cli;
        }

        public static List<Client> GetListTodo()
        {
            List<Client> lista = null;
            try
            {
                Contexto dbase = new Contexto();
                lista = dbase.Cliente.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

        public static List<Client> GetList(Expression<Func<Client, bool>> filter)
        {
            List<Client> list = null;

            try
            {
                Contexto db = new Contexto();
                list = db.Cliente.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
    }
}
