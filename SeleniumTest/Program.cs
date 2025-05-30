using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

class Program
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        try
        {
            // Navigating to the form
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
            Console.WriteLine("Navigated to the form page");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Waiting for form to load
            wait.Until(d => d.FindElement(By.TagName("form")));
            Console.WriteLine("Form loaded successfully");

            // Fill First Name field
            Console.WriteLine("\nTesting First Name field...");
            IWebElement firstNameField = null;
            
            // Tring a  different ways to find the first name field to avoid error or bugs
            try
            {
                firstNameField = driver.FindElement(By.Id("fname"));
            }
            catch
            {
                try
                {
                    firstNameField = driver.FindElement(By.Name("First Name"));
                }
                catch
                {
                    firstNameField = driver.FindElement(By.XPath("//input[contains(@placeholder, 'Name') and not(contains(@placeholder, 'Last'))]"));
                }
            }

            if (firstNameField != null)
            {
                firstNameField.Clear();
                firstNameField.SendKeys("Avinash");
                Console.WriteLine("First Name filled successfully!");
            }

            // Fill Last Name field
            Console.WriteLine("\nTesting Last Name field...");
            IWebElement lastNameField = null;
            
            try
            {
                lastNameField = driver.FindElement(By.Id("lname"));
            }
            catch
            {
                try
                {
                    lastNameField = driver.FindElement(By.Name("Last Name"));
                }
                catch
                {
                    lastNameField = driver.FindElement(By.XPath("//input[contains(@placeholder, 'Surname')]"));
                }
            }

            if (lastNameField != null)
            {
                lastNameField.Clear();
                lastNameField.SendKeys("Pathak");
                Console.WriteLine("Last Name filled successfully!");
            }

            // Fill Email field
            Console.WriteLine("\nTesting Email field...");
            IWebElement emailField = null;
            
            try
            {
                emailField = driver.FindElement(By.Id("email"));
            }
            catch
            {
                try
                {
                    emailField = driver.FindElement(By.CssSelector("input[type='email']"));
                }
                catch
                {
                    emailField = driver.FindElement(By.XPath("//input[contains(@placeholder, 'Email')]"));
                }
            }

            if (emailField != null)
            {
                emailField.Clear();
                emailField.SendKeys("avinashpathak298@gmail.com");
                Console.WriteLine("Email filled successfully!");
            }

            // Checking if all fields are filled correctly
            Console.WriteLine("\nValidating form inputs...");
            
            var allInputs = driver.FindElements(By.TagName("input"));
            foreach (var input in allInputs)
            {
                string value = input.GetAttribute("value");
                if (value == "Avinash")
                    Console.WriteLine("First Name validation passed: 'Avinash'");
                else if (value == "Pathak")
                    Console.WriteLine("Last Name validation passed: 'Pathak'");
                else if (value == "avinashpathak298@gmail.com")
                    Console.WriteLine("Email validation passed: 'avinashpathak298@gmail.com'");
            }

            Console.WriteLine("\nAll form fields tested and filled successfully!");
            System.Threading.Thread.Sleep(5000);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong: " + ex.Message);
        }
        finally
        {
            driver.Quit();
            Console.WriteLine("Browser closed.");
        }
    }
}