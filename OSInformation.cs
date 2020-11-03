using System.Runtime.InteropServices;
using Xunit;

namespace XUnitTests
{
    public class RunningOnOS
    {
        [Fact]
        public void IsRunningOnLinux() {
            Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Linux));
        }

        [Fact]
        public void IsRunningOnWindows()
        {
            Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
        }
    }
}
