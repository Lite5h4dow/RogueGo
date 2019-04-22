using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using System.Linq;

namespace RogueGo {
  public class PlayerDebugSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery (
        typeof (Player)
      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach(player => Debug.Log("Player Found. ID = " + player.Index));
    }
  }
}