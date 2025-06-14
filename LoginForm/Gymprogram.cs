using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    internal class Gymprogram
    {
        int programID,  Capacity;
        string duration, ProgramName, Description, schedule, instructor;

        public Gymprogram(int programID, string programName, string description, string Instructor,   string schedule, int capacity, string duration)
        {
            this.programID = programID;
            this.duration = duration;
            this.ProgramName = programName;
            this.Description = description;
            this.schedule = schedule;
            this.Capacity = capacity;
            this.instructor = Instructor;
        }

        public int ProgramID { get => programID; set => programID = value; }
        public string Duration { get => duration; set => duration = value; }
        public string ProgramName1 { get => ProgramName; set => ProgramName = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string Schedule { get => schedule; set => schedule = value; }
        public int Capacity1 { get => Capacity; set => Capacity = value; }
        public string Instructor { get => instructor; set => instructor = value; }
    }
}
