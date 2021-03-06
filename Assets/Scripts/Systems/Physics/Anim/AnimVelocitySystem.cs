using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  public class AnimVelocitySystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        ComponentType.Exclude(typeof(CollidedWithGround)),
        typeof(Player),
        typeof(Animator),
        typeof(Rigidbody2D)
      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach((Animator anim, Rigidbody2D rigid) => {
        anim.SetFloat("verticalVelocity", rigid.velocity.y);
      });
    }
  }
}