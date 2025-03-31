using UnityEngine;

public class Options : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void FullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void ChangeQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
