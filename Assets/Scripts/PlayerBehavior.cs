using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] private int coinCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow) && Player.transform.position.x < 7.8f)
        {
            transform.Translate(new Vector3(7f * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) && Player.transform.position.x < 7.8f)
        {
            transform.Translate(new Vector3(-7f * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.Space) && Player.transform.position.y < 100f)
        {
            transform.Translate(new Vector3(0, 7f * Time.deltaTime, 0));
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.GetComponent<ICollectable>() != null)
        {
            ICollectable collectable = collision.GetComponent<ICollectable>();
            switch (collectable.type) 
            {
                case CollectableType.None:
                    break;
                case CollectableType.Money:
                    coinCount += collectable.Collect();
                    break;
                case CollectableType.Key:
                    break;
                case CollectableType.Gem:
                    break;
                default:
                    break;
            }

        }

    }
}
