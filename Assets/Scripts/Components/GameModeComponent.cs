using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct GameMode:IComponentData{}
  public class GameModeComponent : ComponentDataProxy<GameMode>{}
}