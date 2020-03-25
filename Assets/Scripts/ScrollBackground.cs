using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    //Script from "Unity 2D Infinite Scrolling Background (For Endless Runner Games) - 2018" by Charger Games on Youtube.
    private Material backgroundMaterial;
    private Vector2 offset;
    [SerializeField] private float xSpeed;

    private void Awake() 
    {
        backgroundMaterial = GetComponent<Renderer>().material;
    }

    private void Start()
    {
        offset = new Vector2(xSpeed,0);
    }

    private void Update()
    {
        backgroundMaterial.mainTextureOffset += offset*Time.deltaTime;
    }
}
