namespace refactoring {
    public class Staff {
        public Staff(string officeAreaCode, string officeNumber)
        {
            this.OfficeAreaCode = officeAreaCode;
            this.OfficeNumber = officeNumber;
        }

        public string OfficeAreaCode { get; private set; }
        public string OfficeNumber { get; private set; }

        public string GetTelephoneNumber () {
            return "(" + OfficeAreaCode + ") " + OfficeNumber;
        }
    }
}