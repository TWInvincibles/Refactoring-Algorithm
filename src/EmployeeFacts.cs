 using System;
 using Xunit;

 namespace refactoring {
     public class EmployeeFacts {
         [Fact]
         public void should_get_payroll_with_monthly_salary_for_engineer () {
             var employee = Employee.Create (0);
             employee.MonthlySalary = 10000;

             var actualPayroll = employee.GetPayroll ();

             Assert.Equal (10000, actualPayroll);
         }

         [Fact]
         public void should_get_payroll_with_monthly_salary_and_commission_for_sales_man () {
             var employee = Employee.Create (1);
             employee.MonthlySalary = 10000;
             employee.Commission = 1000;

             var actualPayroll = employee.GetPayroll ();

             Assert.Equal (11000, actualPayroll);
         }

         [Fact]
         public void should_get_payroll_with_monthly_salary_and_commission_and_bonus_for_manager () {
             var employee = Employee.Create (2);
             employee.MonthlySalary = 10000;
             employee.Commission = 1000;
             employee.Bonus = 5000;

             var actualPayroll = employee.GetPayroll ();

             Assert.Equal (16000, actualPayroll);
         }

         [Fact]
         public void should_throw_exception_with_employees_not_able_to_handle () {
             var employee = Employee.Create (3);

             Assert.Throws<Exception> (() => employee.GetPayroll ());
         }
     }
 }