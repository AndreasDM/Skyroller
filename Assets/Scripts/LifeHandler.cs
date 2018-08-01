using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHandler : MonoBehaviour {

    public GameObject[] lives;
    private AudioSource audioData;
    private int hitTimes = 0;

    private void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    void Update () {
        
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("obstacle"))
        {
            ++hitTimes;
            if (hitTimes < 3)
            {
                lives[hitTimes - 1].SetActive(false);
                // play sound
                audioData.Play();
            }
            else if (hitTimes == 3)
            {
                lives[hitTimes - 1].SetActive(false);
                audioData.Play();
                FindObjectOfType<GameManager>().GameOver();
            }
        }
    }
}
