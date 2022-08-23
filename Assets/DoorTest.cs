using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenDoor(int tempInt) {
        Debug.Log(tempInt+ "开门了");
        
    }
    public void ClosedDoor(string tempStr)
    {
        Debug.Log(tempStr + "关门了");

    }
}
