using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryAnimCassel : MonoBehaviour
{
    public GameObject batEffect;
    public Transform batLeft;
    public Transform batRight;

    IEnumerator StartStoryAnim()
    {

        yield return new WaitForSeconds(15);
        SceneManager.LoadScene("Playing");

    }

    //bat effect between 7-11 in video
    IEnumerator CreateBat()
    {

        yield return new WaitForSeconds(7);
        Instantiate(batEffect,batLeft.position, Quaternion.identity);
        Instantiate(batEffect, batRight.position, Quaternion.identity);
        Destroy(batEffect, 5);

    }

    void Start()
    {
        StartCoroutine(StartStoryAnim());
        StartCoroutine(CreateBat());
    }


    public void SkipStory()
    {
        SceneManager.LoadScene("Playing");

    }

}
