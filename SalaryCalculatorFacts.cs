    using System;
    using Xunit;

    namespace refactoring 
    {
        public class SalaryCalculatorFacts 
        {
            [Fact]
            public void should_have_no_bonus_without_child()
            {
                var salary = new SalaryCalculator().Calculate(10000, 0);
                Assert.Equal(10000, salary);
            } 

            
            [Fact]
            public void should_have_25_percentage_of_salary_as_bonus_with_1_child()
            {
                var salary = new SalaryCalculator().Calculate(10000, 1);
                Assert.Equal(12500, salary);
            }
        }
    }