using UnityEngine;
using TMPro;
using System.Collections.Concurrent;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private string targetTag = "Finish";

    [SerializeField] private TextMeshProUGUI winText;

    private float curTime = 0f;
    private bool isRunning = true;

    private void Start()
    {
        if (winText != null)
        {
            winText.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            curTime += Time.deltaTime;
            // F2 is to format it up to 2 decimal points
            timerText.text = curTime.ToString("F2") + "s";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            isRunning = false;
            winText.gameObject.SetActive(true);
        }
    }


}
