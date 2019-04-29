using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct LaunchDuration:IComponentData{
    public float Value;
  }
  public class LaunchDurationComponent : ComponentDataProxy<LaunchDuration>{}
}