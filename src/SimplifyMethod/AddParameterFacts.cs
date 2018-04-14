 using System.Collections.Generic;
 using System;
 using Xunit;

 namespace refactoring {
     public class AddParameterFacts {
         [Fact]
         public void should_get_appointments_of_correct_student () {
             var calendar = new Calendar (new List<Appointment> () {
                 new Appointment (1, "English", DateTime.Today),
                     new Appointment (1, "Machine Learning", DateTime.Today),
                     new Appointment (2, "English", DateTime.Today),
             });

             var student = new Student (1, "Kitty");
             var appointments = calendar.FindAppointments (student.Id, DateTime.Today);

             Assert.Equal (2, appointments.Count);

             Assert.Equal (1, appointments[0].StudentId);
             Assert.Equal (1, appointments[1].StudentId);
             Assert.Equal ("English", appointments[0].CourseName);
             Assert.Equal ("Machine Learning", appointments[1].CourseName);

         }

         [Fact]
         public void should_get_appointment_for_correct_date () {
             var calendar = new Calendar (new List<Appointment> () {
                 new Appointment (1, "English", DateTime.Today.AddDays (-1)),
                     new Appointment (1, "Machine Learning", DateTime.Today),
                     new Appointment (1, "Design Thinking", DateTime.Today),
                     new Appointment (1, "DevOps", DateTime.Today.AddDays (1)),
             });

             var student = new Student (1, "Kitty");
             var appointments = calendar.FindAppointments (student.Id, DateTime.Today);

             Assert.Equal (2, appointments.Count);
             Assert.Equal ("Machine Learning", appointments[0].CourseName);
             Assert.Equal ("Design Thinking", appointments[1].CourseName);
         }
     }
 }