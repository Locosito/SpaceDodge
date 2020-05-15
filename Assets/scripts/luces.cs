using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class luces : MonoBehaviour
{

    SerialPort serialPort = new SerialPort("COM3", 115200);
    public static int lucesINT;

    void Start()
    {
        serialPort.Open();
        serialPort.ReadTimeout = 100;
    }

    private void Update()
    {
        if (serialPort.IsOpen)
        {
            if (lucesINT == 0)
            {
                serialPort.Write("0");
            }

            if (lucesINT == 1)
            {
                serialPort.Write("1");
            }
        }
    }
    


}

