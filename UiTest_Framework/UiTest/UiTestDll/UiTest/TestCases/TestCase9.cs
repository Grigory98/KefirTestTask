using System.Collections.Generic;
using Assets.UiTest.Runner;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestCases
{
    public class TestCase9 : UiStepsTestCase
    {
        protected override IEnumerator<IUiTestStepBase> Condition()
        {
            yield return Steps.WaitStartLoadingStep();
            yield return Steps.OpenInventoryStep();
            yield return Steps.DeleteItemStep(3);
            yield return Steps.GetCoinsStep(1);
            yield return Steps.GetWoodStep(1);
            yield return Steps.CloseInventoryStep();

            yield return Steps.GoToWorkbenchStep();
            yield return Steps.MoveObjectFromPocketToWorkbenchStep(4, 1);
            yield return Steps.CheckCoinsIsNegativeAfterProductionStep(3, 1);
            yield return Steps.MoveObjectFromWorkbenchStep(5, 1);

            yield return Steps.DeleteItemStep(3);
            yield return Steps.GetCoinsStep(5);
            yield return Steps.GetWoodStep(1);
            yield return Steps.MoveObjectFromPocketToWorkbenchStep(4, 1);
            yield return Steps.CheckCoinsIsNullAfterProductionStep(3);
            yield return Steps.MoveObjectFromWorkbenchStep(5, 1);
        }
    }
}
