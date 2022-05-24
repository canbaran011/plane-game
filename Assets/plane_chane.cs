using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_chane : MonoBehaviour
{
    public GameObject planeOne;
    public GameObject planeTwo;
    public GameObject planeThree;
    public GameObject planeFour;
    public GameObject planeFive;

    public GameObject panel;
    // Start is called before the first frame update

    public void planeOne_1Button()
    {
        planeOne.SetActive(true);
        planeTwo.SetActive(false);
        planeThree.SetActive(false);
        planeFour.SetActive(false);
        planeFive.SetActive(false);
        panel.SetActive(false);
    }
    public void planeTwo_1Button()
    {
        planeOne.SetActive(false);
        planeTwo.SetActive(true);
        planeThree.SetActive(false);
        planeFour.SetActive(false);
        planeFive.SetActive(false);
        panel.SetActive(false);
    }
    public void planeThree_1Button()
    {
        planeOne.SetActive(false);
        planeTwo.SetActive(false);
        planeThree.SetActive(true);
        planeFour.SetActive(false);
        planeFive.SetActive(false);
        panel.SetActive(false);
    }
    public void planeFour_1Button()
    {
        planeOne.SetActive(false);
        planeTwo.SetActive(false);
        planeThree.SetActive(false);
        planeFour.SetActive(true);
        planeFive.SetActive(false);
        panel.SetActive(false);
    }
    public void planeFive_1Button()
    {
        planeOne.SetActive(false);
        planeTwo.SetActive(false);
        planeThree.SetActive(false);
        planeFour.SetActive(false);
        planeFive.SetActive(true);
        panel.SetActive(false);
    }


    void Start()
    {
        planeOne.SetActive(false);
        planeTwo.SetActive(false);
        planeThree.SetActive(false);
        planeFour.SetActive(false);
        planeFive.SetActive(false);
        panel.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
