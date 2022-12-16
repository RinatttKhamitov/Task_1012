using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task_1012
{
    class TaskManager
    {
        public Hashtable tasks = new Hashtable();

        public Task this[int taskNumber]
        {
            get
            {
                return (Task)tasks[taskNumber];
            }
        }
        internal Task CreateTask()
        {
            Task task = new Task();
            tasks[task.Number()] = task;
            return task;
        }



    }
}
