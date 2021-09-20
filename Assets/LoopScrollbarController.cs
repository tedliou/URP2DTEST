using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LoopScrollbarController : MonoBehaviour
{
    private Scrollbar scrollbar;

    private IEnumerator Start () {
        scrollbar = GetComponent<Scrollbar>();
        scrollbar.value = 0;
        while (true)
        {
            yield return new WaitForSeconds(.02f);
            scrollbar.value += scrollbar.value >= 1 ? -1 : .02f;
        }
    }
}
