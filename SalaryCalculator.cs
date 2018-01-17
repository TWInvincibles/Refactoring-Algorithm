using System;

namespace refactoring 
{
    public class SalaryCalculator 
    {
        public float Calculate(float salary, int numberOfKids) 
        {
            var bonus = 0f;

            if(numberOfKids == 1) 
            {
                bonus = salary * 0.25f;
            }

            if(numberOfKids == 2) 
            {
                bonus = salary * 0.35f;
            }
        
            return salary + bonus;
        }
    }
}