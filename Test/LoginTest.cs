using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TallerAutomatización.PageObject;

namespace TallerAutomatización.Test
{
    public class Tests
    {
        public IWebDriver driver;
        public LoginPage login;
        [SetUp]
        public void iniciarNavegador() { 
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // Maxima la ventana de windows
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
            login = new LoginPage(driver);
        }
        [TearDown]
        public void CerrarNavegador() { 
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void IngresoCorrecto()
        {
            login.IngresarCredenciales();
        }
        [Test]
        public void IngresoIncorrecto() {
            
            login.IngresarCredenciales();
        }
    }
}