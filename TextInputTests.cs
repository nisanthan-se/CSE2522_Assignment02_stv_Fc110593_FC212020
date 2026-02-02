using NUnit.Framework;
using CSE2522_Assignment02.Pages;
using CSE2522_Assignment02.Utilities;
using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace CSE2522_Assignment02.Tests
{
    [TestFixture]
    public class TextInputTests : BaseTest
    {
        // Test Case: TC001_1 - Text Input Verification
        [Test]
        public void VTC001_1_TextInput_Verification()
        {
            // Arrange
            TextInputPage textInputPage = new TextInputPage(driver);
            string randomText = "Btn_" + DateTime.Now.Ticks;

            // Act – Navigate to Text Input page
            textInputPage.OpenTextInputPage();

            // Assert – Verify page elements
            Assert.IsTrue(textInputPage.IsTextBoxDisplayed(),
                "Text box is not displayed on Text Input page");

            Assert.IsTrue(textInputPage.IsButtonDisplayed(),
                "Button is not displayed on Text Input page");

            // Act – Enter text and click button
            textInputPage.EnterText(randomText);
            textInputPage.ClickButton();

            // Assert – Verify button text change
            Assert.AreEqual(randomText, textInputPage.GetButtonText(),
                "Button text did not update to the entered value");
        }
    }
}
