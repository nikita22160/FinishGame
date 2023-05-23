using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuBatton : MonoBehaviour
{
    public void Transition()
    {
        SceneManager.LoadScene(0);
    }
}
