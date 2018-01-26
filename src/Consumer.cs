namespace refactoring {

    public class Consumer {
        public AccountManager AccountManager { get; set; }

        public Consumer (AccountManager accountManager) {
            AccountManager = accountManager;
        }

        public void Get (int id) {
            Account account = AccountManager.GetAccount (id);
        }
    }

    public class Account {
        public Account () { }
    }
}