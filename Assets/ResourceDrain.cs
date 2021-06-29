using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceDrain : MonoBehaviour
{
    private Resource m_Resource;
    public string m_ResourceName = "playerWater";
    public float m_DrainSpeed = 1;

    private void Start()
    {
        m_Resource = Resource.Find(m_ResourceName);
    }
    void Update()
    {
        m_Resource.Change(-m_DrainSpeed * Time.deltaTime);
    }
}