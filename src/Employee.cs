using System;

namespace refactoring {
    public class Engineer : Employee {
        public Engineer () { }
        public override int EmployeeType => Employee.ENGINEER;
    }
    public class Salesman : Employee {
        public Salesman () { }
        public override int EmployeeType => Employee.SALESMAN;
    }
    public class Manager : Employee {
        public Manager () { }
        public override int EmployeeType => Employee.MANAGER;
    }

    public class Employee {
        protected Employee () {
            this.EmployeeType = EmployeeType;
        }

        private Employee (int employeeType) {
            EmployeeType = employeeType;
        }

        public static Employee Create (int employeeType) {
            switch (employeeType) {
                case Employee.ENGINEER:
                    return new Engineer ();
                case Employee.SALESMAN:
                    return new Salesman ();
                case Employee.MANAGER:
                    return new Manager ();
                default:
                    return new Employee (employeeType);
            }
        }

        public virtual int EmployeeType { get; private set; }
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public int MonthlySalary { get; set; }
        public int Commission { get; set; }
        public int Bonus { get; set; }

        public int GetPayroll () {
            switch (EmployeeType) {
                case ENGINEER:
                    return MonthlySalary;
                case SALESMAN:
                    return MonthlySalary + Commission;
                case MANAGER:
                    return MonthlySalary + Commission + Bonus;
                default:
                    throw new Exception ("Incorrect Employee Code");
            }
        }
    }
}