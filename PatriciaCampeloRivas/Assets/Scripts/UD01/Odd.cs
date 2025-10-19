using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the method
        GetOdd();
    }

    // Create the method to know if the number is odd
    private void GetOdd()
    {
        for (int i = 0; i <= 100; i++) 
        {

            if(i % 2 != 0)
            {
                Debug.Log(i);
            }


        }
    } 
}
 