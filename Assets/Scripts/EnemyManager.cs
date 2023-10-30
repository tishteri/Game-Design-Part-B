using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyManager : MonoBehaviour
{
    public UnityEvent<GameObject> Crush;
    private AudioSource crushAudio;

    void Awake()
    {
        crushAudio = GetComponent<AudioSource>();
    }

    public void CrushGoomba(GameObject goomba) {
        Crush?.Invoke(goomba);
        crushAudio.PlayOneShot(crushAudio.clip);
    }
}
