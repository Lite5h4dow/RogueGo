using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct MovementInput:IComponentData{
      public float Value;
  }
  public class MovementInputComponent : ComponentDataProxy<MovementInput>{}
}