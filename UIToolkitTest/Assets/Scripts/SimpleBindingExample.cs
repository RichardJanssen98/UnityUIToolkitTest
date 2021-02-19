using UnityEditor;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using System.Collections;

namespace UIElementsExamples
{
    public class SimpleBindingExample : MonoBehaviour
    {
        Label label;
        Button button;
        Button toggleLabelButton;
        Button topPanelButton;
        Button bottomPanelButton;
        VisualElement listView;
        VisualElement topPanel;
        VisualElement bottomPanel;

        VisualElement rootVisualElement;

        [SerializeField] private VisualTreeAsset textCopy;

        private void OnEnable()
        {
            rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

            label = (Label)rootVisualElement.Query("HelloWorld");
            button = (Button)rootVisualElement.Query("BtnMakeNewText");
            toggleLabelButton = (Button)rootVisualElement.Query("BtnToggleLabel");
            topPanelButton = (Button)rootVisualElement.Query("BtnToggleTop");
            bottomPanelButton = (Button)rootVisualElement.Query("BtnToggleBottom");
            topPanel = rootVisualElement.Query("TopPanel");
            bottomPanel = rootVisualElement.Query("BottomPanel");

            listView = rootVisualElement.Query("listView");
            button.clickable.clickedWithEventInfo += OnCreateNewTextClick;
            toggleLabelButton.clickable.clickedWithEventInfo += OnToggleLabelClick;
            topPanelButton.clickable.clickedWithEventInfo += OnToggleTopPanelClick;
            bottomPanelButton.clickable.clickedWithEventInfo += OnToggleBottomPanelClick;
        }

        private void Update()
        {
            if (label != null)
            {
                if (label.text == "Hello World! From UXML")
                {
                    label.text = "Hello World! From script";
                }
            }
        }

        private void OnCreateNewTextClick(EventBase btn)
        {   
            if (listView != null)
            {
                label.text = "Hello World! From Button";
                listView.Add(textCopy.CloneTree());
            }
        }
        
        private void OnToggleLabelClick(EventBase btn)
        {
            if (label != null)
            {
                if (label.style.display == DisplayStyle.None)
                {
                    label.style.display = DisplayStyle.Flex;
                    label.SetEnabled(true);
                }
                else
                {
                    label.SetEnabled(false);
                    label.style.display = DisplayStyle.None;
                }
            }
        }

        private void OnToggleTopPanelClick(EventBase btn)
        {
            if (topPanel != null)
            {
                if (topPanel.style.display == DisplayStyle.None)
                {
                    topPanel.style.display = DisplayStyle.Flex;
                    topPanel.SetEnabled(true);
                }
                else
                {
                    topPanel.SetEnabled(false);
                    topPanel.style.display = DisplayStyle.None;
                }
            }
        }

        private void OnToggleBottomPanelClick(EventBase btn)
        {
            if (bottomPanel != null)
            {
                if (bottomPanel.style.display == DisplayStyle.None)
                {
                    bottomPanel.style.display = DisplayStyle.Flex;
                    bottomPanel.SetEnabled(true);
                }
                else
                {
                    bottomPanel.SetEnabled(false);
                    bottomPanel.style.display = DisplayStyle.None;
                }
            }
        }
    }
}