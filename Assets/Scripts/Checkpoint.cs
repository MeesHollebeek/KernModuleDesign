using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Transform Trigger;
    [SerializeField] private GameObject OBJ;
    [SerializeField] private GameObject Next;





    private int loopCount = 1;

    private void OnTriggerEnter(Collider other)
    {
        

       

        Rigidbody R = Trigger.GetComponent<Rigidbody>();
        if (other.gameObject.tag == "loop")
        {
            BoxCollider BC = other.gameObject.GetComponent<BoxCollider>();
            BC.enabled = true;
            loopCount++;
        }
            if (loopCount == 2)
            {

            Debug.Log("jaa");
            OBJ.SetActive(false);
            Next.SetActive(true);

        }

    }
}
