using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    public string sceneName;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;



    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            completeLevelUI.SetActive(true);
            StartCoroutine(LoadScene());
        }

    }




    IEnumerator LoadScene()
    {

        yield return new WaitForSeconds(2f);
        int nextBuildIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextBuildIndex);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name + 1);
        //SceneManager.LoadScene(sceneName);
       // Debug.Log("2e scene!");
        Invoke("Restart", restartDelay);

    }



}
