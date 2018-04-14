using System.Collections.Generic;

namespace refactoring {
    public interface ISendAlerts {
        void SendAlert ();
    }
    public class SecurityChecker {
        private readonly ISendAlerts alertSender;
        private readonly ICriminalBlocker criminalBlocker;

        public SecurityChecker (ISendAlerts alertSender, ICriminalBlocker criminalBlocker) {
            this.alertSender = alertSender;
            this.criminalBlocker = criminalBlocker;
        }

        public void CheckSecurity (IEnumerable<string> people) {
            var found = FoundCriminal (people);

            if (!(found == "")) {
                criminalBlocker.BlockCriminal (found);
                SendAlert ();
            }
        }
        private string FoundCriminal (IEnumerable<string> people) {
            foreach (var person in people) {
                if (person == "Don") {
                    return "Don";
                }
                if (person == "John") {
                    return "John";
                }
            }
            return "";
        }

        private void SendAlert () {
            alertSender.SendAlert ();
        }
    }

    public interface ICriminalBlocker {
        void BlockCriminal (string criminal);
    }
}