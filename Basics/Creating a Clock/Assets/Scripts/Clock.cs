using System;
using Unity.Mathematics;
using UnityEngine;

public class Clock : MonoBehaviour
{
  [SerializeField]
  Transform hoursPivot, minutesPivot, secondsPivot;

  const float hourToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

  void Update()
  {
    TimeSpan time = DateTime.Now.TimeOfDay;
    hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hourToDegrees * (float)time.TotalHours);
    minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
    secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
  }
}