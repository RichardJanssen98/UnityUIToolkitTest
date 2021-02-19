using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawn100ButtonsUIToolkit : MonoBehaviour
{
    [SerializeField] private VisualTreeAsset ButtonPrefab;

    VisualElement buttonParent;
    VisualElement rootVisualElement;
    VisualElement panel;

    // Start is called before the first frame update
    void OnEnable()
    {
        rootVisualElement = GetComponent<UIDocument>().rootVisualElement;
        buttonParent = rootVisualElement.Query("ButtonParent");
        panel = rootVisualElement.Query("Panel");

        for (int i = 0; i < 100; i++)
        {
            buttonParent.Add(ButtonPrefab.CloneTree());
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            panel.style.display = DisplayStyle.None;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            panel.style.display = DisplayStyle.Flex;
        }
    }
}
