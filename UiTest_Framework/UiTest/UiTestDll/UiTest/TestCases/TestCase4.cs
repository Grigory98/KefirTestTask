using System.Collections.Generic;
using Assets.UiTest.Context.Consts;
using Assets.UiTest.Runner;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestCases
{
    public class TestCase4 : UiStepsTestCase
    {
        protected override IEnumerator<IUiTestStepBase> Condition()
        {
            yield return Steps.WaitStartLoadingStep();
            yield return Steps.OpenInventoryStep();
            yield return Steps.MoveObjectFromPocketToAnotherPositionStep(0, 10, Screens.Inventory.Cell.Backpack, 1);
            yield return Steps.MoveObjectFromPocketToAnotherPositionStep(1, 11, Screens.Inventory.Cell.Backpack, 1);
            yield return Steps.MoveObjectFromPocketToAnotherPositionStep(2, 12, Screens.Inventory.Cell.Backpack, 1);
            yield return Steps.MoveObjectFromPocketToAnotherPositionStep(3, 13, Screens.Inventory.Cell.Backpack, 50);
            yield return Steps.CloseInventoryStep();
        }
    }
}
