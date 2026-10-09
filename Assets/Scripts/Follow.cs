using UnityEngine;
using System.Collections;

public class DirectEnemyFollow : MonoBehaviour
{
    public float moveSpeed = 3.5f;
    private Transform playerTransform;

    void Start()
    {
        // Dynamically find the player scene object by its tag
        GameObject player = GameObject.FindWithTag("Player");
        
        if (player != null)
        {
            playerTransform = player.transform;
        }
    }

    void Update()
    {
        if (playerTransform != null)
        {
            // Face the player
            transform.LookAt(playerTransform);

            // Walk straight toward the player
            transform.position = Vector3.MoveTowards(
                transform.position, 
                playerTransform.position, 
                moveSpeed * Time.deltaTime
            );
        }
    }
}

