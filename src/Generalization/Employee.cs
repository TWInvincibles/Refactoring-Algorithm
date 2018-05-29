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
        public Salesman (string employeeId, int monthlySalary, int commission) : base (employeeId, monthlySalary, commission) { }
        public override int GetPayroll () {
            return MonthlySalary + Commission + GetPushMoney(); 
        }
    }
    public class Manager : Employee {
        public Manager (string employeeId, int monthlySalary, int commission, int bonus) : base (employeeId, monthlySalary, commission) {
            this.Bonus = bonus;
        }
        public int Bonus { get; set; }
        public Manager () { }
        public override int GetPayroll () {
            return MonthlySalary + Commission + Bonus;
        }
    }

    public class Employee {
        public Employee () { }
        public Employee (string employeeId, int monthlySalary, int commission) {
            this.EmployeeId = employeeId;
            this.MonthlySalary = monthlySalary;
            this.Commission = commission;
        }
        public string EmployeeId { get; set; }
        public int MonthlySalary { get; set; }
        public int Commission { get; set; }
        public int SalesAmount { get; set; }
        public float PushMoneyRate { get; set; }
        public int GetPushMoney () {
            return (int) (SalesAmount * PushMoneyRate);
        }
        public virtual int GetPayroll () {
            throw new Exception ("Incorrect Employee Code");
        }
        public string GetEmployeeId () => $"Role: {this.GetType().Name} - EmployeeId: {EmployeeId}";
    }
}