using DataDrivenByExample.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DataDrivenByExample.StepDefinitions
{
    [Binding]
    public class DataDrivenByExampleStepDefinitions
    {
        Class1 class1;
        public DataDrivenByExampleStepDefinitions()
        {
        class1 = new Class1();
        }
        [Given(@"I navigate to the wesbite ""([^""]*)""")]
        public void GivenINavigateToTheWesbite(string url)
        {
            class1.NavigateToWebsite(url);
        }

        [Given(@"I Click on SignUp")]
        public void GivenIClickOnSignUp()
        {
            class1.ClickOnSignUP();
        }

        [Given(@"I Enter my Username text ""([^""]*)""")]
        public void GivenIEnterMyUsernameText(string username)
        {
            class1.EnterUsername(username);
        }

        [Given(@"I Enter my email text ""([^""]*)""")]
        public void GivenIEnterMyEmailText(string email)
        {
            class1.EnterEmail(email);
        }

        [Given(@"I Enter passowrd  text ""([^""]*)""")]
        public void GivenIEnterPassowrdText(string password)
        {
            class1.EnterPassword(password);
        }
        [When(@"I Click on the Sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            class1.ClickOnLogin();
        }

        [Then(@"I Should be able to register succesfully")]
        public void ThenIShouldBeAbleToRegisterSuccesfully()
        {
            Assert.That(class1.IsNewArticleDisplayed(), Is.True);
        }
    }
}
