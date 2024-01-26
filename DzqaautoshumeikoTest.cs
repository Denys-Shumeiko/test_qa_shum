// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class DzqaautoshumeikoTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void lastdz() {
    driver.Navigate().GoToUrl("https://qauto.forstudy.space/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);
    driver.FindElement(By.CssSelector(".hero-descriptor_btn")).Click();
    driver.FindElement(By.Id("signupName")).SendKeys("zxc");
    driver.FindElement(By.Id("signupLastName")).SendKeys("zxc");
    driver.FindElement(By.Id("signupEmail")).SendKeys("zxc@zxc.com");
    driver.FindElement(By.Id("signupPassword")).SendKeys("Qwerty12");
    driver.FindElement(By.Id("signupRepeatPassword")).SendKeys("Qwerty12");
    driver.FindElement(By.CssSelector(".btn-primary:nth-child(1)")).Click();
    {
      WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(3));
      wait.Until(driver => driver.FindElements(By.XPath("//*[@id=\'userNavDropdown\']")).Count > 0);
    }
    var elements = driver.FindElements(By.XPath("//*[@id=\'userNavDropdown\']"));
    Assert.True(elements.Count > 0);
    driver.FindElement(By.LinkText("Profile")).Click();
    {
      WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(3));
      wait.Until(driver => driver.FindElements(By.XPath("//div[@class=\'profile d-flex flex-column align-items-center\']")).Count > 0);
    }
    var elements = driver.FindElements(By.XPath("//div[@class=\'profile d-flex flex-column align-items-center\']"));
    Assert.True(elements.Count > 0);
    driver.FindElement(By.CssSelector(".sidebar > .btn:nth-child(1)")).Click();
    driver.FindElement(By.CssSelector(".btn-primary")).Click();
    driver.FindElement(By.Id("addCarBrand")).Click();
    {
      var dropdown = driver.FindElement(By.Id("addCarBrand"));
      dropdown.FindElement(By.XPath("//option[. = 'Porsche']")).Click();
    }
    driver.FindElement(By.Id("addCarModel")).Click();
    {
      var dropdown = driver.FindElement(By.Id("addCarModel"));
      dropdown.FindElement(By.XPath("//option[. = 'Panamera']")).Click();
    }
    driver.FindElement(By.Id("addCarMileage")).Click();
    driver.FindElement(By.Id("addCarMileage")).SendKeys("100");
    driver.FindElement(By.CssSelector(".modal-footer > .btn-primary")).Click();
    driver.FindElement(By.CssSelector(".car_add-expense")).Click();
    driver.FindElement(By.Id("addExpenseMileage")).SendKeys("120");
    driver.FindElement(By.Id("addExpenseLiters")).Click();
    driver.FindElement(By.Id("addExpenseLiters")).SendKeys("20");
    driver.FindElement(By.Id("addExpenseTotalCost")).Click();
    driver.FindElement(By.Id("addExpenseTotalCost")).SendKeys("20");
    driver.FindElement(By.CssSelector(".modal-footer")).Click();
    driver.FindElement(By.CssSelector(".modal-footer > .btn-primary")).Click();
    {
      WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(3));
      wait.Until(driver => driver.FindElements(By.XPath("//th[@_ngcontent-jqn-c79 and contains(text(), \'Total cost\')]")).Count > 0);
    }
    var elements = driver.FindElements(By.XPath("//th[@_ngcontent-jqn-c79 and contains(text(), \'Total cost\')]"));
    Assert.True(elements.Count > 0);
    driver.FindElement(By.LinkText("Settings")).Click();
    {
      WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(3));
      wait.Until(driver => driver.FindElements(By.XPath("//div [@class=\'user-settings_item -form -change-email\']")).Count > 0);
    }
    var elements = driver.FindElements(By.XPath("//div [@class=\'user-settings_item -form -change-email\']"));
    Assert.True(elements.Count > 0);
    driver.FindElement(By.CssSelector(".btn-danger-bg")).Click();
    driver.FindElement(By.CssSelector(".btn-danger")).Click();
  }
}
