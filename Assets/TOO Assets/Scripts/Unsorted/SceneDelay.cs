using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneDelay : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string sceneName)
    {
        StartCoroutine(Switch());
    }   

    public IEnumerator Switch()
    {
        yield return new WaitForSeconds(3.0f);

        SceneManager.LoadScene("MainHub");      
    }       
}
