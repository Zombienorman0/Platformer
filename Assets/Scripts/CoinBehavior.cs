using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour, ICollectable

{
    public int Value => 3;
    public CollectableType type => CollectableType.Money;
    private SpriteRenderer render;
    private Collider2D boundingBox;

    
    public int Collect()
    {
        render.enabled = false;
        boundingBox.enabled = false;
        return Value;
    }
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        boundingBox = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
