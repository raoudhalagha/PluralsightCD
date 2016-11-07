
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xunit.Tests
{
    public class TestFeatureToggles
    {
        [Fact]
        public void XunitTestFeatureToggleIsOn()
        {
            HomePagefeatureToggle.Current.TurnOn();
            Assert.True(HomePagefeatureToggle.Current.FeatureEnabled);
        }
        [Fact]
        public void XunitTestFeatureToggleIsOff()
        {
            HomePagefeatureToggle.Current.TurnOff();
            Assert.False(HomePagefeatureToggle.Current.FeatureEnabled);
        }

    }
}
