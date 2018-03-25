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
        public override int GetPayroll () {
            return MonthlySalary + Commission;
        }
    }
    public class Manager : Employee {
        public int Bonus { get; set; }
        public Manager () { }
        public override int GetPayroll () {
            return MonthlySalary + Commission + Bonus;
        }
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