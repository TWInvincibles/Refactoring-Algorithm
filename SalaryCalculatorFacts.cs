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

             [Fact]
            public void should_have_35_percentage_of_salary_as_bonus_with_2_childs()
            {
                var salary = new SalaryCalculator().Calculate(10000, 2);
                Assert.Equal(13500, salary);
            }

            [Fact]
            public void should_have_43_percentage_of_salary_as_bonus_with_3_childs()
            {
                var salary = new SalaryCalculator().Calculate(10000, 3);
                Assert.Equal(14300, salary);
            }

            [Fact]
            public void should_have_50_percentage_of_salary_as_bonus_with_4_childs()
            {
                var salary = new SalaryCalculator().Calculate(10000, 4);
                Assert.Equal(15000, salary);
            }
        }
    }