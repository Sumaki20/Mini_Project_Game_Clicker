using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int shopValue = 50;
    public static bool turnOffButton = false;
    public GameObject shopStats;
    public static int numberOfShop;
    public static int shopPerSec;


    void Update()
    {
        currentCash = GlobalCash.CashCount;
        shopStats.GetComponent<Text>().text = "Shops: " + numberOfShop + " @ " + shopPerSec + " Per Seconds ";
        fakeText.GetComponent<Text>().text = "Buy AutoSell - $" + shopValue;
        realText.GetComponent<Text>().text = "Buy AutoSell - $" + shopValue;
        if (currentCash >= shopValue)
        {
            realButton.GetComponent<Button>().interactable = true;
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else if (currentCash <= shopValue)
        {
            realButton.GetComponent<Button>().interactable = false;
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
