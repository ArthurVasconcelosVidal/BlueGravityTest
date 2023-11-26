using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour{
    [SerializeField] GameObject roofShop;
    [SerializeField] bool open;

    void OnTriggerEnter2D(Collider2D other) {
        roofShop.SetActive(open);
    }
}
