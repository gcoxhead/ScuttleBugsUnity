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
        _vCams[3].enabled = false;
        _vCams[4].enabled = false;
        _vCams[5].enabled = false;
        _vCams[6].enabled = false;

    }

    public void ViewCamTarget2()
    {
        _vCams[0].enabled = false;
        _vCams[1].enabled = true;
        _vCams[2].enabled = false;
        _vCams[3].enabled = false;
        _vCams[4].enabled = false;
        _vCams[5].enabled = false;
        _vCams[6].enabled = false;
    }

    public void ViewCamTarget3()
    {
        _vCams[0].enabled = false;
        _vCams[1].enabled = false;
        _vCams[2].enabled = true;
        _vCams[3].enabled = false;
        _vCams[4].enabled = false;
        _vCams[5].enabled = false;
        _vCams[6].enabled = false;

    }

    public void ViewCamTarget4()
    {
        _vCams[0].enabled = false;
        _vCams[1].enabled = false;
        _vCams[2].enabled = false;
        _vCams[3].enabled = true;
        _vCams[4].enabled = false;
        _vCams[5].enabled = false;
        _vCams[6].enabled = false;

    }

    public void ViewCamTarget5()
    {
        _vCams[0].enabled = false;
        _vCams[1].enabled = false;
        _vCams[2].enabled = false;
        _vCams[3].enabled = false;
        _vCams[4].enabled = true;
        _vCams[5].enabled = false;
        _vCams[6].enabled = false;
    }

    public void ViewCamTarget6()
    {
        _vCams[0].enabled = false;
        _vCams[1].enabled = false;
        _vCams[2].enabled = false;
        _vCams[3].enabled = false;
        _vCams[4].enabled = false;
        _vCams[5].enabled = true;
        _vCams[6].enabled = false;

    }

    public void ViewCamTarget7()
    {
        _vCams[0].enabled = false;
        _vCams[1].enabled = false;
        _vCams[2].enabled = false;
        _vCams[3].enabled = false;
        _vCams[4].enabled = false;
        _vCams[5].enabled = false;
        _vCams[6].enabled = true;
        _vCams[7].enabled = false;

    }

    public void ViewCamTarget8()
    {
        _vCams[0].enabled = false;
        _vCams[1].enabled = false;
        _vCams[2].enabled = false;
        _vCams[3].enabled = false;
        _vCams[4].enabled = false;
        _vCams[5].enabled = false;
        _vCams[6].enabled = false;
        _vCams[7].enabled = true;
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
            ViewCamTarget3();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            ViewCamTarget4();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            ViewCamTarget5();
        }

        if(Input.GetKeyDown(KeyCode.N))
        {
            ViewCamTarget6();
        }

        if(Input.GetKeyDown(KeyCode.M))
        {
            ViewCamTarget7();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            ViewCamTarget8();
        }
    }
     
}

        


