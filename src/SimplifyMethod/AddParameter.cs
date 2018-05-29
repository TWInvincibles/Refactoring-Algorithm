using System;
using System.Collections.Generic;
using System.Linq;

namespace refactoring {

    public class Calendar {
        public Calendar (List<Appointment> appointments) {
            this.Appointments = appointments;
        }
        public List<Appointment> Appointments { get; private set; }
        public List<Appointment> FindAppointments (long studentId, DateTime dateTime, string courseName = null) {
            var appointments = Appointments.Where (a => a.StudentId == studentId && a.Date == dateTime.Date);
            if (string.IsNullOrEmpty (courseName)) {
                return appointments.ToList ();
            }
            return appointments.Where (a => a.CourseName == courseName).ToList ();
        }
    }
    public class Appointment {
        public Appointment (long studentId, string courseName, DateTime date) {
            this.StudentId = studentId;
            this.CourseName = courseName;
            this.Date = date;
        }

        public DateTime Date { get; private set; }
        public string CourseName { get; private set; }
        public long StudentId { get; private set; }
    }
    public class Student {
        public Student (long id) {
            this.Id = id;
        }
        public long Id { get; private set; }
    }
}