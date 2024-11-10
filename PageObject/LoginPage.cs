using OpenQA.Selenium;


namespace TallerAutomatización.PageObject
{
    public class LoginPage
    {
        public IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        private readonly By _txtUserName = By.Id("username");
        private readonly By _txtPassWord = By.Id("password");
        private readonly By _btnLogin = By.CssSelector("#login > button");

        public IWebElement username => _driver.FindElement(_txtUserName);
        public IWebElement password => _driver.FindElement(_txtPassWord);
        public IWebElement btnLogin => _driver.FindElement(_btnLogin);

        public void IngresarCredenciales() {
            username.SendKeys("tomsmith");
            password.SendKeys("SuperSecretPassword!");
            btnLogin.Click();
        }

    }
}
