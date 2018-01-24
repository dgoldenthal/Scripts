using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestingWebpage
{
    [TestClass]
    public class WebpageTest
    {
        public static string BaseUrl = "http://www.google.com";
        

        [TestMethod]
        public void GotoPage()
        {
	    //Create the reference for our browser
         IWebDriver driver = new ChromeDriver();
	    driver.Manage().Window.Maximize();
           
	    //Navigate to google page 
          driver.Navigate().GoToUrl(BaseUrl);

         //Find the Search text box UI Element
         IWebElement element = driver.FindElement(By.Name("q"));
 
         //Perform Operation
         element.SendKeys("automation");

         IWebElement searchButton = chromeDriver.FindElement (By.Name("btnK"));
         searchButton.Click() ;

        // Get the search results panel that contains the link for each result.
        IWebElement resultsPanel = driver.FindElement(By.Id("search"));

       // Get all the links only contained within the search result panel.
       ReadOnlyCollection<IWebElement> searchResults =  resultsPanel.FindElements(By.XPath(".//a"));
		
		//Close the browser
           driver.Close();
	      driver.Quit();            

        }
    }
}