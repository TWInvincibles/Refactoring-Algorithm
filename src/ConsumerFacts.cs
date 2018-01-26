 using System;
 using Xunit;

 namespace refactoring {
     public class ConsumerFacts {
         [Fact]
         public void should_get_consumer_account () {
             var accountManager = new AccountManager (new AccountDataProvider ());

            var account = new Consumer(accountManager).Get (1);

             Assert.Equal("Martin", account.UserName);
         }
     }
 }