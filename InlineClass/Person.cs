namespace refactoring{
    public class Person {
        public Person(string name, string officeAreaCode, string officeNumber) {
            this.name = name;
            this.officeTelephone = new TelephoneNumber(officeAreaCode, officeNumber);
        }
        public string GetTelephoneNumber() {
            return officeTelephone.GetTelephoneNumber();
        }

        public string GetAddress() {
            return "fake address";
        }

        string name { get; set;}        
        TelephoneNumber officeTelephone;
    }

    public class TelephoneNumber {
        public TelephoneNumber(string officeAreaCode, string officeNumber) {
            this.officeAreaCode = officeAreaCode;
            this.officeNumber = officeNumber;
        }
        public string GetTelephoneNumber() {
             return "(" + officeAreaCode + ") " + officeNumber;
        }

        string officeAreaCode {get; set;}
        string officeNumber {get; set;}
        
    }
}