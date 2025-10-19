using UnityEngine;

public class Logic : MonoBehaviour
{

    private bool[] _arrayOne = {false, false, false};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _arrayOne[0] = true;
        Debug.Log("The value of the first position is: " + _arrayOne[0]);
        Debug.Log("The value of the second position is: " + _arrayOne[1]);
        Debug.Log("The value of the third position is: " + _arrayOne[2]);
    }

   
}
