using System;

class RemoteControlCar
{
    int _distanceDriven = 0;
    int _batteryPercentage = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (_batteryPercentage > 0)
        {
            return $"Battery at {_batteryPercentage}%";
        }
        else
        {
            return "Battery empty";
        }
    }

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _distanceDriven += 20;
            _batteryPercentage --;
        }

        DistanceDisplay();
        BatteryDisplay();
    }
}
