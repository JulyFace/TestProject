using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Core;

namespace TestProject.Pages.ElementsPage
{
    public partial class RadioButtons : BasePage
    {
        public WebElement YesRadioButton => Driver.FindElement(By.XPath("//label[contains(text(),'Yes')]"));
        public WebElement ImpressiveRadioButton => Driver.FindElement(By.XPath("//label[contains(text(),'Impressive')]"));
        public WebElement No_RadioButton => Driver.FindElement(By.XPath("//input[@id='noRadio']"));


        public WebElement ChoiceIndicator => Driver.FindElement(By.XPath("//p[contains(text(),'You have selected')]"));


    }
}
