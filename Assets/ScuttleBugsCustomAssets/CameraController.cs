using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera[] _vCams;
    
    void Start()
    {
        ViewCamTarget1();
    }

  public void ViewCamTarget1()
    {
        _vCams[0].enabled = true;
        _vCams[1].enabled = false;
        _vCams[2].enabled = false;
         
    }

    public void ViewCamTarget2()
    {
        _vCams[0].enabled = false;
        _vCams[1].enabled = true;
        _vCams[2].enabled = false;
        
    }

    public void ViewCamTarget3()
    {
        _vCams[0].enabled = false;
        _vCams[1].enabled = false;
        _vCams[2].enabled = true;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ViewCamTarget1();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            ViewCamTarget2();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ViewCamTarget2();
        }

    }
     
}

        


