namespace Smellyriver.TankInspector.Modeling
{
    internal interface ISiegeMode
    {
        double SwitchOnTime { get; }
        double SwitchOffTime { get; }
        double EngineDamageCoeff { get; }
        double AutoSwitchOnRequiredVehicleSpeed { get; }
        double AutoSwitchOffRequiredVehicleSpeed { get; }
        bool SwitchCancelEnabled { get; }
    }
}
