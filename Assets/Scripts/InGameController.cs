using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameController : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private void Start()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            SceneManager.LoadScene("MainMenu");

        if (_playerTransform.position.y > 390)
            SceneManager.LoadScene("Win");
    }
}
