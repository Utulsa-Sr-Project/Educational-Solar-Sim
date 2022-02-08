/*      Created by Logan Edmund,11/6/21
 *      Modified on 11/27/21
 * 
 *      Script used to hold and manage the information passed tothe GameManager to create/reset preset simulation scenarios
 * 
 * 
 */


using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPresetSimulations : MonoBehaviour
{

    private GameManager gameManagerReference;

    public void ActivateUIElement(GameManager g)
    {
        SetGameManRef(g.GetComponent<GameManager>());
    }

    public void SetGameManRef(GameManager gm)
    {
        gameManagerReference = gm;
    }




    public void Simulation1() //elliptical orbit
    {


        GameManager.Instance.DeleteAllBodies();

        //(double mass, double xLoc, double yLoc, double zLoc, double xVel, double yVel, double zVel, double scal, bool shouldFocus, string name)
        GameManager.Instance.TrySpawnNewBody(Math.Pow(10,9), 0, 0, 0, 0, 0, 0, 8, false, "Aur", false);

        GameManager.Instance.TrySpawnNewBody(Math.Pow(10,3), 10, 0, 0, 0, 5, 0, 3, false, "Eos", false);

        GameManager.Instance.FocusOnUniverse();
    }

    public void Simulation2() //Circular Orbit
    {
        GameManager.Instance.DeleteAllBodies();

        GameManager.Instance.TrySpawnNewBody(Math.Pow(10, 9), 0, 0, 0, 0, 0, 0, 8, false, "Aur", false);

        GameManager.Instance.TrySpawnNewBody(Math.Pow(10, 3), 15, 0, 0, 0, 4.5, 0, 3, false, "Eos", false);

        GameManager.Instance.FocusOnUniverse();
    }

    public void Simulation3() //Slingshot
    {
        GameManager.Instance.DeleteAllBodies();

        GameManager.Instance.TrySpawnNewBody(Math.Pow(10, 9), 0, 0, 0, 0, 0, 0, 8, false, "Aur", false);

        GameManager.Instance.TrySpawnNewBody(Math.Pow(10, 3), -15, -30, 0, 0, 7, 0, 3, false, "Eos", false);

        GameManager.Instance.FocusOnUniverse();
    }

    public void Simulation4() //Circular Opposing Moons
    {
        GameManager.Instance.DeleteAllBodies();

        GameManager.Instance.TrySpawnNewBody(Math.Pow(10, 9), 0, 0, 0, 0, 0, 0, 8, false, "Aur", false);

        GameManager.Instance.TrySpawnNewBody(Math.Pow(10, 3), 15, 0, 0, 0, 4.5, 0, 3, false, "Eos", false);

        GameManager.Instance.TrySpawnNewBody(Math.Pow(10, 3), -15, 0, 0, 0, -4.5, 0, 3, false, "Ipo", false);
        
        GameManager.Instance.FocusOnUniverse();
    }

    public void Simulation5() //Inner/Outer Elliptical Moons
    {
        GameManager.Instance.DeleteAllBodies();

        GameManager.Instance.TrySpawnNewBody(Math.Pow(10, 9), 0, 0, 0, 0, 0, 0, 8, false, "Aur", false);

        GameManager.Instance.TrySpawnNewBody(5*Math.Pow(10, 6), 13, 8, 0, -2.5, 3.8, 0, 4.5, false, "Eln", false);

        GameManager.Instance.TrySpawnNewBody(Math.Pow(10, 2), -22, 0, 0, 0, -3.6, 0, 3, false, "Eos", false);

        GameManager.Instance.FocusOnUniverse();
    }

    public void HidePanel() => this.gameObject.SetActive(false);
}