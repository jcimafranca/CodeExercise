﻿using System.Collections.Generic;
using System;

/*
1. Alert Service
Refactor the AlertService and AlertDAO classes:

Create a new interface, named IAlertDAO, that contains the same methods as AlertDAO.
AlertDAO should implement the IAlertDAO interface.
AlertService should have a constructor that accepts IAlertDAO.
The RaiseAlert and GetAlertTime methods should use the object passed through the constructor.

*/

public interface IAlertDAO
{
    Guid AddAlert(DateTime time);

    DateTime GetAlert(Guid id);
}

public class AlertService
{
    private readonly IAlertDAO obj;

    public AlertService(IAlertDAO newObj)
    {
        this.obj = newObj;
    }

    public Guid RaiseAlert()
    {
        return this.obj.AddAlert(DateTime.Now);
    }

    public DateTime GetAlertTime(Guid id)
    {
        return this.obj.GetAlert(id);
    }

}

public class AlertDAO : IAlertDAO
{
    private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

    public Guid AddAlert(DateTime time)
    {
        Guid id = Guid.NewGuid();
        this.alerts.Add(id, time);
        return id;
    }

    public DateTime GetAlert(Guid id)
    {
        return this.alerts[id];
    }
}
