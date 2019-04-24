using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct JumpKeyDown:IComponentData{}
  public class JumpKeyDownComponent : ComponentDataProxy<JumpKeyDown>{}
}