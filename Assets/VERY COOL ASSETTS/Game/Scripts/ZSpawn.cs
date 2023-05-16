using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ZSpawn : MonoBehaviour
{
    [SerializeField] GameObject Zombak;
    [SerializeField] Transform ZombakSpawnisa;
    //[SerializeField] float YaHdy = 0.0f;
    //float Range = 0.0f;
    //[SerializeField] int MaxZ = 5;
    //int TotalZ = 0;
    IEnumerator CloneZ()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            GameObject Zombakdva = Instantiate(Zombak, ZombakSpawnisa.position, ZombakSpawnisa.transform.rotation);
            
        }
    }   
    void Start()
    {
        StartCoroutine(CloneZ());
    }

    
}

