using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TallerAutomatización.Genericos;
using TallerAutomatización.PageObject;

namespace TallerAutomatización.Test
{
    [TestFixture]
    public class Tests
    {
        public IWebDriver driver;
        public LoginPage login;
        public LeerJson json;
        public string baseURL = "https://the-internet.herokuapp.com/login";
        [SetUp]
        public void iniciarNavegador() { 
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // Maxima la ventana de windows
            driver.Navigate().GoToUrl(baseURL);
            login = new LoginPage(driver);
            json = new LeerJson();
        }
        [TearDown]
        public void CerrarNavegador() { 
            driver.Close();
            driver.Quit();
        }
        //[Ignore("No se prueba!")]
        //[Category("Smoke")]
        //[Order(1)]
        //[TestCase("tomsmith", "SuperSecretPassword!")]
        public void IngresoCorrecto()
        {
            var data = json.login_data();
            string user = data.username;
            string pass = data.password;
            login.IngresarCredenciales(user, pass);
        }
    }
}