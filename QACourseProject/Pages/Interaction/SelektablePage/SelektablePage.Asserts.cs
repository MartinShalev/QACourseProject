using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace ProjectInProgres.Pages.SelektablePage
{
    public partial class SelektablePage
    {
        public void AssertBlueBackGroundFor(WebElement selectableElement)
        {
            Assert.AreEqual("rgba(0, 123, 255, 1)", selectableElement.GetCssValue("background-color"));
        }
    }
}
