using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimulationMenu : MonoBehaviour
{
    GameObject arObject;
   
    public GameObject umbrellaPlacedPrefab;
    public GameObject glassesPlacedPrefab;
    public GameObject rainPlacedPrefab;
    public GameObject sunPlacedPrefab;
    public GameObject hotSunPlacedPrefab;
    public GameObject moonPlacedPrefab;
    public GameObject cloudPlacedPrefab;

    bool dive;
    bool Hello;
    bool Hot;
    bool Laying;
    bool Sleeping;
    bool Walk;
    bool Raining;

    public GameObject arUmbrella { get; private set; }
    public GameObject arHotSun { get; private set; }
    public GameObject arGlasses { get; private set; }
    public GameObject arRain { get; private set; }
    public GameObject arSun { get; private set; }
    public GameObject arMoon { get; private set; }
    public GameObject arCloud { get; private set; }

    void Start()
    {
        arObject = GameObject.FindGameObjectWithTag("Penguin2");
    }

    public void Day()
    {

        DisableAllAnimations();
        arObject.GetComponent<Animator>().SetBool("Hello", true);
        if (arSun == null) { arSun = Instantiate(sunPlacedPrefab); }
        else { arSun.SetActive(true); }

    }

    public void Night()
    {
        DisableAllAnimations();
        arObject.GetComponent<Animator>().SetBool("Sleeping", true);
        if (arMoon == null) { arMoon = Instantiate(moonPlacedPrefab); }
        else { arMoon.SetActive(true); }

    }


    public void Dive()
    {
        DisableAllAnimations();
        arObject.GetComponent<Animator>().SetBool("dive", true);

    }

    public void Rain()
    {
        DisableAllAnimations();
        arObject.GetComponent<Animator>().SetBool("Raining", true);
        if (arRain == null) { arRain = Instantiate(rainPlacedPrefab); }
        else { arRain.SetActive(true); }
        if (arUmbrella == null) { arUmbrella = Instantiate(umbrellaPlacedPrefab); }
        else { arUmbrella.SetActive(true); }
    }

    public void Heating()
    {
        DisableAllAnimations();
        arObject.GetComponent<Animator>().SetBool("Hot", true);
        if (arGlasses != null) { arGlasses.SetActive(false); }
        if (arUmbrella != null) { arUmbrella.SetActive(false); }
        if (arRain != null) { arRain.SetActive(false); }
        if (arHotSun == null) { arHotSun = Instantiate(hotSunPlacedPrefab); }
        else { arHotSun.SetActive(true); }
    }

    public void Walking()
    {
        
        DisableAllAnimations();
        arObject.GetComponent<Animator>().SetBool("Walk", true);
    }



    public void Lay()
    {
        DisableAllAnimations();
        arObject.GetComponent<Animator>().SetBool("Laying", true);
        if (arGlasses != null) { arGlasses.SetActive(false); }
        if (arUmbrella != null) { arUmbrella.SetActive(false); }
        if (arSun == null) { arSun = Instantiate(sunPlacedPrefab); }
        else { arSun.SetActive(true); }
    }

    void DisableAllAnimations()
    {
        arObject.GetComponent<Animator>().SetBool("dive", false);
        arObject.GetComponent<Animator>().SetBool("Hello", false);
        arObject.GetComponent<Animator>().SetBool("Hot", false);
        arObject.GetComponent<Animator>().SetBool("Laying", false);
        arObject.GetComponent<Animator>().SetBool("Sleeping", false);
        arObject.GetComponent<Animator>().SetBool("Walk", false);
        arObject.GetComponent<Animator>().SetBool("Raining", false);
        if (arGlasses != null) { arGlasses.SetActive(false); }
        if (arUmbrella != null) { arUmbrella.SetActive(false); }
        if (arRain != null) { arRain.SetActive(false); }
        if (arSun != null) { arSun.SetActive(false); }
        if (arHotSun != null) { arHotSun.SetActive(false); }
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

    public GameObject hotSunPrefab
    {
        get { return hotSunPlacedPrefab; }
        set { hotSunPlacedPrefab = value; }
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
