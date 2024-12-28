using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmulateScanManager : MonoBehaviour
{
    [SerializeField]
    private GameObject virtualKeyboard;

    [SerializeField]
    private GameObject virtualScan;

    [SerializeField]
    private AudioSource audioSource;

    public void EmulateScan()
    {
        StartCoroutine(ToggleScanAndKeyboard());
    }

    IEnumerator ToggleScanAndKeyboard()
    {
        audioSource.Play();
        yield return new WaitForSeconds(1f);
        virtualScan.SetActive(false);
        yield return new WaitForSeconds(.5f);
        virtualKeyboard.SetActive(true);
    }

    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
