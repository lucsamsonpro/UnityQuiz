using UnityEngine;

public class testGameEnd : MonoBehaviour
{
    public GameEnd gameend;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameend.nbrRightAnswers++;
            Debug.Log("NbrRightAnswers +1");
        }
    }
}
