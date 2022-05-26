using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] GameObject door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(door);
        Destroy(this.gameObject);
    }
}
