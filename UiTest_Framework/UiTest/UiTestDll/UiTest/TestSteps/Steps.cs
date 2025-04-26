using System.Security.AccessControl;
using Assets.UiTest.Context;
using Assets.UiTest.Context.Consts;
using UiTest.UiTest.TestSteps;

namespace Assets.UiTest.TestSteps
{
    public class Steps
    {
        public Steps(IUiTestContext context)
        {
            UiTestStepBase.SetContext(context);
        }

        public IUiTestStepBase WaitStartLoadingStep()
        {
            return new WaitStartLoadingStep();
        }

        public IUiTestStepBase ExampleStep()
        {
            return new ExampleStep();
        }

        public IUiTestStepBase CutThreeStep(bool isTreeFelled = true, bool isUseButtonActive = true)
        {
            return new CutThreeStep(isTreeFelled, isUseButtonActive);
        }

        public IUiTestStepBase CheckWoodCountAtInventory(int cellIndex, int count)
        {
            return new CheckWoodCountAtInventory(cellIndex, count);
        }

        public IUiTestStepBase OpenInventoryStep()
        {
            return new OpenInventoryStep();
        }

        public IUiTestStepBase DeleteItemStep(int cellIndex)
        {
            return new DeleteItemStep(cellIndex);
        }

        public IUiTestStepBase CloseInventoryStep()
        {
            return new CloseInventoryStep();
        }

        public IUiTestStepBase MoveObjectToAnotherPositionInPocketStep(int cellNumberStart, int cellNumberEnd, int count)
        {
            return new MoveObjectStep(Screens.Inventory.Cell.Pockets, cellNumberStart, cellNumberEnd, Screens.Inventory.Cell.Pockets, count);
        }

        public IUiTestStepBase MoveObjectToAnotherPositionInBackpackStep(int cellNumberStart, int cellNumberEnd, int count)
        {
            return new MoveObjectStep(Screens.Inventory.Cell.Backpack, cellNumberStart, cellNumberEnd, Screens.Inventory.Cell.Backpack, count);
        }

        public IUiTestStepBase MoveObjectFromPocketToAnotherPositionStep(int cellNumberStart, int cellNumberEnd, StringParam cell, int count)
        {
            return new MoveObjectStep(Screens.Inventory.Cell.Pockets, cellNumberStart, cellNumberEnd, cell, count);
        }

        public IUiTestStepBase MoveObjectFromPocketToWorkbenchStep(int cellNumber, int count)
        {
            return new MoveObjectStep(Screens.Inventory.Cell.Pockets, cellNumber, 0, Screens.Inventory.Cell.WorkbenchRow, count);
        }

        public IUiTestStepBase MoveObjectFromPocketToWorkbenchResultStep(int cellNumber, int count)
        {
            return new MoveObjectStep(Screens.Inventory.Cell.Pockets, cellNumber, 0, Screens.Inventory.Cell.WorkbenchResult, count);
        }

        public IUiTestStepBase MoveObjectFromWorkbenchStep(int cellNumber, int count)
        {
            return new MoveObjectStep(Screens.Inventory.Cell.WorkbenchResult, 0, cellNumber, Screens.Inventory.Cell.Pockets, count);
        }

        public IUiTestStepBase CheckResultWorkbenchCellStep()
        {
            return new CheckResultWorkbenchCellStep();
        }

        public IUiTestStepBase GoToWorkbenchStep()
        {
            return new GoToWorkbenchStep();
        }

        public IUiTestStepBase WaitStep(int seconds)
        {
            return new WaitStep(seconds);
        }

        public IUiTestStepBase GetWoodStep(int amount)
        {
            return new GetWoodStep(amount);
        }

        public IUiTestStepBase GetAxeStep(int amount)
        {
            return new GetAxeStep(amount);
        }

        public IUiTestStepBase GetCoinsStep(int amount)
        {
            return new GetCoinsStep(amount);
        }

        public IUiTestStepBase GetWoodPlankStep(int amount)
        {
            return new GetWoodPlankStep(amount);
        }

        public IUiTestStepBase CheckProductionStep(int seconds)
        {
            return new CheckProductionStep(seconds, null, true);
        }

        public IUiTestStepBase CheckProductionStep(int seconds, int resultAmount, bool isWoodPlankEmpty)
        {
            return new CheckProductionStep(seconds, resultAmount, isWoodPlankEmpty);
        }

        public IUiTestStepBase CheckCoinsAfterProductionStep(int cellIndex, int expectedCoinsNumber)
        {
            return new CheckProductionForCoinsStep(cellIndex, expectedCoinsNumber, false);
        }

        public IUiTestStepBase CheckCoinsIsNegativeAfterProductionStep(int cellIndex, int expectedCoinsNumber)
        {
            return new CheckProductionForCoinsStep(cellIndex, expectedCoinsNumber, true);
        }

        public IUiTestStepBase CheckCoinsIsNullAfterProductionStep(int cellIndex)
        {
            return new CheckProductionForCoinsStep(cellIndex, null, false);
        }

        public IUiTestStepBase CheckSkipProductionWithoutWoodStep(int cellIndex, int expectedCoins)
        { 
            return new CheckProductionForCoinsStep(cellIndex, expectedCoins, true);
        }

        public IUiTestStepBase CheckItemAtInventoryPocketStep(string objectName, int cellNumber, int count, bool isExists = true)
        {
            return new CheckItemAtInventory(objectName, Screens.Inventory.Cell.Pockets, cellNumber, count, isExists);
        }

        public IUiTestStepBase CheckItemAtInventoryBackpackStep(string objectName, int cellNumber, int count, bool isExists = true)
        {
            return new CheckItemAtInventory(objectName, Screens.Inventory.Cell.Backpack, cellNumber, count, isExists);
        }

        public IUiTestStepBase CheckItemAtWorkbenchRowStep(string objectName, int count, bool isExists = true)
        {
            return new CheckItemAtInventory(objectName, Screens.Inventory.Cell.WorkbenchRow, 0, count, isExists);
        }
    }   
}