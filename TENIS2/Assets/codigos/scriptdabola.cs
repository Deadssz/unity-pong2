using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptdabola : MonoBehaviour
{
    private const float velocityIncrement =1.001f;

    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }
    void OnTriggerEnter()
    {
        Reset();
    }
    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity *= velocityIncrement;
    }
    private void Reset()
    {
        int direction = RandomNumber(1,3);
        if (direction.Equals(1))
        {
            transform.position = Vector3.zero;
            GetComponent<Rigidbody>().velocity = new Vector3(30, RandomNumber(500,0),20);

        }
        else
        {
            transform.position = Vector3.zero;
            GetComponent<Rigidbody>().velocity= new Vector3(-30,RandomNumber(-500,0),-20);

        }
    }    
    private int RandomNumber(int min, int max)
        {
            int ret = Random.Range(min,max);
            return ret;
        }
    
}
