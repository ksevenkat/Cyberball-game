using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Addplayercontrollervelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode keypositive;
    [SerializeField]
    KeyCode keynegative;
	
	void FixedUpdate ()
    {   if(Input.GetKey(keypositive))
           GetComponent<Rigidbody>().velocity += v3Force;
        if(Input.GetKey(keynegative))
             GetComponent<Rigidbody>().velocity -= v3Force;
	}
}
