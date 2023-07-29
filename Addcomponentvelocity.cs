using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addcomponentvelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
	
	void FixedUpdate ()
    {
        GetComponent<Rigidbody>().velocity += v3Force;
	}
}