using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    // Create an array to get the numbers
    [SerializeField]
    private int[] numbersArray = new int[3];


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the method
        IsIncreasingOrder();
    }

    // Create method to know if the numbers are in increasing order
    private void IsIncreasingOrder()
    {
        bool isIncreasing = numbersArray[0] < numbersArray[1] && numbersArray[1] < numbersArray[2];
        Debug.Log("Are the numbers in increasing order? " + isIncreasing);
    }
}
