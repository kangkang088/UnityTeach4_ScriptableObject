using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObj : MonoBehaviour
{
    public ItemEffect effect;
    private void OnTriggerEnter(Collider other) {
        effect.AddEffect(other.gameObject);
    }
}
