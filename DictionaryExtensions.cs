using System.Collections.Generic;
using OpenQA.Selenium;

namespace gmapsTests
{
    public class DictionaryExtensions
    {
        private Dictionary<string, IWebElement> elements;

        public Dictionary<string, IWebElement> Elements { get => elements; set => elements = value; }

        public IWebElement GetFromDictionaryByName(string name)
        {
            return Elements.TryGetValue(name, out var element) ? element : null;
        }
    }
}
