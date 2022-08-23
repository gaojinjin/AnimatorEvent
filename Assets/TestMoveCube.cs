using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMoveCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColor(int inputInt) {
        Debug.Log(inputInt);
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
