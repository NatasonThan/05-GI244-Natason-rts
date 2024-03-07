using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Renderer _renderer;
    private int j = 0;
    
    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //Debug.Log($"Fixed loop {++j}: {Time.deltaTime}");
    }

    public void ChangeColor(Color color )
    {
        _renderer.material.color = color;
    }
}
