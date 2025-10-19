using UnityEngine;

public class Change : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeArray();
    }

    // Update is called once per frame
    private void ChangeArray()
    {
        int[] _arrayOne = new int [5]{ 1, 1, 1, 1, 1 };

        Debug.Log("The length on this array is: " + _arrayOne.Length);
        
        _arrayOne[0] = 42;
        _arrayOne[4] = 42;

        Debug.Log("The value of the first position is: " + _arrayOne[0]);
        Debug.Log("The value of the second position is: " + _arrayOne[1]);
        Debug.Log("The value of the third position is: " + _arrayOne[2]);
        Debug.Log("The value of the fourth position is: " + _arrayOne[3]);
        Debug.Log("The value of the fifth position is: " + _arrayOne[4]);
    }
}
