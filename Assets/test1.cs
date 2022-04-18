using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void SayHello(string name)
    {
        Debug.Log("Hello" +name);
    }
        
    void Start()
    {
        SayHello("Tom");
    }
}