using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetter : MonoBehaviour
{
    [SerializeField]
    private Test obgToChangeColor;
    // Start is called before the first frame update
    void Start()
    {
        obgToChangeColor.ChangeColor(Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
