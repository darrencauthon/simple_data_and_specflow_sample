using System.Collections.Generic;
using Simple.Data;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Sample.Steps
{
    [Binding]
    public class AccountSteps
    {
        [BeforeScenario]
        public void Setup()
        {
            Database.Open().Accounts.DeleteAll();
        }

        [Given(@"the following accounts exist")]
        public void x(Table table)
        {
            var accounts = table.CreateSet<Account>();

            Database.Open().Accounts.Insert(accounts);
        }

        [Then(@"the following accounts should exist")]
        public void y(Table table)
        {
            IEnumerable<Account> accounts = Database.Open().Accounts.All().Cast<Account>();

            table.CompareToSet(accounts);
        }
    }
}