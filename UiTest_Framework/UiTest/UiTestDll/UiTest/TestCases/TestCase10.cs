using System.Collections.Generic;
using Assets.UiTest.Runner;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestCases
{
    public class TestCase10 : UiStepsTestCase
    {
        protected override IEnumerator<IUiTestStepBase> Condition()
        {
            yield return Steps.WaitStartLoadingStep();
            yield return Steps.OpenInventoryStep();
            for (int i = 0; i < 4; i++)
                yield return Steps.DeleteItemStep(i);

            yield return Steps.GetAxeStep(1);
            yield return Steps.CloseInventoryStep();

            for (int i = 0; i < 3; i++)
                yield return Steps.CutThreeStep();

            yield return Steps.OpenInventoryStep();
            yield return Steps.CheckItemAtInventoryPocketStep("Axe", 0, 0, false);
        }
    }
}
