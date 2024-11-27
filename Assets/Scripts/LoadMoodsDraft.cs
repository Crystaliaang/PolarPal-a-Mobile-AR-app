using UnityEngine;

// CHANGE THE NAME
public class LoadMoodsDraft : MonoBehaviour
{
    public Weather_API weatherAPI;
    public GameObject sunnyObject;
    public GameObject cloudyObject;
    public GameObject overcastObject;
    public GameObject rainObject;
    public GameObject nightObject;

    void Update()
    {
        // Check if the weather API has fetched the weather data
        if (weatherAPI != null && weatherAPI.JSON_Weather != null)
        {
            // Get the current weather from the weather API script
            string currentWeather = weatherAPI.JSON_Weather.ToLower();

            // Enable/disable objects based on the current weather
            if (currentWeather.Contains("sunny"))
            {
                EnableObject(sunnyObject);
            }
            else if (currentWeather.Contains("cloudy") || currentWeather.Contains("partly cloudy"))
            {
                EnableObject(cloudyObject);
            }
            else if (currentWeather.Contains("overcast"))
            {
                EnableObject(overcastObject);
            }
            else if (currentWeather.Contains("rain"))
            {
                EnableObject(rainObject);
            }
            else // Nighttime or other weather condition
            {
                EnableObject(nightObject);
            }
        }
    }

    void EnableObject(GameObject obj)
    {
        // Disable all objects
        sunnyObject.SetActive(false);
        cloudyObject.SetActive(false);
        overcastObject.SetActive(false);
        nightObject.SetActive(false);

        // Enable the specified object
        obj.SetActive(true);
    }
}
