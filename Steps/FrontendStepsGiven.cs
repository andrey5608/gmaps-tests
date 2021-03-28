using gmapsTests.Pages.GoogleMaps;
using TechTalk.SpecFlow;

namespace gmapsTests.Steps
{
    [Binding]
    public class FrontendStepsGiven : FrontendStepsBase
    {
        public FrontendStepsGiven(ScenarioContext injectedContext, FeatureContext featureContext) : base(injectedContext, featureContext)
        {
        }

        [Given(@"I opened the main page")]
        public void GivenIOpenedTheMainPage()
        {
            actions.GoToUrl(MainPage.Link);
        }
    }
}
