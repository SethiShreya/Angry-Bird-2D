using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BirdBehaviour: MonoBehaviour
{
    private Rigidbody2D rb;
    private SpringJoint2D springJoint;
    private bool isPressed = false;
    public float destroyTime = 5;
    public PlayerManager playerManager;
    public Rigidbody2D hook;
    public float maxDragDistance = 2f;
    public float forceval = 10f;
    public GameManager gameManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        springJoint = GetComponent<SpringJoint2D>();
    }

    private void Update()
    {
        if (isPressed)
        {
            Vector2 mousePos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector3.Distance(mousePos, hook.position) > maxDragDistance)
            {
                rb.position = hook.position + (mousePos - hook.position).normalized * maxDragDistance;
            }
            else
            {
                rb.position = mousePos;
            }
        }
    }

    private void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }

    private void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());
    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(.15f);
        springJoint.enabled = false;
        rb.AddForce(transform.right * forceval);

        Destroy(this.gameObject, destroyTime);
        
        yield return new WaitForSeconds(2);
        if (playerManager)
        {
        playerManager.IncreaseCount();
            //Debug.Log("player count method called");
        }

        yield return new WaitForSeconds(destroyTime - 3);
        gameManager.DecreasePlayerCount();
    }
}
