using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the method
        GetMultiplesOfThree();
    }

    // Create the method to know the multiples of three
    private void GetMultiplesOfThree()
    {
        for (int i = 0; i <= 100; i++) 
        {

            if (i % 3 == 0)
            {

                Debug.Log(i);

            }

        }
    }
}
