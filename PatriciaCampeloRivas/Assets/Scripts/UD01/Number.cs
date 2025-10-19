using UnityEngine;

public class Number : MonoBehaviour
{
    // Create variable to get the number
    public int NumberOne;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call and print the method
        Debug.Log(AddOneToNumber(NumberOne));
    }

    // Create the method to add 1 to de entered number
    private int AddOneToNumber(int number)
    {
        return ++number;
    }
}
