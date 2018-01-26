using System;

namespace refactoring {
    public class SalaryCalculator {
        float GetBonusRate (int numberOfKids) => (float) Math.Truncate (25 * Math.Sqrt (numberOfKids)) / 100;

        public float Calculate (float salary, int numberOfKids) => salary + salary * GetBonusRate (numberOfKids);
    }
}