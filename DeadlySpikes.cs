using UnityEngine;

public class DeadlySpikes : MonoBehaviour
{
    public Vector3 respawnPoint;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.gameObject.transform.position = respawnPoint;


        }
    }
}
