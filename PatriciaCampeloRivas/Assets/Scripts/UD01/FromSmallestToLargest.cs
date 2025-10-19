using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
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
        OrderFromSmallestToLargest();
    }

    // Method to order the numbers from smallest to largest
    private void OrderFromSmallestToLargest()
    {
        if (_numberOne < _numberThree && _numberTwo < _numberThree && _numberOne < _numberTwo)
        {
            Debug.Log("Numbers in order from smallest to largest: " + _numberOne + ", " + _numberTwo + ", " + _numberThree);
        }
        else if (_numberOne > _numberTwo && _numberTwo > _numberThree)
        {
            Debug.Log("Numbers in order from smallest to largest: " + _numberThree + ", " + _numberTwo + ", " + _numberOne);
        }
        else if (_numberOne > _numberThree && _numberTwo < _numberThree)
        {
            Debug.Log("Numbers in order from smallest to largest: " + _numberTwo + ", " + _numberThree + ", " + _numberOne);
        }
        else if (_numberTwo > _numberThree && _numberOne < _numberTwo && _numberOne > _numberThree )
        {
            Debug.Log("Numbers in order from smallest to largest: " + _numberThree + ", " + _numberOne + ", " + _numberTwo);
        }
        else if (_numberTwo < _numberThree && _numberOne < _numberThree && _numberOne > _numberTwo)
        {
            Debug.Log("Numbers in order from smallest to largest: " + _numberTwo + ", " + _numberOne + ", " + _numberThree);
        }else
        {
            Debug.Log("Numbers in order from smallest to largest: " + _numberOne+ ", " + _numberThree + ", " + _numberTwo);
        }


        /*private void OrderFromSmallestToLargest()
        {
            int[] numbersArray = { 30, 2, 5 };

            //Use System.Array.Sort to order the numbers from smallest to largest
            System.Array.Sort(numbersArray);
            Debug.Log("Numbers in order from smallest to largest: " + string.Join(", ", numbersArray));
        }*/

    }
}
