﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRing : MonoBehaviour
{
    public GameObject item;
    public float radius;
    public int numberofitems;
    public float speed;
    public bool clockwise;
    // Start is called before the first frame update
    void Start()
    {
        float d = 2 * Mathf.PI / numberofitems;
        for(int i = 0; i < numberofitems; i++)
        {
            GameObject a = Instantiate(item, transform);
            a.transform.localPosition = new Vector3(Mathf.Sin(d*i),0,Mathf.Cos(d*i))*radius;
            a.transform.rotation = Quaternion.Euler(0,360/numberofitems*i,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, clockwise?Time.deltaTime*speed: Time.deltaTime * -speed, 0);
        if (transform.childCount == 0) Destroy(this.gameObject);
    }
}
