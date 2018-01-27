 using System;
 using Xunit;

 namespace refactoring {
     public class ConsumerFacts {
         [Fact]
         public void should_get_consumer_account () {

            var account = new Consumer(new AccountDataProvider()).Get (1);

             Assert.Equal("Martin", account.UserName);
         }
     }
 }