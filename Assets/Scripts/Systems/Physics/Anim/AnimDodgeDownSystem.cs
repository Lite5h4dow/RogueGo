using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class AnimDodgeDownSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(Animator),
        typeof(DodgeDown)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach((Entity entity, Animator anim) => {
        PostUpdateCommands.RemoveComponent<DodgeDown>(entity);
        anim.SetTrigger("DodgeDown");
      });
    }
  }
}