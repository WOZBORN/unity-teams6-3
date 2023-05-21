using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FORTEST : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GreetEveryThreeSeconds());
    }

    IEnumerator GreetEveryThreeSeconds()
    {
        while (true)
        {
           print("Привет!");
            yield return new WaitForSeconds(3f);
        }
    }
}
