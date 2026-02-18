using Microsoft.VisualStudio.TestTools.UnitTesting;

#if !NETCOREAPP3_1 && !NET5_0
// Sequential test execution
[assembly: DoNotParallelize]
#endif