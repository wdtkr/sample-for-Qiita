using System;
using System.IO;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    [Serializable]
    public class Status
    {
        public int hp;
        public int power;
    }
    
    [Serializable]
    public class Item
    {
        public int id;
        public string name;
        public int count;
    }
    
    [Serializable]
    public class Data
    {
        public Status status;
        public Item[] items;
    }

    Data data = new Data();
    
    string path = "/data.json";
    
    [SerializeField][Multiline] string json;

    public void InputJson()
    {
        StreamReader reader = new StreamReader(Application.dataPath + path);
        json = reader.ReadToEnd();
        data = JsonUtility.FromJson<Data>(json);
        Debug.Log(data.status.hp);
    }
}