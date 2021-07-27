using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().PlayAudio("BackGround");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            AudioManager.instance.StopPlayAudio("BackGround");

            FindObjectOfType<AudioManager>().PlayAudio("Dead");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
