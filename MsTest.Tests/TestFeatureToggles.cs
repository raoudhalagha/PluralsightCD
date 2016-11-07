using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MsTest.Tests
{
    [TestClass]
    public class TestFeatureToggles
    {
        [TestMethod]
        public void MSTestFeatureToggleIsOn()
        {
            HomePagefeatureToggle.Current.TurnOn();
            Assert.IsTrue(HomePagefeatureToggle.Current.FeatureEnabled);
        }
        [TestMethod]
        public void MSTestFeatureToggleIsOff()
        {
            HomePagefeatureToggle.Current.TurnOff();
            Assert.IsFalse(HomePagefeatureToggle.Current.FeatureEnabled);
        }
    }
}
