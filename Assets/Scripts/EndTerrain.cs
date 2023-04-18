using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTerrain : MonoBehaviour
{
    private void onTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}
