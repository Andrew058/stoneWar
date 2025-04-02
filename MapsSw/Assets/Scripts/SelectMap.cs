using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMap : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayForest()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void PlayLava()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
