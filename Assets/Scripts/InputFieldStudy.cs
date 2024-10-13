using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFieldStudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change()
    {
        Debug.Log("Changed Called");
    }

    public void Select()
    {
        Debug.Log("Select");
    }

    public void DeSelect()
    {
        Debug.Log("DeSelect");
    }

    public void End()
    {
        Debug.Log("End Pushed");
    }
}
