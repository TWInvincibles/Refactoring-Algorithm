 using System;
 using Xunit;

 namespace refactoring {
     public class RenameMethodFacts{
         [Fact]
         public void should_get_staff_office_telephone_number () {
            var staff = new Staff("+86", "4008 900 505");
            var telephoneNumber = staff.GetTelephoneNumber();
            Assert.Equal("(+86) 4008 900 505", telephoneNumber);
        }
     }
 }