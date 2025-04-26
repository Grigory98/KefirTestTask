using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.Context.Consts;
using Assets.UiTest.Results;
using Assets.UiTest.TestSteps;
using UiTest.UiTest.Checker;
using UnityEngine;

namespace UiTest.UiTest.TestSteps
{
    class CutThreeStep : UiTestStepBase
    {
        public override string Id => "cut_three_step";
        public override double TimeOut => 300;

        private bool isTreeFelled;
        private bool isUseButtonActive;

        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            var tree = Cheats.FindTree()[0];
            yield return GoToTree(tree);
            if (isUseButtonActive)
                CheckIsUseButtonActive();

            yield return CutTree();
            yield return Commands.WaitForSecondsCommand(5, new ResultData<SimpleCommandResult>());
            if (isTreeFelled)
                CheckIsTreeFelled(tree);
        }

        private IEnumerator GoToTree(GameObject tree)
        {
            yield return Commands.PlayerMoveCommand(tree.transform.position, new ResultData<PlayerMoveResult>());
            yield return Commands.WaitForSecondsCommand(1, new ResultData<SimpleCommandResult>());
        }

        private IEnumerator CutTree()
        {
            for (int i = 0; i < 3; i++)
            {
                yield return Commands.UseButtonClickCommand(Screens.Main.Button.Use, new ResultData<SimpleCommandResult>());
                yield return Commands.WaitForSecondsCommand(1, new ResultData<SimpleCommandResult>());
            }
        }
        private void CheckIsUseButtonActive()
        {
            var useButtonIsActive = new UseButtonIsActiveChecker(Context);
            if (!useButtonIsActive.Check())
            {
                Fail("Use button is not active");
            }
        }

        private void CheckIsTreeFelled(GameObject tree)
        {
            var treeFeeledChecker = new TreeFelledChecker(Context, tree);
            if (!treeFeeledChecker.Check())
            {
                Fail("Tree hasn't been felled!");
            }
        }

        public CutThreeStep(bool isTreeFelled, bool isUseButtonActive)
        {
            this.isTreeFelled = isTreeFelled;
            this.isUseButtonActive = isUseButtonActive;
        }
    }
}
