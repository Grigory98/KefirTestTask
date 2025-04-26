using System.Collections.Generic;
using Assets.UiTest.Runner;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestCases
{
    class TestCase11 : UiStepsTestCase
    {
        protected override IEnumerator<IUiTestStepBase> Condition()
        {
            yield return Steps.WaitStartLoadingStep();
            yield return Steps.GoToWorkbenchStep();
            yield return Steps.MoveObjectFromPocketToWorkbenchResultStep(0, 1);
            yield return Steps.CheckResultWorkbenchCellStep();
        }
    }
}
