using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct JumpVelocity:IComponentData{
      public float Value;
  }
  public class JumpVelocityComponent : ComponentDataProxy<JumpVelocity>{}
}