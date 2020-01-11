using System;
using System.Xml;

namespace Smellyriver.TankInspector.Modeling
{
    [Serializable]
    internal class SiegeMode : ISiegeMode, ISectionDeserializable
    {
        private double _switchOnTime;
        public double SwitchOnTime => _switchOnTime;

        private double _switchOffTime;
        public double SwitchOffTime => _switchOffTime;

        private double _engineDamageCoeff;
        public double EngineDamageCoeff => _engineDamageCoeff;

        private double _autoSwitchOnRequiredVehicleSpeed;
        public double AutoSwitchOnRequiredVehicleSpeed => _autoSwitchOnRequiredVehicleSpeed;

        private double _autoSwitchOffRequiredVehicleSpeed;
        public double AutoSwitchOffRequiredVehicleSpeed => _autoSwitchOffRequiredVehicleSpeed;

        private bool _switchCancelEnabled;
        public bool SwitchCancelEnabled => _switchCancelEnabled;

        public SiegeMode()
        {

        }

        public SiegeMode(double switchTimeOn, double switchTimeOff, double engineDamageCoeff, double autoSwitchOnRequiredVehicleSpeed, double autoSwitchOffRequiredVehicleSpeed, bool switchCancelEnabled)
        {
            _switchOnTime = switchTimeOn;
            _switchOffTime = switchTimeOff;
            _engineDamageCoeff = engineDamageCoeff;
            _autoSwitchOnRequiredVehicleSpeed = autoSwitchOnRequiredVehicleSpeed;
            _autoSwitchOffRequiredVehicleSpeed = autoSwitchOffRequiredVehicleSpeed;
            _switchCancelEnabled = switchCancelEnabled;
        }

        public void Deserialize(XmlReader reader)
        {
            SectionDeserializableImpl.Deserialize(this, reader);
        }

        bool ISectionDeserializable.DeserializeSection(string name, XmlReader reader)
        {
            switch (name)
            {
                case "switchOnTime":
                    reader.Read(out _switchOnTime);
                    return true;
                case "switchOffTime":
                    reader.Read(out _switchOffTime);
                    return true;
                case "engineDamageCoeff":
                    reader.Read(out _engineDamageCoeff);
                    return true;
                case "autoSwitchOnRequiredVehicleSpeed":
                    reader.Read(out _autoSwitchOnRequiredVehicleSpeed);
                    return true;
                case "autoSwitchOffRequiredVehicleSpeed":
                    reader.Read(out _autoSwitchOffRequiredVehicleSpeed);
                    return true;
                case "switchCancelEnabled":
                    reader.Read(out _switchCancelEnabled);
                    return true;
                default:
                    return false;
            }
        }


        bool ISectionDeserializable.IsWrapped => false;
    }
}
