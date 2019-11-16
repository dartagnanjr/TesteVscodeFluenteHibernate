using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MyProjectNHibernate2.Entities;

namespace MyProjectNHibernate2.Mapping
{


        public class PersonMap : ClassMap<Person>
    {

     public PersonMap(){

        Id(x => x.Id);
        Map(x => x.Name);
        Map(x => x.CreationDate);
        Map(x => x.UpdatedDate);
        Table("Person");
     }   
    }    
    
}