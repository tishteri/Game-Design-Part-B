using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HitQuestion : MonoBehaviour
{
    public GameObject coin;
    public GameObject qbox;
    public Sprite staticBoxSprite;
    private bool hit;
    private Animator coinAnimator;
    private Animator qboxAnimator;

    // Start is called before the first frame update
    void Start()
    {
        hit = false;
        coinAnimator = coin.GetComponent<Animator>();
        qboxAnimator = qbox.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && !hit)
        {
            coinAnimator.SetTrigger("BoxHit");
            qboxAnimator.enabled = false;
            hit = true;
            qbox.GetComponent<SpriteRenderer>().sprite = staticBoxSprite;
        } 
    }

}
