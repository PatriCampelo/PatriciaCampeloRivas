using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the method
        GetEven();
    }

    // Create the method to know if the number is odd
    private void GetEven()
    {
        for (int i = 0; i <= 100; i++)
        {

            if (i % 2 == 0)
            {
                Debug.Log(i);
            }


        }
    }
}
