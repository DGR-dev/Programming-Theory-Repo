using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI infoField;
    public static GameUI Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(0);
    }

    public void ShowInfo(string info)
    {
        infoField.text = info;
    }
    
}
