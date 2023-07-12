using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Security.Cryptography;


namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();


driver.Navigate().GoToUrl("https://www.linkedin.com/login");

IWebElement inputField = driver.FindElement(By.Id("username"));
inputField.SendKeys("juliettorresb@gmail.com");


IWebElement passwordField = driver.FindElement(By.Name("session_password"));
passwordField.SendKeys("Vallenato*08");

IWebElement signInButton = driver.FindElement(By.CssSelector(".btn__primary--large"));
signInButton.Click();

IWebElement searchInput = driver.FindElement(By.XPath("//*[@id=\"global-nav-typeahead\"]/input"));
searchInput.SendKeys("QA Analyst");

searchInput.SendKeys(Keys.Enter);
Thread.Sleep(5000);
driver.Quit();

            
                
                    

                    }
                }
            }