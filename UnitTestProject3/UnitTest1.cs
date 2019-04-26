using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(); //otworzenia obiektu inicjalizujacego przegladarke
            driver.Manage().Window.Maximize(); // maksymalizacja okna
            driver.Navigate().GoToUrl("http://google.pl");  //przejdz do adresu
            IWebElement searchbox = driver.FindElement(By.Name("q"));  //znalezienie okna wyszukiwarki
            searchbox.SendKeys("heya"); // wpisanie w wyszukiwarce tekstu
            IWebElement submit = driver.FindElement(By.Name("btnK")); // znalezieniu przycisku wyslij
            submit.Click(); //klikniecie przycisku
        }
       

        [TestMethod]
        public void TestMethod3()
        {
            IWebDriver driver = new ChromeDriver();  //inicjalizacja przegladarki
            driver.Manage().Window.Maximize();  //maksymalizacja okna
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/guru99home/");  //przejscie do adresu
            IWebElement testing = driver.FindElement(By.XPath("//*[@id='rt-header']/div/div[2]/div/ul/li[2]/a"));  //znalezienie elementu po xpath (znajdz obiekt w konsoli przegladarki, prawy i copy XPath
            testing.Click(); // klikniecie przycisku
        }

        [TestMethod]
        public void TestMethod4()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/guru99home/");
            IWebElement email = driver.FindElement(By.XPath("//*[@id='philadelphia-field-email']"));
            email.SendKeys("peter@gmail.com");
            IWebElement submit = driver.FindElement(By.XPath("//*[@id='philadelphia-field-submit']"));
            IWebElement rozwin = driver.FindElement(By.XPath("//*[@id='awf_field-91977689']"));
            var selectTest = new SelectElement(rozwin); // funkcja do wyboru z listy rozwijalnej
            selectTest.SelectByValue("sap-abap"); // wybranie konkretnej opcji z listy rozwijanej
            submit.Click(); // klikniecie przycisku

            //zapisac w katalogu C:\Users\User_1\source\repos\UnitTestProject3
        }

        [TestMethod]
        public void TestMethod5()
        {
            IWebDriver driver = new ChromeDriver(); //otworzenia obiektu inicjalizujacego przegladarke
            driver.Manage().Window.Maximize(); // maksymalizacja okna
            driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");  //przejdz do adresu
            IWebElement mac = driver.FindElement(By.XPath("/html/body/div[6]/div[3]/div/div/div/div/div[4]/div[2]/div[2]/div/div[2]/h2/a"));  //znalezienie okna wyszukiwarki
            mac.Click();
            IWebElement kosz = driver.FindElement(By.Id("add-to-cart-button-4"));
            kosz.Click();
            Thread.Sleep(1000); // polecenie aby poczekalo sekunde, zeby wykonac nastepny krok
            driver.Navigate().GoToUrl("http://demo.nopcommerce.com/cart");
            IWebElement inCart = driver.FindElement(By.ClassName("product-name")); // znalezienie po klasie produkt
            Assert.IsTrue(inCart.Text.Contains("Apple MacBook Pro 13-inch")); // sprawdzanie czy tekst zawiera dany tekst
        }

        [TestMethod]
        public void TestMethod6()
        {
            IWebDriver driver = new ChromeDriver(); //otworzenia obiektu inicjalizujacego przegladarke
            driver.Manage().Window.Maximize(); // maksymalizacja okna
            driver.Navigate().GoToUrl("http://google.pl");  //przejdz do adresu
            IWebElement searchbox = driver.FindElement(By.Name("q"));  //znalezienie okna wyszukiwarki
            searchbox.SendKeys("hey"); // wpisanie w wyszukiwarce tekstu
            Thread.Sleep(1000);
            IWebElement submit = driver.FindElement(By.Name("btnK")); // znalezieniu przycisku wyslij
            submit.Click(); //klikniecie przycisku
        }


    }
}
