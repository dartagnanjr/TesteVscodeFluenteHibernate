using FluentNHibernate.Mapping;
using MyProjectNHibernate2.Entities;

namespace MyProjectNHibernate2.Mapping
{
    public class TaskMap : ClassMap<Task>
    {

        public TaskMap(){

            Id(x => x.Id);
            Map(x => x.Title);
            Map(x => x.Description);
            Map(x => x.CreationTime);
            Map(x => x.State);
            Map(x => x.AssignedTo);
            Map(x => x.CreationDate);
            Map(x => x.UpdatedDate);
            Table("Task");
        }
        
    }
}