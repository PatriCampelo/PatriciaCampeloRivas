using UnityEngine;

public class Score : MonoBehaviour
{
    // Create the variable to enter the player score
    [SerializeField] 
    private int _playerScore;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the method to know if the player reached the score
        CheckScore(_playerScore);
    }

    // Create the method to check the player score
    private void CheckScore(int score)
    {
        if (score >= 45)
        {
            Debug.Log("Congrats! You made it.");
        }
        else
        {
            Debug.Log("Sorry :( You did not reach the necessary score.");
        }

    }
}
