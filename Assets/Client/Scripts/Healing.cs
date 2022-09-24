using Cainos.PixelArtTopDown_Basic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    [SerializeField] private int _healValue;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent(out TopDownCharacterController topDownCharacterController)) 
        {   
            EventManager.CallerHealingPicker(_healValue);
            Destroy(gameObject);
        }
            
    }
}
