using Simple.Data;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Sample.Steps
{
    [Binding]
    public class AccountControllerSteps
    {
        [When(@"I submit the following Create Account form")]
        public void x(Table table)
        {
            var form = table.CreateInstance<CreateAccountForm>();

            var controller = new AccountController(Database.Open());

            controller.Create(form);
        }
    }
}