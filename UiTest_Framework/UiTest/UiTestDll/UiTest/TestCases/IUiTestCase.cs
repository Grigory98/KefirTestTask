using System.Collections;
using Assets.UiTest.Context;

namespace Assets.UiTest.Runner
{
    public interface IUiTestCase
    {
        IEnumerator Run(IUiTestContext context);
        void Stop();
    }
}