using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    [SerializeField] Transform PlayerStartingSpawn;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            StartCoroutine(WaitForRespawn(collision));
        }

    }

    IEnumerator WaitForRespawn(Collider2D collider)
    {
        yield return new WaitForSeconds(1);
        collider.attachedRigidbody.transform.position = PlayerStartingSpawn.position;
    }
}
