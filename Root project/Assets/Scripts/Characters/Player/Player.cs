using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class Player : MonoBehaviour
{
    [SerializeField] public static Player instance;
    [SerializeField] public LineRenderer lineRenderer;

    private void Start()
    {
        if (Player.instance == null)
        {
            Player.instance = this;
        }
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
