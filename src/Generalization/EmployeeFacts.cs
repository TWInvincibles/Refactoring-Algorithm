 using System;
 using Xunit;

 namespace refactoring {
     public class EmployeeFacts {
         [Fact]
         public void should_get_payroll_with_monthly_salary_for_engineer () {
             var engineer = new Engineer ();
             engineer.MonthlySalary = 10000;

             var actualPayroll = engineer.GetPayroll ();

             Assert.Equal (10000, actualPayroll);
         }

         [Fact]
         public void should_get_payroll_with_monthly_salary_and_commission_for_sales_man () {
             var salesman = new Salesman ();
             salesman.MonthlySalary = 10000;
             salesman.Commission = 1000;

             var actualPayroll = salesman.GetPayroll ();

             Assert.Equal (11000, actualPayroll);
         }

         [Fact]
         public void should_get_payroll_with_monthly_salary_and_commission_and_bonus_for_manager () {
             var manager = new Manager ();
             manager.MonthlySalary = 10000;
             manager.Commission = 1000;
             manager.Bonus = 5000;

             var actualPayroll = manager.GetPayroll ();

             Assert.Equal (16000, actualPayroll);
         }

         [Fact]
         public void should_get_employee_id_for_sales_man () {
             var salesman = new Salesman ();
             salesman.EmployeeId = "AB100";

             var employeeId = salesman.GetEmployeeId ();

             Assert.Equal ("Role: Salesman - EmployeeId: AB100", employeeId);
         }

         [Fact]
         public void should_get_employee_id_for_manager () {
             var manager = new Manager ();
             manager.EmployeeId = "AB101";

             var employeeId = manager.GetEmployeeId ();

             Assert.Equal ("Role: Manager - EmployeeId: AB101", employeeId);
         }

         [Fact]
         public void can_create_salesman_with_information () {
             var salesman = new Salesman ("AB100", 10000, 5000);

             Assert.Equal ("Role: Salesman - EmployeeId: AB100", salesman.GetEmployeeId ());
             Assert.Equal (15000, salesman.GetPayroll ());
         }

         [Fact]
         public void can_create_manager_with_information () {
             var manager = new Manager ("AB101", 15000, 5000, 5000);

             Assert.Equal ("Role: Manager - EmployeeId: AB101", manager.GetEmployeeId ());
             Assert.Equal (25000, manager.GetPayroll ());
         }

         [Fact]
         public void should_throw_exception_with_employees_not_able_to_handle () {
             var employee = new Employee ();
             Assert.Throws<Exception> (() => employee.GetPayroll ());
         }
     }
 }