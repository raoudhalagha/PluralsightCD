using MvcMusicStore.Featuretoggles;
using NUnit.Framework;

namespace Nunit.Tests
{
    [TestFixture]
    public class TestFeatureToggles
    {
        [Test]
        public void NunitTestFeatureToggleIsOn()
        {
            HomePagefeatureToggle.Current.TurnOn();
            Assert.True(HomePagefeatureToggle.Current.FeatureEnabled);
        }
        [Test]
        public void NunitTestFeatureToggleIsOff()
        {
            HomePagefeatureToggle.Current.TurnOff();
            Assert.False(HomePagefeatureToggle.Current.FeatureEnabled);
        }
    }
}
