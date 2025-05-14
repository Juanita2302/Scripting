using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObjectFactory
{
    GameObject CreateObject();
}

public class RedFactory : IObjectFactory
{
    public GameObject CreateObject() => Object.Instantiate(Resources.Load<GameObject>("Cube"));
}

public class GreenFactory : IObjectFactory
{
    public GameObject CreateObject() => Object.Instantiate(Resources.Load<GameObject>("Cylinder"));
}

public class BlueFactory : IObjectFactory
{
    public GameObject CreateObject() => Object.Instantiate(Resources.Load<GameObject>("Sphere"));
}
public class ObjectSpawner
{
    private IObjectFactory currentFactory;

    public void SetFactory(IObjectFactory factory) => currentFactory = factory;
    public void SpawnObject() => currentFactory?.CreateObject();
}
