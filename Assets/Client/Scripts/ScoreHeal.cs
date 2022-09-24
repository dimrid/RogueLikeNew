using UnityEngine;

public class ScoreHeal : MonoBehaviour
{
    private int _score;
    [SerializeField] ScoreViewer _scoreViewer;

    private void Awake()
    {
        EventManager.HealingPickedUp.AddListener(Increase);
    }

    private void Start()
    {
        _score = 0;
    }

    private void Increase(int value)
    {
        _score += value;
        _scoreViewer.SetScoreHeal(_score);
    }
}
