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
    
    string json;

    [SerializeField] Status inputStatus;
    [SerializeField] Item[] inputItems;
    
    [SerializeField][Multiline] string output;

    public void LoadJson()
    {
        json = File.ReadAllText(Application.dataPath + path);
        data = JsonUtility.FromJson<Data>(json);
        
        inputStatus = data.status;
        inputItems = data.items;
    }

    public void UpdateJson()
    {
        data.status = inputStatus;
        data.items = inputItems;

        output = JsonUtility.ToJson(data,true);
        
        File.WriteAllText(Application.dataPath + path, output);
    }
}