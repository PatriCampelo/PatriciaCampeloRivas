using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RandomPrediction();
    }

    // Update is called once per frame
    private void RandomPrediction()
    {
        string[] _arrayOne = new string[5] { "Get Rich.", "Land a good job.", "Work from home.", "Be famous.", "Become a proplayer." };

        int randomNumber = Random.Range(0, _arrayOne.Length);
        Debug.Log("In the future i will: " + _arrayOne[randomNumber]);

    }
}
