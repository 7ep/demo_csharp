using TechTalk.SpecFlow;

namespace WebApplication1.Tests
{
    [Binding]
    public class LibrariansMayAddAndDeleteBooksSteps
    {
        private string mybook;

        [Given(@"a book, ""(.*)"", is not currently registered in the system")]
        public void GivenABookIsNotCurrentlyRegisteredInTheSystem(string book)
        {
            mybook = book;
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a book, ""(.*)"", is currently registered in the system")]
        public void GivenABookIsCurrentlyRegisteredInTheSystem(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a book, ""(.*)"", is currently loaned out")]
        public void GivenABookIsCurrentlyLoanedOut(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a book, ""(.*)"", is loaned out")]
        public void GivenABookIsLoanedOut(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a librarian registers that book")]
        public void WhenALibrarianRegistersThatBook()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a librarian deletes that book")]
        public void WhenALibrarianDeletesThatBook()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the system has the book registered")]
        public void ThenTheSystemHasTheBookRegistered()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the system does not have the book registered")]
        public void ThenTheSystemDoesNotHaveTheBookRegistered()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the system reports an error indicating that the book is already registered")]
        public void ThenTheSystemReportsAnErrorIndicatingThatTheBookIsAlreadyRegistered()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the system reports an error indicating that the book cannot be deleted because it was never registered")]
        public void ThenTheSystemReportsAnErrorIndicatingThatTheBookCannotBeDeletedBecauseItWasNeverRegistered()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the loan is deleted as well")]
        public void ThenTheLoanIsDeletedAsWell()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
