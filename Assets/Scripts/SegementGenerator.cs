using System.Collections;
using UnityEngine;

public class SegementGenerator : MonoBehaviour
{
    public GameObject segementMap01;
    public GameObject segementMap02;
    public GameObject segementMap03;
    public GameObject segementMap04;
    public GameObject segementMap05;
    public GameObject segementMap06;
    public GameObject segementMap07;

    void Start()
    {
        StartCoroutine(SegmentGen());
    }

    IEnumerator SegmentGen()
    {
        yield return new WaitForSeconds(10);
        segementMap02.SetActive(true);
        yield return new WaitForSeconds(10);
        segementMap03.SetActive(true);
    }
}
