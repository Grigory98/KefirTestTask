using System.Collections.Generic;
using Assets.UiTest.Runner;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestCases
{
    public class TestCase6 : UiStepsTestCase
    {
        protected override IEnumerator<IUiTestStepBase> Condition()
        {
            yield return Steps.WaitStartLoadingStep();
            yield return Steps.OpenInventoryStep();
            yield return Steps.CheckItemAtInventoryPocketStep("Axe", 2, 1);
            yield return Steps.CheckItemAtInventoryPocketStep("Coins", 3, 50);
            yield return Steps.MoveObjectToAnotherPositionInPocketStep(2, 3, 1);
            yield return Steps.CheckItemAtInventoryPocketStep("Axe", 3, 1);
            yield return Steps.CheckItemAtInventoryPocketStep("Coins", 2, 50);
            yield return Steps.CloseInventoryStep();
        }
    }
}
