using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.Context.Consts;
using Assets.UiTest.TestSteps;
using UiTest.UiTest.Checker;

namespace UiTest.UiTest.TestSteps
{
    public class CheckItemAtInventory : UiTestStepBase
    {
        public override string Id => "check_item_inventory";
        public override double TimeOut => 300;

        private string objectName;
        private int cellNumber;
        private int count;
        private bool isExist;
        private StringParam cellParam;
        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            var cellCountChecker = new CellCountChecker(Context, cellParam, cellNumber, count);
            if (isExist)
            {
                if (!cellCountChecker.Check())
                {
                    Fail($"Object {objectName} not in {cellNumber} cell or has wrong count {count}");
                }
            }
            else
            {
                if (cellCountChecker.Check())
                { 
                    Fail($"Object {objectName} shouldn't be in {cellNumber} cell!");
                }  
            }
            return null;
        }

        public CheckItemAtInventory(string objectName, StringParam cellParam, int cellNumber, int count, bool isExist)
        {
            this.objectName = objectName;
            this.cellNumber = cellNumber;
            this.count = count;
            this.isExist = isExist;
            this.cellParam = cellParam;
        }
    }
}
