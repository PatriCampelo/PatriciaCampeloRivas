using UnityEngine;

public class Shop : MonoBehaviour
{
    // Create the variables for the initial amount of broccoli and potatoes
    [SerializeField]
    private int _broccoli;
    [SerializeField]
    private int _potatoes;

    // Crate the variables where the user decides which amount to add or substract
    [SerializeField]
    private int _addBroccoli;
    [SerializeField]
    private int _substractBroccoli;
    [SerializeField]
    private int _addPotatoes;
    [SerializeField]
    private int _substractPotatoes;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the methhod to add and substract Broccoli and Potatoes
        _broccoli = AddProduct(_broccoli, _addBroccoli);
        _broccoli = SubstractProduct(_broccoli, _substractBroccoli);
        _potatoes = AddProduct(_potatoes, _addPotatoes);
        _potatoes = SubstractProduct(_potatoes, _substractPotatoes);

        // Print the total amount of Broccoli and Potatoes
        Debug.Log("The final aount of Broccoli is: " + _broccoli);
        Debug.Log("The final aount of Potatoes is: " + _potatoes);
    }

    // Create the methos to add and substract product
    private int AddProduct(int actualAmount, int amount)
    {
        actualAmount += amount;
        return actualAmount;
    }

    private int SubstractProduct(int actualAmount, int amount)
    {
        actualAmount -= amount;
        return actualAmount;
    }
}
