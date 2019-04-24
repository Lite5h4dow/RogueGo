using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct JumpKeyUp:IComponentData{}
  public class JumpKeyUpComponent : ComponentDataProxy<JumpKeyUp>{}
}