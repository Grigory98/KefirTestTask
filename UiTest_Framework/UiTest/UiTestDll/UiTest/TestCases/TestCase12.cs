using System.Collections.Generic;
using Assets.UiTest.Runner;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestCases
{
    public class TestCase12 : UiStepsTestCase
    {
        protected override IEnumerator<IUiTestStepBase> Condition()
        {
            yield return Steps.WaitStartLoadingStep();
            yield return Steps.GoToWorkbenchStep();
            yield return Steps.CheckSkipProductionWithoutWoodStep(3, 50);
        }
    }
}
