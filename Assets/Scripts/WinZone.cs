using UnityEngine;
using UnityEngine.SceneManagement;

public class WinZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entró: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("GANASTE");
            SceneManager.LoadScene("win");
        }
    }
}