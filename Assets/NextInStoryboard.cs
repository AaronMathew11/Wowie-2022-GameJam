using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextInStoryboard : MonoBehaviour
{
 public void next()
 {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
 }
}