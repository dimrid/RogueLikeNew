using UnityEngine.UI;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private int _currentHealth;
    [SerializeField] private Image _bar;
    [SerializeField] private float _fill = 1f;

    private int _maxHealth = 10;

    public void HurtPlayer(int damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
        if ( _currentHealth < _maxHealth)
        {
            _fill -= 0.1f;
            _bar.fillAmount = _fill;
        }
    }   

}
