using System.Collections.Generic;
using NHibernate;
using System.Linq;

namespace MyProjectNHibernate2
{
    public class MyProjectCrudDAO<T> : ICrudDAO<T> where T : class
    {
        public void Alterar(T entidade)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transaction.Commit();
                    }
                    catch(System.Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {    
                            transaction.Rollback();
                        }
                        throw new System.Exception("Erro ao Alterar entidade: " + ex.Message);
                    }
                    
                }
            }
        }

        public IList<T> Consultar()
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                return (from e in session.Query<T>() select e).ToList();
            }
            
        }

        public void Excluir(T entidade)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                        transaction.Commit();
                    }
                    catch(System.Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {   
                            transaction.Rollback();
                        }
                        throw new System.Exception("Erro ao Excluir entidade: " + ex.Message);
                    }
                }
            }
        }

        public void Inserir(T entidade)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transaction.Commit();
                    }
                    catch(System.Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {       
                            transaction.Rollback();
                        }
                        throw new System.Exception("Erro ao inserir entidade: " + ex.Message);
                    }
                }
            }
        }
        public T RetornaId(int id)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                return session.Get<T>(id);
            }
        }
    }
}