using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct JumpInput:IComponentData{
    public float Value;
  }
  public class JumpInputComponent : ComponentDataProxy<JumpInput>{}
}