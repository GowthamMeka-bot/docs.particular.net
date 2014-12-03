﻿using NServiceBus;
using NServiceBus.Features;

public class GatewayConfig
{
    public GatewayConfig()
    {
        #region GatewayConfiguration 5

        var configuration = new BusConfiguration();

        configuration.EnableFeature<Gateway>();

        #endregion

        IBus Bus = null;

        #region SendToSites 5

        Bus.SendToSites(new[] { "SiteA", "SiteB" }, new MyCrossSiteMessage());

        #endregion
    }
    public class MyCrossSiteMessage
    {
    }

}
