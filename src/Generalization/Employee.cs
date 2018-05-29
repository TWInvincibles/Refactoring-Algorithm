using System;

namespace refactoring {
    public class Engineer : Employee {
        public Engineer () { }
        public override int GetPayroll () {
            return MonthlySalary;
        }
    }
    public class Salesman : Employee {
        public Salesman () { }
        public string EmployeeId { get; set; }
        public override int GetPayroll () {
            return MonthlySalary + Commission;
        }
        public string GetEmployeeId () => $"Role: Salesman - EmployeeId: {EmployeeId}";
    }
    public class Manager : Employee {
        public int Bonus { get; set; }
        public string EmployeeId { get; set; }
        public Manager () { }
        public override int GetPayroll () {
            return MonthlySalary + Commission + Bonus;
        }
        public string GetEmployeeId () => $"Role: Manager- EmployeeId: {EmployeeId}";
    }

    public class Employee {
        public Employee () { }

        public int MonthlySalary { get; set; }
        public int Commission { get; set; }

        public virtual int GetPayroll () {
            throw new Exception ("Incorrect Employee Code");
        }
    }
}