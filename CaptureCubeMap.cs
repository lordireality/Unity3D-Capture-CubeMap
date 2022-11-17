using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureCubeMap : MonoBehaviour
{
    //выставляем aspect ratio на 1:1, 45 угол камеры
    //вешаем скрипт на камеру
    //game-object-ы пустышки с указаением точного направления камеры 
    public string CubeMapName = "empty";
    public GameObject Front;
    public GameObject Back;
    public GameObject Left;
    public GameObject Right;
    public GameObject Top;
    public GameObject Bottom;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1)) { BakeFront(); }
        if (Input.GetKeyDown(KeyCode.F2)) { BakeBack(); }
        if (Input.GetKeyDown(KeyCode.F3)) { BakeLeft(); }
        if (Input.GetKeyDown(KeyCode.F4)) { BakeRight(); }
        if (Input.GetKeyDown(KeyCode.F5)) { BakeTop(); }
        if (Input.GetKeyDown(KeyCode.F6)) { BakeBottom(); }
    }


    public void BakeFront()
    {
        this.transform.rotation = Front.transform.rotation;
        Application.CaptureScreenshot("Front_" + CubeMapName + ".png", 4);
    }
    public void BakeBack()
    {
        this.transform.rotation = Back.transform.rotation;
        Application.CaptureScreenshot("Back_" + CubeMapName + ".png", 4);
    }
    public void BakeLeft()
    {
        this.transform.rotation = Left.transform.rotation;
        Application.CaptureScreenshot("Left_" + CubeMapName + ".png", 4);
    }
    public void BakeRight()
    {
        this.transform.rotation = Right.transform.rotation;
        Application.CaptureScreenshot("Right_" + CubeMapName + ".png", 4);
    }
    public void BakeTop()
    {
        this.transform.rotation = Top.transform.rotation;
        Application.CaptureScreenshot("Top_" + CubeMapName + ".png", 4);
    }
    public void BakeBottom()
    {
        this.transform.rotation = Bottom.transform.rotation;
        Application.CaptureScreenshot("Bottom_" + CubeMapName + ".png", 4);
    }
}
