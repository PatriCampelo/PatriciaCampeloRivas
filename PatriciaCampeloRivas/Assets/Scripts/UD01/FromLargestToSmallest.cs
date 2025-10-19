using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    // Create an array to get the numbers
    [SerializeField]
    private int[] numbersArray = new int[3];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the method
        OrderFromLargestToSmallest();
    }

    // Update is called once per frame
    private void OrderFromLargestToSmallest()
    {

        //Use System.Array.Sort to order the numbers from smallest to largest
        System.Array.Sort(numbersArray);
        System.Array.Reverse(numbersArray);

        Debug.Log("Numbers in order from largest to smallest: " + string.Join(", ", numbersArray));
    }
}
