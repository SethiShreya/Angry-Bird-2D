using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject[] birds;
    private int playerCount=0;
    
    
    public void IncreaseCount()
    {
        playerCount++;
        //Debug.Log("take position method called");
        StartCoroutine(TakePosition());
    }
    IEnumerator TakePosition()
    {
        yield return new WaitForSeconds(.15f);
        //Debug.Log("player made");

        if (playerCount < 3)
        {
        var currentBird = birds[playerCount];
        currentBird.transform.position = transform.position;
        currentBird.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        currentBird.GetComponent<SpringJoint2D>().enabled = true;
        }

    }

}
