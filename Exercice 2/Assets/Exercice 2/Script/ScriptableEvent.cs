using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_ScriptableEvent", menuName = "Project/ScriptableEvent")]
public class ScriptableEvent : ScriptableObject
{
    public Action PlaySoundAction;
}
