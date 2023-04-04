using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultManager : MonoBehaviour
{
    [SerializeField]
    private Transform middle;
    [SerializeField]
    private Transform left;
    [SerializeField]
    private Transform right;

    [SerializeField]
    private LineRenderer lineRenderer;
    
    void Awake()
    {
        lineRenderer.positionCount = 2;
    }

    
    void Start()
    {
        Debug.Log("Line created");
        lineRenderer.SetPosition(0, left.position);
        lineRenderer.SetPosition(1, middle.position);
    }
}
