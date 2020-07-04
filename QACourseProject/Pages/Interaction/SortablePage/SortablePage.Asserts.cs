using NUnit.Framework;

namespace ProjectInProgres.Pages
{
    public partial class SortablePage
    {
        public void AssertTextByIndex(string expectedText, int index)
        {
            Assert.AreEqual(expectedText, ListOfOptions[index].Text);
        }
    }
}
