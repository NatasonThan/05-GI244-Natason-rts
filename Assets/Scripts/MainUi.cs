using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUi : MonoBehaviour
{
    [SerializeField] 
    private GameObject selectionMarker;
    public GameObject SelectionMarker
    {
        get { return selectionMarker; }
    }
    public static MainUi instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
