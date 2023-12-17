using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "NewSoundObject", menuName = "Custom/SoundObject")]
[CreateAssetMenu(fileName = "NewSoundObject", menuName = "Custom/SoundObject")]
public class SoundObject : ScriptableObject
{

    public List<AudioClipData> dangerousClips = new List<AudioClipData>();
    public List<AudioClipData> friendlyClips = new List<AudioClipData>();
    public List<AudioClipData> neutralClips = new List<AudioClipData>();

    public AudioContentType audioContentType;
    public List<AudioClipData> audioClips = new List<AudioClipData>();
    public string id;
    public string textField;
    public bool showList;
    public bool showTextField;
    public float volume;

    public void ShowList()
    {
        showList = true;
        showTextField = false;
    }

    public void ShowTextField()
    {
        showList = false;
        showTextField = true;
    }

    public void HideAll()
    {
        showList = false;
        showTextField = false;
    }
}
public enum AudioContentType
{
    Dangerous,
    Friendly,
    Neutral
}






