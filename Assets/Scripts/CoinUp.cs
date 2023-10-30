using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinUp : MonoBehaviour
{
    private AudioSource coinSource;
    private Animator coinAnimator;
    public Rigidbody2D qboxBody;

    // Start is called before the first frame update
    void Start()
    {
        
        coinSource = GetComponent<AudioSource>();
        coinAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisableQbox()
    {
        qboxBody.bodyType = RigidbodyType2D.Static;
    }

    void BackInBox()
    {
        coinSource.PlayOneShot(coinSource.clip);
        coinAnimator.SetTrigger("CoinReturn");
    }

}
