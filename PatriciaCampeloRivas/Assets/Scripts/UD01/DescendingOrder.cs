using UnityEngine;

public class DescendingOrder : MonoBehaviour
{

    // Crate the variables to get the 3 numbers
    [SerializeField]
    private int _numberOne;
    [SerializeField]
    private int _numberTwo;
    [SerializeField]
    private int _numberThree;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the method
        IsDescendingOrder();
    }

    // Create the method to know if the number are in a descending order
    private void IsDescendingOrder()
    {
        if(_numberOne >_numberTwo && _numberTwo > _numberThree)
        {
            Debug.Log("The numbers are in a descending order.");
        }
        else
        {
            Debug.Log("The numbers are not in a descending order.");
        }
    }
}
