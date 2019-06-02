using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class CameraFollowPlayerSystem : ComponentSystem {
    EntityQuery player;
    EntityQuery camera;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(Rigidbody2D),
        typeof(Transform)
      );

      camera = GetEntityQuery(
        typeof(MainCamera),
        typeof(Camera),
        typeof(Transform),
        typeof(CameraLead),
        typeof(CameraMoveSpeed)
      );

      RequireForUpdate(player);
      RequireForUpdate(camera);
    }

    protected override void OnUpdate() {
      var playerEntity = player.GetSingletonEntity();
      var cameraEntity = camera.GetSingletonEntity();
      var playerPosition = EntityManager.GetComponentObject<Transform>(playerEntity).position;
      var playerVelocity = EntityManager.GetComponentObject<Rigidbody2D>(playerEntity).velocity.x;
      var velocity = Vector3.zero;

      Entities.With(camera).ForEach((Transform trans, ref CameraLead cl, ref CameraMoveSpeed cms) => {
        var playerDirection = Mathf.Round(Mathf.Clamp(playerVelocity * 100, -1, 1));
        var nextPosition = new Vector2(playerPosition.x, playerPosition.y) + new Vector2(cl.Value.x * playerDirection, cl.Value.y);

        trans.position = Vector3.SmoothDamp(
          trans.position,
          new Vector3(nextPosition.x, nextPosition.y, trans.position.z),
          ref velocity,
          Time.fixedDeltaTime,
          cms.Value
        );
      });
    }
  }
}