using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{

    int numberOfCoins;
    public Text counterView;

    // Start is called before the first frame update
    void Start()
    {
        ResetCounter();
    }

    public void ResetCounter()
    {
        numberOfCoins = 0;
        counterView.text = numberOfCoins.ToString();
    }

    // Update is called once per frame
    public void IncrementCounter()
    { 
        numberOfCoins++;
        counterView.text = numberOfCoins.ToString();
    }
}
