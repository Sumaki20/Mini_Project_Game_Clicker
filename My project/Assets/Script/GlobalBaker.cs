using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakerValue = 50;
    public static bool turnOffButton = false;
    public GameObject bakerStats;
    public static int numberOfBakers;
    public static int bakePerSec;

    void Start()
    {
        
    }

    void Update()
    {
        currentCash = GlobalCash.CashCount;
        bakerStats.GetComponent<Text>().text = "AutoAttack: " + numberOfBakers + " @ " + bakePerSec + " Per Seconds ";
        fakeText.GetComponent<Text>().text = "Buy AutoAttack - $" + bakerValue;
        realText.GetComponent<Text>().text = "Buy AutoAttack - $" + bakerValue;
        
        if (currentCash >= bakerValue)
        {
            realButton.GetComponent<Button>().interactable = true;
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        
        else if (currentCash <= bakerValue)
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
