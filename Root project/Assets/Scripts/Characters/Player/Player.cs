using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class Player : MonoBehaviour
{
    [SerializeField] public static Player instance;
    [SerializeField] public LineRenderer lineRenderer;
    private int moveNumb;
    private bool firstMove;
    public float wholeFoodsEaten;
    public float spentFoods;
/*    private int animationStep;
    private float fps = 30;
    private float fpsCounter;
    [SerializeField] Texture[] textures;*/
    private void Start()
    {
        if (Player.instance == null)
        {
            Player.instance = this;
        }
    }

/*    private void Update()
    {
        fpsCounter += Time.deltaTime;
        if(fpsCounter >= 1f / fps)
        {
            animationStep++;
            if(animationStep == textures.Length)
            {
                animationStep = 0;
            }
            lineRenderer.material.SetTexture("_MainTex", textures[animationStep]);
            fpsCounter = 0;
        }
    }*/

    public void MoveToLocation(Vector3 endLocation)
    {
        if (Vector3.Distance(transform.position, endLocation) <= 1.5f && wholeFoodsEaten - spentFoods >= 1)
        {
            print("Player Move");
            transform.DOMove(endLocation, 1);
            if (!firstMove)
            {
                lineRenderer.positionCount += 2;
                lineRenderer.SetPosition(moveNumb, transform.position);
                firstMove = true;
            }
            else
            {
                lineRenderer.positionCount += 1;
            }
            lineRenderer.SetPosition(moveNumb + 1, endLocation);
            moveNumb++;
            spentFoods++;
        }
        else
        {
            print("NO NO");
        }
    }
}
