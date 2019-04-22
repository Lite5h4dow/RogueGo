using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  public class MovementVelocitySystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery (
        typeof (Player),
        typeof (MovementInput),
        typeof (MovementVelocity),
        typeof (Rigidbody2D)
      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach((Rigidbody2D rigid, ref MovementInput input, ref MovementVelocity velocity) =>{
        rigid.velocity = new float2(input.Value * velocity.Value, rigid.velocity.y);
      });
    }
  }
}