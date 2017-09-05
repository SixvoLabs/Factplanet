using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;

public class LoadJson : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string countryData = loadFile(".\\Assets\\factbook.json\\africa\\ag.json");
        Debug.Log(countryData);
        FbJson.Rootobject ag = JsonConvert.DeserializeObject<FbJson.Rootobject>(countryData);

        Debug.Log(ag.Geography.Location.text);
	}
	
    string loadFile(string filepath)
    {
        StreamReader iF = new StreamReader(filepath);
        string data = iF.ReadToEnd();
        iF.Close();

        return data;
    }
}
