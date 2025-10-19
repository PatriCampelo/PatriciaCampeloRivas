using UnityEngine;

public class Week : MonoBehaviour
{
    // Create the variable to get the number you want to know the day of the week
    [SerializeField]
    private int _dayNumber;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetDayOfWeek(_dayNumber);
    }

    // Method to get the name of each day of the week
    private void GetDayOfWeek(int day)
    { 
    
        switch (day) 
        {

            case 1:
                Debug.Log("The number " + day + " corresponds to Monday.");
                break;
            case 2:
                Debug.Log("The number " + day + " corresponds to Tuesday.");
                break;
            case 3:
                Debug.Log("The number " + day + " corresponds to Wednesday.");
                break;
            case 4:
                Debug.Log("The number " + day + " corresponds to Thursday.");
                break;
            case 5:
                Debug.Log("The number " + day + " corresponds to Friday.");
                break;
            case 6:
                Debug.Log("The number " + day + " corresponds to Saturday.");
                break;
            case 7:
                Debug.Log("The number " + day + " corresponds to Sunday.");
                break;
            default:
                Debug.Log("Invalid number");
                break;

        }

    }

}
