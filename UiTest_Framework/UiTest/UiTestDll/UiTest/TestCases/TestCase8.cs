using System.Collections.Generic;
using Assets.UiTest.Runner;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestCases
{
    public class TestCase8 : UiStepsTestCase
    {
        protected override IEnumerator<IUiTestStepBase> Condition()
        {
            yield return Steps.WaitStartLoadingStep();
            yield return Steps.OpenInventoryStep();
            
            for(int i = 0; i < 4; i++)
                yield return Steps.DeleteItemStep(i);

            yield return Steps.CloseInventoryStep();
            yield return Steps.CutThreeStep(isTreeFelled: false, isUseButtonActive: false);
            yield return Steps.OpenInventoryStep();
            yield return Steps.CheckItemAtInventoryPocketStep("Tree", 0, 3, false);
        }
    }
}
