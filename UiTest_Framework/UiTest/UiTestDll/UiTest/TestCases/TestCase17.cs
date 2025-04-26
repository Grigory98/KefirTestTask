using System.Collections.Generic;
using Assets.UiTest.Context.Consts;
using Assets.UiTest.Runner;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestCases
{
    class TestCase17 : UiStepsTestCase
    {
        protected override IEnumerator<IUiTestStepBase> Condition()
        {
            yield return Steps.WaitStartLoadingStep();
            yield return Steps.OpenInventoryStep();

            // Check cells in pocket
            for (int i = 3; i < 9; i++)
            {
                yield return Steps.MoveObjectToAnotherPositionInPocketStep(i, i + 1, 50);
            }

            yield return Steps.MoveObjectFromPocketToAnotherPositionStep(9, 10, Screens.Inventory.Cell.Backpack, 50);

            // Check cells in backpack
            for (int i = 10; i < 25; i++)
            {
                yield return Steps.MoveObjectToAnotherPositionInBackpackStep(i, i + 1, 50);
            }

            yield return Steps.CloseInventoryStep();
        }
    }
}
