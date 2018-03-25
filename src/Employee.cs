using System;

namespace refactoring {
    public class Employee {
        public Employee (int type) {
            _type = type;
        }

        private int _type;
        const int ENGINEER = 0;
        const int SALESMAN = 1;
        const int MANAGER = 2;

        public int MonthlySalary { get; set; }
        public int Commission { get; set; }
        public int Bonus { get; set; }

        public int GetPayroll () {
            switch (_type) {
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