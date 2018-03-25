using System;

namespace refactoring {
    public class Employee {
        public Employee (int employeeType) {
            this.employeeType = employeeType;
        }

        private int employeeType;
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public int MonthlySalary { get; set; }
        public int Commission { get; set; }
        public int Bonus { get; set; }

        public int GetPayroll () {
            switch (employeeType) {
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