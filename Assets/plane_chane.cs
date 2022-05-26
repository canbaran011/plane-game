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

    public GameObject mainCamera;
    public GameObject leftCamera;
    public GameObject rightCamera;
    public GameObject frontCamera;



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

    public void leftCamera_Button(){
        mainCamera.SetActive(false);
        leftCamera.SetActive(true);
        rightCamera.SetActive(false);
        frontCamera.SetActive(false);
    }
        public void rightCamera_Button(){
        mainCamera.SetActive(false);
        leftCamera.SetActive(false);
        rightCamera.SetActive(true);
        frontCamera.SetActive(false);
    }
        public void frontCamera_Button(){
        mainCamera.SetActive(false);
        leftCamera.SetActive(false);
        rightCamera.SetActive(false);
        frontCamera.SetActive(true);
    }
        public void mainCamera_Button(){
        mainCamera.SetActive(true);
        leftCamera.SetActive(false);
        rightCamera.SetActive(false);
        frontCamera.SetActive(false);
    }


    void Start()
    {
        mainCamera.SetActive(true);
        leftCamera.SetActive(false);
        rightCamera.SetActive(false);
        frontCamera.SetActive(false);

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
