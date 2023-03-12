using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OblectMovement : MonoBehaviour
{
    //Poruszanie przedmiotów graczem
    //Interakcje gracz przedmiot(przesuwanie kostki)
    [SerializeField]
    private float Objectmovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;
        if (rigidbody != null)
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();
            rigidbody.AddForceAtPosition(forceDirection * Objectmovement, transform.position, ForceMode.Impulse);
        }
    }
}
