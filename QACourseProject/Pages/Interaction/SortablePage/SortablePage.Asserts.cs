using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

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
