using System.Collections.Generic;
using UiTest.UiTest.TestCases;

namespace Assets.UiTest.Runner
{
    public class UiTestCases : IUiTestCases
    {
        private Dictionary<int, IUiTestCase> _tests = new Dictionary<int, IUiTestCase>();

        public UiTestCases()
        {
            _tests.Add(0, new TestCase0());
            _tests.Add(1, new TestCase1());
            _tests.Add(2, new TestCase2());
            _tests.Add(3, new TestCase3());
            _tests.Add(4, new TestCase4());
            _tests.Add(5, new TestCase5());
            _tests.Add(6, new TestCase6());
            _tests.Add(7, new TestCase7());
            _tests.Add(8, new TestCase8());
            _tests.Add(9, new TestCase9());
            _tests.Add(10, new TestCase10());
            _tests.Add(11, new TestCase11());
            _tests.Add(12, new TestCase12());
            _tests.Add(13, new TestCase13());
            _tests.Add(14, new TestCase14());
            _tests.Add(15, new TestCase15());
            _tests.Add(16, new TestCase16());
            _tests.Add(17, new TestCase17());
            _tests.Add(18, new TestCase18());
        }

        public IUiTestCase GetTestCase(int test)
        {
            return _tests[test];
        }
    }
}