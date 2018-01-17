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
        }
    }