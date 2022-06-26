using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Transform Trigger;
    [SerializeField] private GameObject OBJ;
    [SerializeField] private GameObject Next;
    [SerializeField] private GameObject score;
    [SerializeField] private GameObject Newscore;
    [SerializeField] private GameObject Hint;
    [SerializeField] private GameObject NewHint;





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
            score.SetActive(false);
            Newscore.SetActive(true);
            Hint.SetActive(false);
            NewHint.SetActive(true);
        }

    }
}
