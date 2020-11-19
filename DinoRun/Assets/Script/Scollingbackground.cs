﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scollingbackground : MonoBehaviour
{

    [SerializeField] float backgroundspeed = 0.5f;
    Material myMaterial;
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        offset = new Vector2(backgroundspeed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        myMaterial.mainTextureOffset += offset * Time.deltaTime;
    }
}
