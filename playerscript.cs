using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
     public GameObject rightPosition,leftPosition;
     bool changePosition;
    void Start()
    {
        
    }

   
    void Update()
    {   
       if (changePosition == true)
       {
           transform.position= new Vector3(rightPosition.transform.position.x,transform.position.y,transform.position.z);
       }
         if (changePosition == false)
       {
           transform.position= new Vector3(leftPosition.transform.position.x,transform.position.y,transform.position.z);
       }
  


        if(Input.GetMouseButtonDown(0))
        {
          if(changePosition==false)
          {
              changePosition = true;
            }  
            else if (changePosition==true)
            {
                changePosition = false;

            }
        }
    }
    private void OnTriggerEnter(Collider other)
 {
     if (other.tag =="wall")
     {
         transform.gameObject.SetActive(false);
        // for(int i=0; i<17; i++)
        // {
          //   Instantiate(deadPrefab, transform.position, Quaternion.identity);
        // }
     }
     
 }
}


