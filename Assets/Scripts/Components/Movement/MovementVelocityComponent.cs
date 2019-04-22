using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct MovementVelocity:IComponentData{
      public float Value;
  }
  public class MovementVelocityComponent : ComponentDataProxy<MovementVelocity>{}
}