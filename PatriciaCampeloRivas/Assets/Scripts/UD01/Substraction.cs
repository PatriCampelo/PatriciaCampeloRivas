using UnityEngine;

public class Substraction : MonoBehaviour
{

    [SerializeField]
    private int _numberOne;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the method
        GetSubstraction();
    }

    // Create the method get the rest of te numbers from 1 to the entered number
    private void GetSubstraction()
    {
        for (int i = 1; i <= _numberOne; i++)
        {
     
            Debug.Log(i);

        }
    }
}
