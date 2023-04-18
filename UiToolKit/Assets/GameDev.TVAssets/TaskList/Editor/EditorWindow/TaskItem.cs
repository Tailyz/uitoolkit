using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

namespace GameDevTv.Tasks
{
    public class TaskItem : VisualElement
    {
        Toggle taskToggle;
        Label taskLable;

        public TaskItem(string taskText)
        {
            VisualTreeAsset original = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(TaskListEditor.path + "TaskItem.uxml");
            this.Add(original.Instantiate());

            taskToggle = this.Q<Toggle>();
            taskLable = this.Q<Label>();
            taskLable.text = taskText;
        }

        public Toggle GetTaskToggle()
        {
            return taskToggle;
        }

        public Label GetTaskLable()
        {
            return taskLable;
        }
    }
}