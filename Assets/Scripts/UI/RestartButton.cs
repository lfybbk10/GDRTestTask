using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RestartButton : MonoBehaviour
{
    private void Awake() => GetComponent<Button>().onClick.AddListener(RestartGame);

    private void RestartGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
