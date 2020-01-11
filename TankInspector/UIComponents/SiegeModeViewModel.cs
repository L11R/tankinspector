using Smellyriver.TankInspector.DataAnalysis;
using Smellyriver.TankInspector.Modeling;

namespace Smellyriver.TankInspector.UIComponents
{
    internal class SiegeModeViewModel
    {
        public static readonly DataItemDescriptor<SiegeModeViewModel> SiegeModeSwitchOnTimeDescriptor;
        public static readonly DataItemDescriptor<SiegeModeViewModel> SiegeModeSwitchOffTimeDescriptor;
        public static readonly DataItemDescriptor<SiegeModeViewModel> SiegeModeEngineDamageCoeffDescriptor;
        public static readonly DataItemDescriptor<SiegeModeViewModel> SiegeModeAutoSwitchOnRequiredVehicleSpeedDescriptor;
        public static readonly DataItemDescriptor<SiegeModeViewModel> SiegeModeAutoSwitchOffRequiredVehicleSpeedDescriptor;
        public static readonly DataItemDescriptor<SiegeModeViewModel> SiegeModeSwitchCancelEnabledDescriptor;

        static SiegeModeViewModel()
        {
            SiegeModeSwitchOnTimeDescriptor = new DataItemDescriptor<SiegeModeViewModel>("SiegeModeSwitchOnTimeFullName",
                tank => tank.SiegeMode, sm => sm.SiegeMode != null ? sm.SiegeMode.SwitchOnTime : 0.0, null, "SiegeModeSwitchOnTimeDescription", "{0}", ComparisonMode.LowerBetter);
            SiegeModeSwitchOffTimeDescriptor = new DataItemDescriptor<SiegeModeViewModel>("SiegeModeSwitchOffTimeFullName",
                tank => tank.SiegeMode, sm => sm.SiegeMode != null ? sm.SiegeMode.SwitchOffTime : 0.0, null, "SiegeModeSwitchOffTimeDescription", "{0}", ComparisonMode.LowerBetter);
            SiegeModeEngineDamageCoeffDescriptor = new DataItemDescriptor<SiegeModeViewModel>("SiegeModeEngineDamageCoeffFullName",
                tank => tank.SiegeMode, sm => sm.SiegeMode != null ? sm.SiegeMode.EngineDamageCoeff : 0.0, null, "SiegeModeEngineDamageCoeffDescription", "{0}", ComparisonMode.LowerBetter);
            SiegeModeAutoSwitchOnRequiredVehicleSpeedDescriptor = new DataItemDescriptor<SiegeModeViewModel>("SiegeModeAutoSwitchOnRequiredVehicleSpeedFullName",
                tank => tank.SiegeMode, sm => sm.SiegeMode != null ? sm.SiegeMode.AutoSwitchOnRequiredVehicleSpeed : 0.0, null, "SiegeModeAutoSwitchOnRequiredVehicleSpeedDescription", "{0}", ComparisonMode.HigherBetter);
            SiegeModeAutoSwitchOffRequiredVehicleSpeedDescriptor = new DataItemDescriptor<SiegeModeViewModel>("SiegeModeAutoSwitchOffRequiredVehicleSpeedFullName",
                tank => tank.SiegeMode, sm => sm.SiegeMode != null ? sm.SiegeMode.AutoSwitchOffRequiredVehicleSpeed : 0.0, null, "SiegeModeAutoSwitchOffRequiredVehicleSpeedDescription", "{0}", ComparisonMode.HigherBetter);
            SiegeModeSwitchCancelEnabledDescriptor = new DataItemDescriptor<SiegeModeViewModel>("SiegeModeSwitchCancelEnabledFullName",
                tank => tank.SiegeMode, sm => sm.SiegeMode != null ? sm.SiegeMode.SwitchCancelEnabled : false, null, "SiegeModeSwitchCancelEnabledDescription", "{0}", ComparisonMode.NotComparable, 0.0, false);
        }

        public override string ToString()
        {
            if (this.SiegeMode.SwitchCancelEnabled)
                return App.GetLocalizedString("SiegeModeSwitchCancelEnabledYes");
            return App.GetLocalizedString("SiegeModeSwitchCancelEnabledNo");
        }

        public ISiegeMode SiegeMode;

        public SiegeModeViewModel(ISiegeMode siegeMode)
        {
            this.SiegeMode = siegeMode;
        }
    }
}
