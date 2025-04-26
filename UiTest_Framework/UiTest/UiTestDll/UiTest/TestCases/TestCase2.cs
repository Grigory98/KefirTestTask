using System.Collections.Generic;
using Assets.UiTest.Runner;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestCases
{
    public class TestCase2 : UiStepsTestCase
    {
        protected override IEnumerator<IUiTestStepBase> Condition()
        {
            yield return Steps.WaitStartLoadingStep();
            yield return Steps.CutThreeStep();
            yield return Steps.CheckWoodCountAtInventory(4, 3);
            yield return Steps.CutThreeStep();
            yield return Steps.CheckWoodCountAtInventory(4, 6);
            yield return Steps.CutThreeStep();
            yield return Steps.CheckWoodCountAtInventory(4, 9);
        }
    }
}
