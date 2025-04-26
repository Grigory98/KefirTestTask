using System.Collections.Generic;
using Assets.UiTest.Runner;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestCases
{
    public class TestCase18 : UiStepsTestCase
    {
        protected override IEnumerator<IUiTestStepBase> Condition()
        {
            yield return Steps.WaitStartLoadingStep();
            yield return Steps.GetWoodStep(3);
            yield return Steps.GoToWorkbenchStep();
            yield return Steps.MoveObjectFromPocketToWorkbenchStep(4, 3);
            yield return Steps.CheckProductionStep(4, 1, true);

            yield return Steps.CheckCoinsAfterProductionStep(3, 45);
            yield return Steps.CheckProductionStep(4, 3, false);

            yield return Steps.MoveObjectFromWorkbenchStep(4, 3);
            yield return Steps.CheckItemAtInventoryPocketStep("Plank", 4, 3);
            yield return Steps.CloseInventoryStep();
        }
    }
}
