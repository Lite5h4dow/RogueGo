using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct CollidedWithGround:IComponentData{
      public Impact Value;
  }
}