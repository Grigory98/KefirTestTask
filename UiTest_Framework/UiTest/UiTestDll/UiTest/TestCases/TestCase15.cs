using System.Collections.Generic;
using Assets.UiTest.Runner;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestCases
{
    public class TestCase15 : UiStepsTestCase
    {
        protected override IEnumerator<IUiTestStepBase> Condition()
        {
            yield return Steps.WaitStartLoadingStep();
            yield return Steps.OpenInventoryStep();

            yield return Steps.GetAxeStep(26);
            for (int i = 4; i < 10; i++)
                yield return Steps.CheckItemAtInventoryPocketStep("Axe", i, 1);

            for (int i = 0; i < 15; i++)
                yield return Steps.CheckItemAtInventoryBackpackStep("Axe", i, 1);

            yield return Steps.CloseInventoryStep();
        }
    }
}
