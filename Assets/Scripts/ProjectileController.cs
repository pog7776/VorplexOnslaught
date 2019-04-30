﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    private float lifeTime = 10;

    //[SerializeField] private float damage = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeTime > 0) {
            lifeTime -= Time.deltaTime;
        }
        else {
            Destroy(gameObject);
        }
    }
}
