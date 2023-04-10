using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class VirtualCameraManager : MonoBehaviour
{
    public static VirtualCameraManager instance;
    public CinemachineVirtualCamera[] cams;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        cams = GetComponentsInChildren<CinemachineVirtualCamera>();
    }

    public void SwapCamera(int index)
    {
        foreach (CinemachineVirtualCamera cam in cams)
        {
            cam.Priority = 10;
        }
        cams[index].Priority = 15;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
