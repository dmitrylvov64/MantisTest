using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace AddTaskTests
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly By _loginInputButton = By.XPath("//input[@id='username']");

        private readonly By _continueButton = By.XPath("//input[@type='submit']");

        private readonly By _passwordInputButton = By.XPath("//input[@id='password']");

        private readonly By _enterButton = By.XPath("//input[@type='submit']");

        private readonly By _createButton = By.XPath("//a[@class='btn btn-primary btn-sm']");

        private readonly By _chooseButton = By.XPath("//input[@type='submit']");

        private readonly By _categoriesButton = By.XPath("//select[@id='category_id']");

        private readonly By _optionButton = By.XPath("//option[@value = '27']");

        private readonly By _topicButton = By.XPath("//input[@tabindex='9']");

        private readonly By _topicInpButton = By.XPath("//input[@tabindex='9']");

        private readonly By _descriptionButton = By.XPath("//textarea[@class='form-control']");

        private readonly By _descriptionInpButton = By.XPath("//textarea[@class='form-control']");

        private readonly By _createtaskButton = By.XPath("//input[@tabindex='17']");

        private readonly By _taskNew = By.XPath("//th[@class='bug-status category']");




        private const string _login = "LvovDA..";

        private const string _password = "Welcome1!";

        private const string _topic = "Hello world!";

        private const string _descriptiontext = "My name is Dmitry Lvov";

        private const string _expectedstatus = "Состояние";


        [SetUp]
            
            public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.mantisbt.org/bugs/login_page.php");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var login = driver.FindElement(_loginInputButton);
            login.SendKeys(_login);

            var continueLogin = driver.FindElement(_continueButton);
            continueLogin.Click();

            var password = driver.FindElement(_passwordInputButton);
            password.SendKeys(_password);

            var enter = driver.FindElement(_enterButton);
            enter.Click();

            var create = driver.FindElement(_createButton);
            create.Click();

            Thread.Sleep(400);

            var choose = driver.FindElement(_chooseButton);
            choose.Click();

            var categories = driver.FindElement(_categoriesButton);
            categories.Click();

            var option = driver.FindElement(_optionButton);
            option.Click();

            var topic = driver.FindElement(_topicButton);
            topic.Click();

            var topicc = driver.FindElement(_topicInpButton);
            topicc.SendKeys(_topic);

            var description = driver.FindElement(_descriptionButton);
            description.Click();

            var descriptiontext = driver.FindElement(_descriptionInpButton);
            descriptiontext.SendKeys(_descriptiontext);

            var createtask = driver.FindElement(_createtaskButton);
            createtask.Click();

            Thread.Sleep(2000);

            var actualStatus = driver.FindElement(_taskNew).Text;

            Assert.AreEqual(_expectedstatus, actualStatus, "The task was not created");


        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}