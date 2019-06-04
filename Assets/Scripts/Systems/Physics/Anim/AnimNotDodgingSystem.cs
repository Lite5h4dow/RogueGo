using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class AnimNotDodgingSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(Animator),
        ComponentType.Exclude(typeof(Dodging))
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach((Animator anim) => {
        anim.SetBool("isDodging", false);
      });
    }
  }
}