﻿using DotRas.Devices;
using DotRas.Internal.Abstractions.Factories;

namespace DotRas.Internal.IoC.Factories.Devices
{
    internal class SerialDeviceFactory : IDeviceFactory
    {
        public RasDevice Create(string name)
        {
            return new Serial(name);
        }
    }
}