using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Linq;

namespace MyProjectNHibernate2
{
    public interface ICrudDAO<T>
    {
         void Inserir(T entidade);
         void Alterar(T entidade);
         void Excluir(T entidade);
         T RetornaId(int id);
         IList<T> Consultar();
    }
}