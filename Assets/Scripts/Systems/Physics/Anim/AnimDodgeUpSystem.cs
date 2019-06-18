using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class AnimDodgeUpSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(Animator),
        typeof(DodgeUp)
      );
    }

    protected override void OnUpdate() {

      Entities.With(player).ForEach((Entity entity, Animator anim) => {
        PostUpdateCommands.RemoveComponent<DodgeUp>(entity);
        anim.SetTrigger("DodgeUp");
      });
    }
  }
}