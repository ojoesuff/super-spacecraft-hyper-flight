using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    GameMaster gameMaster;
    //GameObject gameMaster;

    private void Start()
    {
        gameMaster = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
    }
    public void ChangeScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
    public void RestartCurrentScene()
    {
        gameMaster.resetParameters();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
