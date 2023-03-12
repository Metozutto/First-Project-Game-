using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenColse : MonoBehaviour
{
    public Animator Door = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Wyzwalacz"))
        {
            //Door.Play("Door Open", 0, 0.0f);
            Door.SetBool("Door", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Wyzwalacz"))
        {
            //Door.Play("Door Closed", 0, 0.0f);
            Door.SetBool("Door", false);
        }

    }

    private void check(Collider other)
    { 

    }
    
}
