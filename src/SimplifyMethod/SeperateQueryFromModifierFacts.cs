 using System;
 using Xunit;

 namespace refactoring {
     public class SeperateQueryFromModifierFacts : ISendAlerts, ICriminalBlocker {
         private SecurityChecker securityChecker;
         private bool alertSent;
         private string blockedCrimincal;

         public SeperateQueryFromModifierFacts () {
             alertSent = false;
             blockedCrimincal = null;
             securityChecker = new SecurityChecker (this, this);
         }

         public void BlockCriminal (string criminal) {
             blockedCrimincal = criminal;
         }

         public void SendAlert () {
             alertSent = true;
         }

         [Fact]
         public void Finds_crimincal_and_send_alert_when_Don_is_there () {
             securityChecker.CheckSecurity (new [] { "Dan", "Don", "Den" });

             Assert.Equal ("Don", blockedCrimincal);
             Assert.True (alertSent);
         }

         [Fact]
         public void Finds_criminal_and_send_alert_when_John_is_there () {
             securityChecker.CheckSecurity (new [] { "Jan", "John", "Jen" });

             Assert.Equal ("John", blockedCrimincal);
             Assert.True (alertSent);
         }

         [Fact]
         public void Finds_1st_criminal_and_send_alert_when_Don_and_John_are_there () {
             securityChecker.CheckSecurity (new [] { "Don", "John" });

             Assert.Equal ("Don", blockedCrimincal);
             Assert.True (alertSent);
         }

         [Fact]
         public void Finds_no_criminal_amongst_innocent_people () {
             securityChecker.CheckSecurity (new [] { "Dan", "Den", "Jan", "Jen" });
             Assert.Equal (null, blockedCrimincal);
             Assert.False (alertSent);
         }
     }
 }