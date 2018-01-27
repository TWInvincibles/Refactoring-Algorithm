using System;

namespace refactoring {

    public class Consumer {
        private readonly AccountDataProvider accountDataProvider;

        public Consumer (AccountDataProvider accountDataProvider) {
            this.accountDataProvider = accountDataProvider;
        }

        public Account Get (int id) {
            return accountDataProvider.GetAccount (id);
        }
    }

    public class Account {
        public Account (string userName) => UserName = userName;

        public string UserName { get; }
    }
}