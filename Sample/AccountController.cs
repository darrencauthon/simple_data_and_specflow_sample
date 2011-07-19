using Sample.Steps;

namespace Sample
{
    public class AccountController
    {
        private readonly dynamic database;

        public AccountController(dynamic database)
        {
            this.database = database;
        }

        public void Create(CreateAccountForm createAccountForm)
        {
            database.Accounts.Insert(createAccountForm);
        }
    }
}