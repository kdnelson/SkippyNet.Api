using Dinerware.Api.Test.Enums;
using SkippyNet.Api.Test.Dtos.Classes.Common;
using SkippyNet.Api.Test.Interfaces.Common;
using SkippyNet.Api.Test.Interfaces.Work;
using System;
using System.Collections.Generic;

namespace SkippyNet.Api.Test.Controllers
{
    public class TestController : ITestController
    {
        private const string ClassName = nameof(TestController);
        private readonly IWorkTestController _workTestController;

        public TestController(IWorkTestController workTestController) 
        {
            _workTestController = workTestController;
        }

        public async void Run(TestType testType)
        {
            const string methodName = ClassName + "." + nameof(Run);

            try
            {
                var testLogList = new List<TestLogDto>();

                if (testType == TestType.All)
                {
                    var workTests = await _workTestController.RunAsync(TestType.Work);
                    if (workTests != null)
                    {
                        testLogList.AddRange(workTests);
                    }
                }

                if (testType == TestType.Work)
                {
                    var workTests = await _workTestController.RunAsync(TestType.Work);
                    if (workTests != null)
                    {
                        testLogList.AddRange(workTests);
                    }
                }

                DisplayTestLogList(testLogList);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(methodName + " " + ex);
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }

        private void DisplayTestLogList(List<TestLogDto> testLogList)
        {
            if (testLogList != null)
            {
                foreach (var test in testLogList)
                {
                    if (test.Passed)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(test.TestType + " - " + test.TestId);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(test.TestType + " - " + test.TestId + " " + test.ErrorMessage);
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
            }
        }
    }
}
