using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class FaultRandomize : MonoBehaviour
{
    public bool working1;
    public bool working2;   
    public bool working3;
    // F1 Circuit Breakers on L+R EFAB
    public List<GameObject> CircuitBreakers; //Popped CB
    public List<GameObject> NormalCB; //Normal CB to be hidden
    public List<bool> CircuitBreakerStates; // Bool Checks

    // F2 APU OilSight
    public GameObject MissingAPUSight;
    public GameObject NormalAPUSight;

    //F3 Hydraulics leak
    public List<GameObject> Puddles;

    //F4 Oil Leak
    public GameObject oilDroplet;
    public GameObject spawnPoint;
    public float minSpawnInterval = 1.2f;
    public float maxSpawnInterval = 5.0f;
    public float timeToLive = 5.0f;

    //F5 R EFAB Gun Count Selector
    
    //F6 R EFAB Loader Clutch Not Secure
    public GameObject ClutchSecured;
    public GameObject ClutchLoose;

    //F7 Extinguisher Panel Expired, C# Logic is in Locks Script

    //F8 Extinguisher Panel Missing
    public GameObject Extinguisher;

    //F9 R Pylon Panel Avionics Bay Battery Not Latch
    public GameObject BatteryLatch;

    //F10 R Aft Avionics Bay NIU
    public GameObject NIUFaulty;
    public GameObject NIUNormal;

    //F11 Accumulator Handpump not secured
    public GameObject HandlePinUnsafe;
    public GameObject HandlePinSafe;

    //F12 Accumulator Util Hydraulic <2600psi
    int RandomFailValue = 0;
    int RandomNormalValue = 0;
    public TMP_Text AccumulatorPressureReadout;


    //F13 Accumulator Service Dip Below Min

    //F14 Engine Pop pin Eng 1
    public List<GameObject> Pins1;

    //F15 Engine Pop Pin Eng 2
    public List<GameObject> Pins2;

    //F16 Deflated Tyre
    public GameObject Helicopter;
    public GameObject HelicopterOffSet;

    public GameObject World;


    private void Start()
    {
        if (GameManager._me.IsAssessmentMode) // Issue will appear if empty list F5,F11,F13 Are the remaining faults not added
        {
            if (GameManager._me.F1)
                CBActive();

            if (GameManager._me.F2)
                APUSIGHTActive();
            else
                APUSIGHTNormal();

            if (GameManager._me.F3)
                HydraulicLeak();

            if (GameManager._me.F4)
                StartCoroutine(SpawnOilDroplets());

            //F5 GunCount Dial Logic is under GunCountKnob Script

            if (GameManager._me.F6)
                LoaderClutchLoose();
            else
                LoaderClutchSecured();

            //F7 FireExtinguisher Expiry Logic is in Locks Script

            if (GameManager._me.F8)
                ExtinguisherMissing();

            if (GameManager._me.F9)
                BatteryLatchStatus();

            if (GameManager._me.F10)
                NIUBroken();
            else
                NIUWorking();

            if (GameManager._me.F11)
                AccHandleNotSecure();
            else
                AccHandleSecured();

            if (GameManager._me.F12)
                AccumulatorPressureFail();
            else
                AccumulatorPressurePass();

            /*if (GameManager._me.F13)
                ExtinguisherExpired();*/

            if (GameManager._me.F14) //Remember Set Inactive by default
                Poppin1();

            if (GameManager._me.F15) //Remember Set Inactive by default
                Poppin2();

            if (GameManager._me.F16)
                FlatTyre();
            else
                NormalTyre();

        }
    }

    void CBActive()
    {
        if (CircuitBreakers.Count > 0 && NormalCB.Count == CircuitBreakers.Count && CircuitBreakerStates.Count == CircuitBreakers.Count)
        {
            int activeIndex1 = Random.Range(0, CircuitBreakers.Count);
            CircuitBreakers[activeIndex1].SetActive(true);
            NormalCB[activeIndex1].SetActive(false);
            CircuitBreakerStates[activeIndex1] = true;
            Debug.Log($"Circuit Breaker element {activeIndex1} Set Confirmed Active");

            for (int i = 0; i < CircuitBreakers.Count; i++)
            {
                if (i != activeIndex1)
                {
                    bool isActive = Random.Range(-1, 10) == 4;

                    if (isActive)
                    {
                        CircuitBreakers[i].SetActive(true);
                        Debug.Log($"Circuit Breaker element {i} Set Active");
                    }
                    else
                    {
                        CircuitBreakers[i].SetActive(false);
                        Debug.Log($"Circuit Breaker {i + 1} Set Inactive");
                    }

                    NormalCB[i].SetActive(!isActive);
                    CircuitBreakerStates[i] = isActive;
                }
            }
        }
        else
        {
            Debug.LogWarning("CircuitBreakers list is empty, NormalCB list is not properly initialized, or CircuitBreakerStates list is not properly initialized.");
        }
    }
    public void UpdateCircuitBreakerState(int index, bool newState)
    {
        if (index >= 0 && index < CircuitBreakerStates.Count)
        {
            CircuitBreakerStates[index] = newState;
        }
        else
        {
            Debug.LogError("Invalid index when updating circuit breaker state.");
        }
    }

    void APUSIGHTActive()
    {
        MissingAPUSight.SetActive(true);
        NormalAPUSight.SetActive(false);
    }

    void APUSIGHTNormal()
    {
        MissingAPUSight.SetActive(false);
        NormalAPUSight.SetActive(true);
    }
    void HydraulicLeak()
    {
        working3 = true;
        int activeIndex3 = Random.Range(0, Puddles.Count);
        working1 = true;
        Puddles[activeIndex3].SetActive(true);
        working2 = true;

        Debug.Log($"Puddle {activeIndex3 + 1} Set Confirmed Active");

        for (int i = 0; i < Puddles.Count; i++)
        {
            if (i != activeIndex3)
            {
                bool isActive3 = Random.Range(-1, 10) == 4;

                if (isActive3)
                {
                    Puddles[i].SetActive(true);
                    Debug.Log($"Puddles {i + 1} Set Active");
                }
                else
                {
                    Puddles[i].SetActive(false);
                    Debug.Log($"Puddles {i + 1} Set Inactive");
                }
            }
        }
    }

    IEnumerator SpawnOilDroplets()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnInterval, maxSpawnInterval));

            if (spawnPoint != null && oilDroplet != null)
            {
                // Get a random position within the spawnPoint's bounds
                Vector3 randomPosition = spawnPoint.transform.position +
                    new Vector3(Random.Range(-spawnPoint.transform.localScale.x / 2, spawnPoint.transform.localScale.x / 2),
                                Random.Range(-spawnPoint.transform.localScale.z / 2, spawnPoint.transform.localScale.z / 2));

                GameObject spawnedObject = Instantiate(oilDroplet, randomPosition, Quaternion.identity);

                // Schedule the deletion of the spawned object
                Destroy(spawnedObject, timeToLive);
            }
            else
            {
                Debug.LogError("Prefab, spawn point, or both not assigned in the inspector!");
            }
        }
    }

    void LoaderClutchLoose()
    {
        ClutchSecured.SetActive(false);
        ClutchLoose.SetActive(true);
    }

    void LoaderClutchSecured()
    {
        ClutchSecured.SetActive(true);
        ClutchLoose.SetActive(false);
    }

    void ExtinguisherMissing()
    {
        Extinguisher.SetActive(false);
    }

    void BatteryLatchStatus()
    {
        int latchrotation = 90;
        BatteryLatch.transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y - latchrotation, transform.eulerAngles.z);
    }

    void NIUBroken()
    {
        NIUFaulty.SetActive(true);
        NIUNormal.SetActive(false);
        Debug.Log("NIU Faulty");
    }

    void NIUWorking()
    {
        NIUFaulty.SetActive(false);
        NIUNormal.SetActive(true);
        Debug.Log("NIU Normal");
    }

    void AccHandleNotSecure()
    {
        HandlePinUnsafe.SetActive(true);
        HandlePinSafe.SetActive(false);
    }

    void AccHandleSecured()
    {
        HandlePinUnsafe.SetActive(false);
        HandlePinSafe.SetActive(true);
    }

    void AccumulatorPressureFail()
    {
        RandomFailValue = Random.Range(800, 1650);
        AccumulatorPressureReadout.text = RandomFailValue.ToString();

    }

    void AccumulatorPressurePass() //when not selected
    {
        RandomNormalValue = Random.Range(1700, 2000);
        AccumulatorPressureReadout.text = RandomNormalValue.ToString();
    }

    public void Poppin1()
    {
        if (Pins1.Count > 0 )
        {
            int activeIndex14 = Random.Range(0, Pins1.Count);
            Pins1[activeIndex14].SetActive(true);
            Debug.Log($"Engine Pin element {activeIndex14} Set Confirmed Active");

            for (int i = 0; i < Pins1.Count; i++)
            {
                if (i != activeIndex14)
                {
                    bool isActive = Random.Range(-1, 10) == 4;

                    if (isActive)
                    {
                        Pins1[i].SetActive(true);
                        Debug.Log($"Circuit Breaker element {i} Set Active");
                    }
                }
            }
        }
    }

    public void Poppin2()
    {
        if (Pins2.Count > 0)
        {
            int activeIndex14 = Random.Range(0, Pins2.Count);
            Pins2[activeIndex14].SetActive(true);
            Debug.Log($"Engine Pin element {activeIndex14} Set Confirmed Active");

            for (int i = 0; i < Pins2.Count; i++)
            {
                if (i != activeIndex14)
                {
                    bool isActive = Random.Range(-1, 10) == 4;

                    if (isActive)
                    {
                        Pins2   [i].SetActive(true);
                        Debug.Log($"Circuit Breaker element {i} Set Active");
                    }
                }
            }
        }
    }

    void FlatTyre()
    {
        Vector3 targetPosition = new Vector3(-28.32326f, 7.2f, -13.51473f); // Replace x, y, z with the actual coordinates
        World.transform.position = targetPosition;

        // HelicopterOffSet.SetActive(true);
        //Helicopter.SetActive(false);


        /*Vector3 targetPosition = new Vector3(71.46f, 5.06f, -60.97f); // Replace x, y, z with the actual coordinates
        Quaternion targetRotation = Quaternion.Euler(-3.377f, -44.262f, 5.503f);

        Helicopter.transform.position = targetPosition;
        Helicopter.transform.rotation = targetRotation; */
    }

    void NormalTyre()
    {


        Vector3 targetPosition = new Vector3(-28.32326f, 7.068951f, -13.51473f); // Replace x, y, z with the actual coordinates
        World.transform.position = targetPosition;


        //HelicopterOffSet.SetActive(false);
        //Helicopter.SetActive(true);


        /*Vector3 targetPosition = new Vector3(71.62646f, 5.101439f, -61.1241f); // Replace x, y, z with the actual coordinates
        Quaternion targetRotation = Quaternion.Euler(0f, -44.014f, 5.794f);

        Helicopter.transform.position = targetPosition;
        Helicopter.transform.rotation = targetRotation; */
    }
}
