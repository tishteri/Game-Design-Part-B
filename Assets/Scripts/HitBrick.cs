using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBrick : MonoBehaviour
{
    public Animator coinAnimator;
    private Animator brickAnimator;
    private bool coinReleased;
    // Start is called before the first frame update
    void Start()
    {
        brickAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            brickAnimator.Play("bounce");
            if (coinAnimator && !coinReleased) {
                coinAnimator.SetTrigger("BoxHit");
                coinReleased = true;
            }
            brickAnimator.SetBool("hit", true);
        }
    }

}
