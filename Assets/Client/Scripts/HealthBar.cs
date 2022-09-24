using UnityEngine.UI;
using UnityEngine;


public class HealthBar : MonoBehaviour
{
    [SerializeField] HealthManager _healthManager;
    [SerializeField] private Image _healthBarFill;


    private void Awake()
    {
        _healthManager.HealthSet += OnHealthChanged;
    }

    private void OnDestroy()
    {
        _healthManager.HealthSet -= OnHealthChanged;
    }

    private void OnHealthChanged(float valueHpPercent)
    {
        _healthBarFill.fillAmount = valueHpPercent;
    }
}
