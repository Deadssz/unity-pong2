using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class movimentação : MonoBehaviour
{       
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
        Vector3 v;
     if(Input.GetKey(KeyCode.A))
     {

         v.x=0.2f;
         v.z=0.0f;
         v.y=0.0f;

     transform.Translate(v);

     }   

        Vector3 b;
      if(Input.GetKey(KeyCode.D))
      {

          b.x=-0.2f;
          b.z=0.0f;
          b.y=0.0f;

        transform.Translate(b);

      } 

    }
    
}
