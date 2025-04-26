using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.Context.Consts;
using Assets.UiTest.Results;
using Assets.UiTest.TestSteps;
using UiTest.UiTest.Checker;

namespace UiTest.UiTest.TestSteps.InventorySteps
{
    class CheckProductionForCoinsStep : UiTestStepBase
    {
        public override string Id => "check_production_for_coins_step";
        public override double TimeOut => 300;

        private int cellIndex;
        private int? expectedCoinsNumber;
        private bool isEmptyWoodPlank;
        private bool isSkip;
        
        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            yield return Commands.UseButtonClickCommand(Screens.Inventory.Button.Skip, new ResultData<SimpleCommandResult>());
            if (expectedCoinsNumber == null)
            {
                CheckCoinsIsNull(cellIndex);
            }
            else
            {
                CheckCountCoins(cellIndex, (int)expectedCoinsNumber);
            }

            if (isEmptyWoodPlank)
            { 
                CheckWoodPlankIsEmpty();
            } 
            else
            {
                CheckWoodPlankIsNotEmpty();
            }  
        }

        /// <summary>
        /// Checks the number of coins.
        /// </summary>
        /// <param name="cellIndex">Index of the cell with coins</param>
        /// <param name="count">Expected count of coins</param>
        private void CheckCountCoins(int cellIndex, int count)
        {
            var cellCountChecker = new CellCountChecker(Context, Screens.Inventory.Cell.Pockets, cellIndex, count);
            if (!cellCountChecker.Check())
            {
                Fail("Wrong coins count at pockets 4th cell");
            }
        }

        /// <summary>
        /// Checks that the coins have been removed from the inventory.
        /// </summary>
        /// <param name="cellIndex">Index of the cell with coins</param>
        private void CheckCoinsIsNull(int cellIndex)
        {
            var cellNullChecker = new CountIsEmptyChecker(Context, Screens.Inventory.Cell.Pockets, cellIndex);
            if (!cellNullChecker.Check())
            {
                Fail("Coins didn't disappear from inventory.");
            }
        }

        /// <summary>
        /// Checking that there are no any wood planks in the workbench.
        /// </summary>
        private void CheckWoodPlankIsEmpty()
        {
            var countIsEmptyChecker = new CountIsEmptyChecker(Context, Screens.Inventory.Cell.WorkbenchResult, 0);
            if (!countIsEmptyChecker.Check())
            {
                Fail($"The wood plank shouldn't be produced.");
            }
        }

        /// <summary>
        /// Checking that workbench has been produced any wood planks.
        /// </summary>
        private void CheckWoodPlankIsNotEmpty()
        {
            var countIsEmptyChecker = new CountIsEmptyChecker(Context, Screens.Inventory.Cell.WorkbenchResult, 0);
            if (countIsEmptyChecker.Check())
            {
                Fail($"The wood plank hasn't been producted.");
            }
        }

        public CheckProductionForCoinsStep(int cellIndex, int? expectedCoinsNumber, bool isEmptyWoodPlank)
        {
            this.cellIndex = cellIndex;
            this.expectedCoinsNumber = expectedCoinsNumber;
            this.isEmptyWoodPlank = isEmptyWoodPlank;
        }
    }
}
