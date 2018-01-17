using System;

namespace refactoring 
{
    public class SalaryCalculator 
    {
        float GetBonusRate(int numberOfKids)
        {
            var bonusRates = new float [] {0f, 0.25f, 0.35f, 0.43f, 0.5f, 0.55f};
            return bonusRates[numberOfKids];
        }

        public float Calculate(float salary, int numberOfKids) 
        {           
            return salary + salary * GetBonusRate(numberOfKids) ;
        }
    }
}