using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1012
{
    class Task
    {
        private int taskNumber; 
        internal int TaskNumber { get { return taskNumber; } }

        private static int number;
        internal int Number()
        {
            number++;
            taskNumber = number;
            return taskNumber;
        }
    }
}
