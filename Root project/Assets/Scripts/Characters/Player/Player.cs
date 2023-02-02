using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class Player : MonoBehaviour
{
    [SerializeField] public static Player instance;
    [SerializeField] public LineRenderer lineRenderer;
    public static event Action<LineRenderer> eventlineRenderer;
        

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0,transform.position);
        lineRenderer.Simplify(5);
        lineRenderer.positionCount++;

    }

    private void Start()
    {
        if (Player.instance == null)
        {
            Player.instance = this;
        }
    }

    public void DrawLine()
    {
        eventlineRenderer?.Invoke(lineRenderer);
    }
    public float haveFoods;

    public void MoveToLocation(Vector3 endLocation)
    {
        if(Vector3.Distance(transform.position, endLocation) <= haveFoods)
        {
            print("Player Move");
            transform.DOMove(endLocation, 1);
        }
        else
        {
            print("NO NO");
        }
    }

   
}
