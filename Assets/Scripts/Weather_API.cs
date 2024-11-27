using UnityEngine;
using System;
using System.Collections;
using System.Text.RegularExpressions;
using UnityEngine.Networking;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Weather_API : MonoBehaviour
{
	string JSON_Name;
	string JSON_Country;
	string JSON_Time;
	string JSON_Temperature;
	public string JSON_Weather;
	string path;
	string Url;
	float temperature;
	public int StateWeather;
	public Text Temperature_Text;




	string Zero;
	WWW www;
	string url = "https://api.weatherapi.com/v1/current.json?key=bc19213965f84ece9b4181511230505&q=Copenhagen&aqi=no";
   
	void Start() // Use this for initialization
    {
		www = new WWW(url);
		StartCoroutine(WaitForRequest(www));



    }

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null)
		{
			string work = www.text;
			_Particle fields = JsonUtility.FromJson<_Particle>(work);
			JSON_Name = fields.location.name;
			JSON_Country = fields.location.country;
			JSON_Time =fields.location.localtime;
			JSON_Weather = fields.current.condition.text;
			JSON_Temperature = fields.current.temp_c;
			temperature = float.Parse (JSON_Temperature);
			Debug.Log (JSON_Name);
			Debug.Log (JSON_Country);
			Debug.Log(JSON_Time);
			Debug.Log (JSON_Weather);
			Debug.Log (JSON_Temperature);
		} else {

		}    
	}

    // Update is called once per frame
    void Update()
    {
		if (Time.frameCount % 10 == 0)
		{
				if (temperature < 10.0f) {
					Temperature_Text.text = temperature.ToString("f0").Substring(0, 1)+"° C " + ", "+ JSON_Weather + " in \n " + JSON_Name + ",\n " + JSON_Country + "\n " + JSON_Time;
				}
				else 
				{
					Temperature_Text.text = temperature.ToString("f0").Substring(0, 2)+"° C " + ", "+ JSON_Weather + " in \n " + JSON_Name + ",\n " + JSON_Country + "\n " + JSON_Time;
				}
				if (JSON_Weather == "Overcast" || JSON_Weather == "Partly cloudy" || JSON_Weather == "Cloudy") {
					StateWeather = 5;
					Debug.Log (StateWeather);
				}
				else if (JSON_Weather == "Sunny"){
						StateWeather = 3;
						Debug.Log (StateWeather);
				}
				else if (JSON_Weather == "Clear"){
					StateWeather = 2;
					Debug.Log (StateWeather);
				}
				else if (JSON_Weather == "Light rain" || JSON_Weather == "Heavy rain"){
					StateWeather = 6;
					Debug.Log (StateWeather);
				}
		}

	 }


	[System.Serializable]
	public class _condition{
		public string text;

	}

	[System.Serializable]
	public class _location{
		public string name;
		public string country;
		public string localtime;

	}

	[System.Serializable]
	public class _current{
		public _condition condition;
		public string temp_c;

	}


	[System.Serializable]
	public class _Particle{
		public _condition condition;
		public _location location;
		public _current current;
		public string temp;
		public string main;
	}
}