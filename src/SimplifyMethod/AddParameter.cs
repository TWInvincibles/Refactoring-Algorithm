using System;
using System.Collections.Generic;
using System.Linq;

namespace refactoring {

    public class Calendar {
        public Calendar (List<Appointment> appointments) {
            this.Appointments = appointments;
        }
        public List<Appointment> Appointments { get; private set; }
        public List<Appointment> FindAppointments (long studentId, DateTime dateTime) {
            return Appointments.Where (a => a.StudentId == studentId && a.Date == dateTime.Date).ToList ();
        }
    }
    public class Appointment {
        public Appointment(long studentId, string courseName, DateTime date)
        {
            this.StudentId = studentId;
            this.CourseName = courseName;
            this.Date = date;
        }

        public DateTime Date { get; private set; }
        public string CourseName { get; private set; }
        public long StudentId { get; private set; }
    }
    public class Student {
        public Student (long id, string name) {
            this.Id = id;
            this.Name = name;
        }

        public long Id { get; private set; }
        public string Name { get; private set; }
    }
}