using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo{
  public class JumpReleaseEndSystem : ComponentSystem {
    EntityQuery player;
    EntityQuery key;

    protected override void OnCreateManager () {
      player= GetEntityQuery (
        typeof(Player),
        typeof(JumpLaunch)
      );

      key = GetEntityQuery(
        typeof(JumpKeyUp)
      );

      RequireForUpdate(player);
      RequireForUpdate(key);
    }

    protected override void OnUpdate () { 
      Entities.With(player).ForEach(entity => {
        PostUpdateCommands.RemoveComponent<JumpLaunch>(entity);
        PostUpdateCommands.AddComponent<JumpEnd>(entity, new JumpEnd{});
      });
    }
  }
}