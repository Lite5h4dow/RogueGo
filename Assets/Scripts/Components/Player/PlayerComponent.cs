using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct Player:IComponentData{}
  public class PlayerComponent : ComponentDataProxy<Player>{}
}