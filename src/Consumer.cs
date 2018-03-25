using System;

namespace refactoring {

    public class Consumer {
    public AccountManager accountManager { get; set; }

        public Consumer (AccountManager accountManager) {
            this.accountManager = accountManager;
        }

        public Account Get (int id) {
            return accountManager.GetAccount (id);
        }
    }

    public class Account {
        public Account(string userName) => UserName = userName;

        public string UserName { get; }
    }
}