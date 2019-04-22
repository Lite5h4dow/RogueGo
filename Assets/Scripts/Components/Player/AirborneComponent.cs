using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct Airborne:IComponentData{}
  public class AirborneComponent : ComponentDataProxy<Airborne>{}
}