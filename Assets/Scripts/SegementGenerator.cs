using System.Collections;
using UnityEngine;

public class SegementGenerator : MonoBehaviour
{
    public GameObject segmentMap01;
    public GameObject segmentMap02;
    public GameObject segmentMap03;
    public GameObject segmentMap04;
    public GameObject segmentMap05;
    public GameObject segmentMap06;
    public GameObject segmentMap07;

    [SerializeField] int zPos = 50;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum = 0;

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
