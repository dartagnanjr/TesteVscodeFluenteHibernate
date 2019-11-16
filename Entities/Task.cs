using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProjectNHibernate2.Entities
{
    public class Task
    {
        public virtual string Id { get; set; }
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public virtual string State { get; set; }

        public virtual string AssignedTo { get; set; }

        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime UpdatedDate { get; set; }

        public Task()
        {
            //CreationTime = System.DateTime.UtcNow;
            //State = TaskState.Open;
        }

}

        public enum TaskState : byte
        {
            /// <summary>
            /// The task is Open.
            /// </summary>
            Open = 0,
            /// <summary>
            /// The task is active.
            /// </summary>
            Active = 1,

            /// <summary>
            /// The task is completed.
            /// </summary>
            Completed = 2,

            /// <summary>
            /// The task is closed.
            /// </summary>
            Closed = 3
        }
}