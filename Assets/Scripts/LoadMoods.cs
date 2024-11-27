using UnityEngine;
using TMPro;

public class LoadMoods : MonoBehaviour
{
    public Weather_API weatherAPI;
     GameObject arObject;
    public TMP_Text tempText;

    public GameObject umbrellaPlacedPrefab;
    public GameObject glassesPlacedPrefab;
    public GameObject rainPlacedPrefab;
    public GameObject sunPlacedPrefab;
    public GameObject moonPlacedPrefab;
    public GameObject cloudPlacedPrefab;
    public GameObject penguinObject;

    bool dive;
    bool Hello;
    bool Hot;
    bool Laying;
    bool Sleeping;
    bool Walk;
    bool Raining;

    bool diveFlag = false;



    public GameObject arUmbrella { get; private set; }
    public GameObject arGlasses { get; private set; }
    public GameObject arRain { get; private set; }
    public GameObject arSun { get; private set; }
    public GameObject arMoon { get; private set; }
    public GameObject arCloud { get; private set; }


    public void LoadMoodsFunc()
    {
        //tempText.text = $"true load moods";
        // Check if the weather API has fetched the weather data
        if (weatherAPI != null && weatherAPI.JSON_Weather != null)
        {
            // Get the current weather from the weather API script
            string currentWeather = weatherAPI.JSON_Weather.ToLower();

            // Enable/disable objects based on the current weather
            if (currentWeather.Contains("sunny"))
            {
                tempText.text = $"true Sunny";
                //DisableAllAnimations();
                //arSun = Instantiate(sunPlacedPrefab);
                // arSun = Instantiate(sunPlacedPrefab, penguinObject.transform.position, Quaternion.identity);
                if (arSun == null) { arSun = Instantiate(sunPlacedPrefab); }
                else { arSun.SetActive(true); }
            }
            else if (currentWeather.Contains("cloudy") || currentWeather.Contains("partly cloudy") || currentWeather.Contains("overcast"))
            {
                //DisableAllAnimations();
                if (arCloud == null) { arCloud = Instantiate(sunPlacedPrefab); }
                else { arCloud.SetActive(true); }
            }
            else if (currentWeather.Contains("rain"))
            {
               // DisableAllAnimations();
                if (arRain == null) { arRain = Instantiate(rainPlacedPrefab); }
                else { arRain.SetActive(true); }
            }
            else // Nighttime or other weather condition
            {
                //DisableAllAnimations();
                if (arMoon == null) { arMoon = Instantiate(moonPlacedPrefab); }
                else { arMoon.SetActive(true); }
            }
        }
    }

    void Update()
    {
       
            arObject = GameObject.FindGameObjectWithTag("Penguin2");
        
    }

    public void diveFunc() {
        if (diveFlag == false)
        {
            arObject.GetComponent<Animator>().SetBool("dive", true);
            diveFlag = true;
        }
    }

    public void DisableAllAnimations()
    {
        arObject.GetComponent<Animator>().SetBool("dive", false);
        arObject.GetComponent<Animator>().SetBool("Hello", false);
        arObject.GetComponent<Animator>().SetBool("Hot", false);
        arObject.GetComponent<Animator>().SetBool("Laying", false);
        arObject.GetComponent<Animator>().SetBool("Sleeping", false);
        // arObject.GetComponent<Animator>().SetBool("Walk", false);
        arObject.GetComponent<Animator>().SetBool("Raining", false);
        if (arGlasses != null) { arGlasses.SetActive(false); }
        if (arUmbrella != null) { arUmbrella.SetActive(false); }
        if (arRain != null) { arRain.SetActive(false); }
        if (arSun != null) { arSun.SetActive(false); }
        if (arMoon != null) { arMoon.SetActive(false); }
        if (arCloud != null) { arCloud.SetActive(false); }
    }

    public GameObject umbrellaPrefab
    {
        get { return umbrellaPlacedPrefab; }
        set { umbrellaPlacedPrefab = value; }
    }

    public GameObject glassesPrefab
    {
        get { return glassesPlacedPrefab; }
        set { glassesPlacedPrefab = value; }
    }
    public GameObject rainPrefab
    {
        get { return rainPlacedPrefab; }
        set { rainPlacedPrefab = value; }
    }

    public GameObject sunPrefab
    {
        get { return sunPlacedPrefab; }
        set { sunPlacedPrefab = value; }
    }

    public GameObject moonPrefab
    {
        get { return moonPlacedPrefab; }
        set { moonPlacedPrefab = value; }
    }

    public GameObject cloudPrefab
    {
        get { return cloudPlacedPrefab; }
        set { cloudPlacedPrefab = value; }
    }
}
