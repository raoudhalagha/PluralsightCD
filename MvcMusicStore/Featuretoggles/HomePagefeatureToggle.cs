using FeatureToggle.Core;
using FeatureToggle.Toggles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Featuretoggles
{
    public class HomePagefeatureToggle : SimpleFeatureToggle
    {
        static HomePagefeatureToggle _current;
        protected HomePagefeatureToggle()
        {
            ToggleValueProvider = new InMemoryTogglevalueProvider();
        }

        static public HomePagefeatureToggle Current
        {
            get
            {
                if (_current == null)
                    _current = new HomePagefeatureToggle();
                return _current;
            }


        }
        public void TurnOn()
        {
            ((InMemoryTogglevalueProvider)ToggleValueProvider).SetValue(true);
        }

        public void TurnOff()
        {
            ((InMemoryTogglevalueProvider)ToggleValueProvider).SetValue(false);
        }

    }






    public class InMemoryTogglevalueProvider : IBooleanToggleValueProvider
    {
        static bool SwitchValue = false;

        public InMemoryTogglevalueProvider(bool initialValue = false)
        {
            SwitchValue = initialValue;
        }

        public void SetValue(bool switchValue)
        {
            SwitchValue = switchValue;
        }
        public bool EvaluateBooleanToggleValue(IFeatureToggle toggle)
        {
            return SwitchValue;
        }

    }
}