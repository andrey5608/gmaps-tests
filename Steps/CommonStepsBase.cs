using TechTalk.SpecFlow;

namespace gmapsTests.Steps
{
    public class CommonStepsBase
    {
        protected readonly ScenarioContext context;
        protected readonly FeatureContext featureContext;
        protected string currentPageObject;

        public CommonStepsBase(ScenarioContext injectedContext, FeatureContext featureContext)
        {
            context = injectedContext;
            this.featureContext = featureContext;
        }
    }
}
