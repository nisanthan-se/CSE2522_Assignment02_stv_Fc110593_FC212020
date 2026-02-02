using OpenQA.Selenium;

namespace CSE2522_Assignment02.Pages
{
    public class TextInputPage
    {
        private IWebDriver driver;

        public TextInputPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Elements
        private IWebElement TextInputLink => driver.FindElement(By.LinkText("Text Input"));
        private IWebElement TextBox => driver.FindElement(By.Id("newButtonName"));
        private IWebElement Button => driver.FindElement(By.Id("updatingButton"));

        // Actions
        public void OpenTextInputPage()
        {
            TextInputLink.Click();
        }

        public bool IsTextBoxDisplayed()
        {
            return TextBox.Displayed;
        }

        public bool IsButtonDisplayed()
        {
            return Button.Displayed;
        }

        public void EnterText(string text)
        {
            TextBox.Clear();
            TextBox.SendKeys(text);
        }

        public void ClickButton()
        {
            Button.Click();
        }

        public string GetButtonText()
        {
            return Button.Text;
        }
    }
}
