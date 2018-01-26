namespace refactoring {
    public class AccountManager {
        public AccountDataProvider DataProvider { get; set; }

        public AccountManager (AccountDataProvider dataProvider) {
            DataProvider = dataProvider;
        }

        public Account GetAccount (int id) {
            return DataProvider.GetAccount (id);
        }
    }

}