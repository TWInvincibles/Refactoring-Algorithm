using System;

namespace refactoring {

    public class Consumer {
        public AccountManager AccountManager { get; set; }

        public Consumer (AccountManager accountManager) {
            AccountManager = accountManager;
        }

        public Account Get (int id) {
            return AccountManager.GetAccount (id);
        }
    }

    public class Account {
        public Account(string userName) => UserName = userName;

        public string UserName { get; }
    }
}