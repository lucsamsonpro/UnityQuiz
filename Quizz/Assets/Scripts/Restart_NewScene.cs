using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_NewScene : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("QuizzScene");
            Debug.Log("Restarting quizz");
        }
    }
}
