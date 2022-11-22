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
    Status status;

    [Serializable]
    public class Item
    {
        public int id;
        public string name;
        public int count;
    }
    
    Item[] items;
    string path = "/data.json";
    
    [SerializeField] string json;

    public void InputJson()
    {
        StreamReader reader = new StreamReader(Application.dataPath + path);
        json = reader.ReadToEnd();
    }
}