using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the method
        GetMultiplesOfThreeTwo();
    }

    // Create the method to know the multiples of three
    private void GetMultiplesOfThreeTwo()
    {
        for (int i = 0; i <= 100; i++)
        {

            if (i % 2 == 0 && i % 3 == 0)
            {

                Debug.Log(i);

            }

        }
    }
}
