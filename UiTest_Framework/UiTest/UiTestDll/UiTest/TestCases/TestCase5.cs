using System.Collections.Generic;
using Assets.UiTest.Runner;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestCases
{
    public class TestCase5 : UiStepsTestCase
    {
        protected override IEnumerator<IUiTestStepBase> Condition()
        {
            yield return Steps.WaitStartLoadingStep();
            yield return Steps.GetWoodStep(1);
            yield return Steps.GoToWorkbenchStep();
            yield return Steps.MoveObjectFromPocketToWorkbenchStep(4, 1);
            yield return Steps.CheckProductionStep(4);
            yield return Steps.MoveObjectFromWorkbenchStep(4, 1);
            yield return Steps.CheckItemAtInventoryPocketStep("Plank", 4, 1);
            yield return Steps.CloseInventoryStep();
        }
    }
}
