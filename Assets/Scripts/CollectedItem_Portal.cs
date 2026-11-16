using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectedItem_Portal : MonoBehaviour
{

    [Tooltip("Scene to go to (must be in File > Build Profiles > Scene List)")]
    public string goToScene;

    [Tooltip("The name of the item required (must match!!)")]
    public string itemRequired;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (
                collision.gameObject.GetComponent<CollectObject>().collection.Contains(itemRequired)
            )
                GoToScene();
        }
    }

    void GoToScene()
    {
        if (goToScene != "")
        {
            SceneManager.LoadScene(goToScene);
        }
    }
}
