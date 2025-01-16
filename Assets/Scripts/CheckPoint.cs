using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    PlayerMovement playerMovement;
    Animator flagAnimator;

    private void Awake()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        flagAnimator = GetComponent<Animator>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            flagAnimator.SetBool("isActive", true);
        }
    }


    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerMovement.UpdateCheckpoint(transform.position);
            Debug.Log("player checkpoint!");
        }
    }
}
