using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private void OnMouseDown()
    {
        OnClick();
    }

    public virtual void OnClick()
    {
        Player.instance.MoveToLocation(transform.position);
        lineRenderer.SetPosition(1,transform.position);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Colided");
        if (other.tag == "Player")
        {
            PlayerCollision();
        }
    }

    public virtual void PlayerCollision()
    {
    }

    private void OnEnable()
    {
        Player.eventlineRenderer += Renderer;
    }

    private void OnDisable()
    {
        Player.eventlineRenderer += Renderer;
    }

    private void Renderer(LineRenderer obj)
    {
        lineRenderer = obj;
    }
}