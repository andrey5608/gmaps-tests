using TechTalk.SpecFlow;
using gmapsTests.Pages.GoogleMaps;

namespace gmapsTests.Steps
{
    [Binding]
    public class FrontendStepsWhen : FrontendStepsBase
    {
        public FrontendStepsWhen(ScenarioContext injectedContext, FeatureContext featureContext) : base(injectedContext, featureContext)
        {
        }

        [When(@"I open the main page")]
        public void WhenIOpenTheMainPage()
        {
            actions.GoToUrl(MainPage.Link);
        }

        [When(@"I write to the field (.*) text (.*)")]
        public void WhenIWriteTheText(string element, string text)
        {
            SetText(element, text);
        }
    }
}
