using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct JumpEnd:IComponentData{}
  public class JumpEndComponent : ComponentDataProxy<JumpEnd>{}
}