namespace refactoring {
    public class AccountManager {
        public AccountDataProvider dataProvider { get; set; }

        public AccountManager (AccountDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }

        public Account GetAccount (int id) {
            return dataProvider.GetAccount (id);
        }
    }

}