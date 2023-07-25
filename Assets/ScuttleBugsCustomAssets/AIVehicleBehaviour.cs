using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class AIVehicleBehaviour : MonoBehaviour
{
    [SerializeField]
    public NavMeshAgent _AIagent;

    [SerializeField]
    private List<Transform> CheckPointsList;

    [SerializeField]
    private int _checkPointIndex = 0;

    [SerializeField]
    private Transform CheckPoints;


    // Start is called before the first frame update
    void Start()
    {
        //_AIagent = GetComponent<NavMeshAgent>();
        InitializeTrackCheckPoints();
        RaceToNextCheckPoint();

    }

    // Update is called once per frame
    void Update()
    {
        if (_AIagent.remainingDistance <0.2f && !_AIagent.pathPending)
        {
            RaceToNextCheckPoint();
        }
    }

    void InitializeTrackCheckPoints()
    {
        foreach (Transform child in CheckPoints)
        {
            CheckPointsList.Add(child);
        }
    }

    void RaceToNextCheckPoint()
    {
        if (CheckPointsList.Count == 0)
            return;
        _AIagent.destination = CheckPointsList[_checkPointIndex].position;
        _checkPointIndex = (_checkPointIndex + 1 ) % CheckPointsList.Count;


    }
}
