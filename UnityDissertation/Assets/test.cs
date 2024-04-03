using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class test : MonoBehaviour
{
    public GameObject moveableObject;

    // Start is called before the first frame update
    void Start()
    {
        moveableObject.SetActive(false);
        Debug.Log("Basically a Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
