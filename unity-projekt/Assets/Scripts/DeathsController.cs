using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeathsController : MonoBehaviour
{

    int numberOfDeaths;
    public Text counterOfDeaths;

    // Start is called before the first frame update
    void Start()
    {
        ResetCounter();
    }

    public void ResetCounter()
    {
        numberOfDeaths = 0;
        counterOfDeaths.text = numberOfDeaths.ToString();
    }

    // Update is called once per frame
    public void IncrementCounter()
    {
        numberOfDeaths++;
        counterOfDeaths.text = numberOfDeaths.ToString();
    }
}