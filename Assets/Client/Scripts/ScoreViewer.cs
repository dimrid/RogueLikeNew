using UnityEngine;
using UnityEngine.UI;

public class ScoreViewer : MonoBehaviour
{
    [SerializeField] private string _tempHeal;
    private Text _scoreText;

    private void Awake()
    {
         _scoreText = GetComponent<Text>();
    }

    public void SetScoreHeal(int value)
    {
        _scoreText.text = string.Format(_tempHeal, value);
    }
}
