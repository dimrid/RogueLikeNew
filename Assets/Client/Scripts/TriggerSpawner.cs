using Cainos.PixelArtTopDown_Basic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawner : MonoBehaviour
{
    [SerializeField] private Spawn _spawn;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out TopDownCharacterController topDownCharacterController))
        {
            _spawn.SpawnObject();
        }

    }
}
