using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float maxSpeed = 20;
    public float upSpeed = 35;
    private bool onGroundState = true;
    public float deathImpulse = 40;
    private Rigidbody2D marioBody;
    private SpriteRenderer marioSprite;
    private bool faceRightState = true;
    // for animation
    public Animator marioAnimator;
    public AudioSource marioAudio;
    public AudioSource marioDeathAudio;
    // public MarioActions marioActions;

    [System.NonSerialized]
    public bool alive = true;
    public Transform gameCamera;
    private int collisionLayerMask = (1 << 3) | (1 << 6) | (1 << 7);
    private bool moving = false;
    private bool jumpedState = false;

    public GameManager gameManager;
    public PlayerManager playerManager;

    // Start is called before the first frame update
    void Start()
    {
        // Set to be 30 FPS
        Application.targetFrameRate = 30;
        marioBody = GetComponent<Rigidbody2D>();
        marioSprite = GetComponent<SpriteRenderer>();

        // update animator state
        marioAnimator.SetBool("onGround", onGroundState);

    }

    void Update()
    {
        marioAnimator.SetFloat("xSpeed", Mathf.Abs(marioBody.velocity.x));
    }

    void FlipMarioSprite(int value)
    {
        if (value == -1 && faceRightState)
        {
            faceRightState = false;
            marioSprite.flipX = true;
            if (marioBody.velocity.x > 0.05f)
                marioAnimator.SetTrigger("onSkid");
        } else if (value == 1 && !faceRightState) 
        {
            faceRightState = true;
            marioSprite.flipX = false;
            if (marioBody.velocity.x < -0.05f)
                marioAnimator.SetTrigger("onSkid");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (((collisionLayerMask & (1 << col.transform.gameObject.layer)) > 0) && !onGroundState)
        {
            onGroundState = true;
            // updating animator state
            marioAnimator.SetBool("onGround", onGroundState);
        }
    }

    // Game over condition
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemies") && alive)
        {
            float eps = 0.3f;
            if ((other.transform.position.y + other.bounds.size.y - eps) < transform.position.y)
            {
                // crush
                FindObjectOfType<EnemyManager>().CrushGoomba(other.gameObject);
                gameManager.IncreaseScore(1);
                marioBody.AddForce(Vector2.up * 25, ForceMode2D.Impulse);
            }
            else 
            {
                playerManager.MarioKilled();
                // play death animation
                alive = false;
                marioAnimator.Play("Mario-die");
                marioDeathAudio.PlayOneShot(marioDeathAudio.clip);
            }
        }
    }

    // FixedUpdate is called 50 times a second
    void FixedUpdate()
    {
        if (alive && moving)
        {
            Move(faceRightState == true ? 1 : -1);
        }
    }

    void Move(int value)
    {
        Vector2 movement = new Vector2(value, 0);
        // check maxSpeed
        if (marioBody.velocity.magnitude < maxSpeed)
            marioBody.AddForce(movement * speed);
    }

    public void MoveCheck(int value)
    {
        if (value == 0) moving = false;
        else 
        {
            FlipMarioSprite(value);
            moving = true;
            Move(value);
        }
    }

    public void Jump()
    {
        if (alive && onGroundState)
        {
            // jump
            marioBody.AddForce(Vector2.up * upSpeed, ForceMode2D.Impulse);
            onGroundState = false;
            jumpedState = true;
            // update animator state
            marioAnimator.SetBool("onGround", onGroundState);
        }
    }

    public void JumpHold()
    {
        if (alive && jumpedState)
        {
            // jump higher
            marioBody.AddForce(Vector2.up * upSpeed, ForceMode2D.Impulse);
            jumpedState = false;
        }
    }

    public void GameRestart()
    {
        // reset mario position
        marioBody.transform.position = new Vector3(-6.59f, -2.78f, 0.0f);
        // reset sprite direction
        faceRightState = true;
        marioSprite.flipX = false;

        marioAnimator.SetTrigger("gameRestart");
        alive = true;

        // reset camera position
        gameCamera.position = new Vector3(0, 0, -10);

        // Reload entire scene
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }
    
    private void GameOver() 
    {
        gameManager.GameOver();
    }
    void PlayJumpSound()
    {
        marioAudio.PlayOneShot(marioAudio.clip);
    }

    void PlayDeathImpulse()
    {
        marioBody.AddForce(Vector2.up * deathImpulse, ForceMode2D.Impulse);
    }
}
