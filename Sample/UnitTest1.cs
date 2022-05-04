using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Sample
{
    public class Tests : DriverHelper

    { 

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

        }

        [Test]
        public void Test1()
        {

            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();



            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            

            Assert.Pass();
        }
    }
}