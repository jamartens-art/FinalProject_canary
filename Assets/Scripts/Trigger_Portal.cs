using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Control scene by touching this collider
/// </summary>
public class Trigger_Portal : MonoBehaviour
{

    public string goToScene;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(123);
        if (collision.gameObject.CompareTag("Player") && goToScene != "")
        {
            SceneManager.LoadScene(goToScene);
        }
    }

}
