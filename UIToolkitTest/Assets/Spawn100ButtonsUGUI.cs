using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn100ButtonsUGUI : MonoBehaviour
{
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject buttonParent;

    // Start is called before the first frame update
    void Start()
    {
        Transform transform = buttonParent.transform;
        for (int i = 0; i < 100; i++)
        {
            Instantiate(buttonPrefab, transform);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            panel.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            panel.SetActive(true);
        }
    }
}
