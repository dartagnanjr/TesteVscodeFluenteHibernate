using System;
using MyProjectNHibernate2.Entities;

namespace MyProjectNHibernate2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            PersonProject dao = new PersonProject();

            Console.WriteLine("Iniciando a inserção");

            per.Id = 1;
            per.Name = "Junior";
            per.CreationDate = DateTime.Today;
            per.UpdatedDate = DateTime.Now;

            dao.Inserir(per);

            Console.WriteLine("Ok, operação realizada.");

        }
    }
}
