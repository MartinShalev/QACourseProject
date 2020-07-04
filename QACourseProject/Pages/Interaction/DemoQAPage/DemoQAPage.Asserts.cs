using NUnit.Framework;

namespace ProjectInProgres.Pages
{
    public partial class DemoQAPage
    {
        public void AssertPageTitle(string expectedTitle)
        {
            Assert.AreEqual(expectedTitle, PageTitle.Text);
        }
    }
}
