using System;

namespace refactoring 
{
    public class SalaryCalculator 
    {
        public float Calculate(float salary, int numberOfKids) 
        {
            var bonusRate = 0f;

            if(numberOfKids == 1) 
            {
                bonusRate = 0.25f;
            }

            if(numberOfKids == 2) 
            {
                bonusRate = 0.35f;
            }

            if(numberOfKids == 3) 
            {
                bonusRate = 0.43f;
            }

            if(numberOfKids == 4) 
            {
                bonusRate = 0.5f;
            }

            if(numberOfKids == 5) 
            {
                bonusRate =  0.55f;
            }
        
            return salary + salary * bonusRate ;
        }
    }
}