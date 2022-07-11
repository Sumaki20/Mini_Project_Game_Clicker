using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public GameObject textBox;
    public AudioSource cookiesSound;

    public void ClickTheButton ()
    {
        cookiesSound.Play();
        GlobalCookies.CookieCount += 10;
    }

}