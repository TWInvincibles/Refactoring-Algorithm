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
        public Manager () { }
        public override int GetPayroll () {
            return MonthlySalary + Commission + Bonus;
        }
    }

    public class Employee {
        protected Employee () { }

        private Employee (int employeeType) { }

        public static Employee Create (int employeeType) {
            switch (employeeType) {
                case Employee.ENGINEER:
                    return new Engineer ();
                case Employee.SALESMAN:
                    return new Salesman ();
                case Employee.MANAGER:
                    return new Manager ();
                default:
                    return new Employee ();
            }
        }

        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public int MonthlySalary { get; set; }
        public int Commission { get; set; }
        public int Bonus { get; set; }

        public virtual int GetPayroll () {
            throw new Exception ("Incorrect Employee Code");
        }
    }
}